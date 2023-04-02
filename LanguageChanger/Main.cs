using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using Transitions;

namespace LanguageChanger
{
    public partial class Main : Form
    {
        WSClient ws = new WSClient();
        private static int panelSpace = 2;
        private static int animInterval = 500;
        private static int animCCInterval = 250;

        private Color color1 = Color.Black;
        private Color color2 = Color.Black;
        private Color color3 = Color.Black;
        private Color color4 = Color.Black;

        public Main()
        {
            InitializeComponent();
        }

        private void animation()
        {
            loadColors();

            Size screenSize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screenSize.Width / 2 - Width / 2, screenSize.Height / 2 - Height / 2);
            this.Size = new Size(375, 110);
            this.Draggable(true);

            closebtn.Location = new Point(Width - closebtn.Width - panelSpace, panelSpace);
            settingsbtn.Location = new Point(Width - settingsbtn.Width - panelSpace, closebtn.Width);
            titlePanel.Location = new Point(panelSpace / 2, panelSpace / 2 + 5);
            allLanguage.Location = new Point(panelSpace, Height - allLanguage.Height - panelSpace);
            changeBtn.Location = new Point(allLanguage.Width + panelSpace * 2, Height - changeBtn.Height - panelSpace);
            currentLang.Location = new Point(allLanguage.Width + changeBtn.Width + panelSpace * 3, Height - currentLang.Height * 4 / 3 - panelSpace);

            topPanel.Top = 1;
            topPanel.SendToBack();
            topPanel.Enabled = false;
            topPanel.Parent = this;
            topPanel.Size = Size - new Size(panelSpace, panelSpace);
            topPanel.Location = new Point(panelSpace / 2, panelSpace / 2);

            nameHey.Parent = this;
            currentLang.Parent = this;
            titlePanel.Parent = this;
            allLanguage.Parent = this;
            changeBtn.Parent = this;

            topPanel.SendToBack();

            titlePanel.Enabled = false;
            titlePanel.Parent = topPanel;
            allLanguage.FlatStyle = FlatStyle.Flat;
            changeBtn.FlatStyle = FlatStyle.Flat;

            anim1.Interval = animInterval;
            anim2.Interval = animInterval;

            anim1.Start();
        }

        private void loadColors()
        {
            loadSettings();

            Transition.run(topPanel, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));

            Transition.run(nameHey, "ForeColor", color1, new TransitionType_EaseInEaseOut(animCCInterval));
            Transition.run(nameHey, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));

            Transition.run(currentLang, "ForeColor", color1, new TransitionType_EaseInEaseOut(animCCInterval));
            Transition.run(currentLang, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));

            Transition.run(titlePanel, "ForeColor", color1, new TransitionType_EaseInEaseOut(animCCInterval));
            Transition.run(titlePanel, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));

            Transition.run(allLanguage, "ForeColor", color1, new TransitionType_EaseInEaseOut(animCCInterval));
            Transition.run(allLanguage, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));

            Transition.run(changeBtn, "ForeColor", color1, new TransitionType_EaseInEaseOut(animCCInterval));
            Transition.run(changeBtn, "BackColor", color2, new TransitionType_EaseInEaseOut(animCCInterval));
        }

        private void anim1_Tick(object sender, EventArgs e)
        {
            loadColors();

            topPanel.Size = Size - new Size(panelSpace, panelSpace);
            topPanel.Location = new Point(panelSpace / 2, panelSpace / 2);

            anim2.Start();
            Transition.run(this, "BackColor", color3, new TransitionType_Acceleration(animInterval));
            anim1.Stop();
        }

        private void anim2_Tick(object sender, EventArgs e)
        {
            loadColors();

            anim1.Start();
            Transition.run(this, "BackColor", color4, new TransitionType_Acceleration(animInterval));
            anim2.Stop();
        }

        private void getPath()
        {
            if (File.Exists(App.Default.lockfile_path))
            {
                using (var fs = new FileStream(App.Default.lockfile_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var sr = new StreamReader(fs, Encoding.Default))
                {
                    string[] array;
                    string text = sr.ReadToEnd();
                    array = text.Split(":");
                    App.Default.lockfile_password = array[3];
                    App.Default.lockfile_port = array[2];
                    App.Default.lockfile_token = Strings.Base64Encode("riot:" + App.Default.lockfile_password);
                }
            }
        }

        private bool LockfileFound()
        {
            if (File.Exists(App.Default.lockfile_path)) { return true; } else { return false; }
        }

        private void loadSettings()
        {
            if (App.Default.current_theme == 1)
            {
                color1 = Color.FromArgb(255, 216, 191, 216);
                color2 = Color.FromArgb(255, 32, 26, 43);
                color3 = Color.FromArgb(255, 138, 43, 255);
                color4 = Color.FromArgb(255, 255, 0, 255);
            }
            if (App.Default.current_theme == 2)
            {
                color1 = Color.FromArgb(255, 191, 191, 216);
                color2 = Color.FromArgb(255, 28, 28, 46);
                color3 = Color.FromArgb(255, 65, 105, 225);
                color4 = Color.FromArgb(255, 0, 191, 255);
            }
            if (App.Default.current_theme == 3)
            {
                color1 = Color.FromArgb(255, 216, 216, 191);
                color2 = Color.FromArgb(255, 34, 34, 20);
                color3 = Color.FromArgb(255, 155, 155, 95);
                color4 = Color.FromArgb(255, 252, 252, 155);
            }
            if (App.Default.current_theme == 4)
            {
                color1 = Color.FromArgb(255, 191, 216, 191);
                color2 = Color.FromArgb(255, 35, 58, 35);
                color3 = Color.FromArgb(255, 95, 155, 95);
                color4 = Color.FromArgb(255, 155, 252, 155);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadSettings();
            animation();
            nameHey.Text = "Loading";

            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            App.Default.lockfile_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Riot Games\Riot Client\Config\lockfile");

            if (!LockfileFound()) { MessageBox.Show("Is your riot client launched?\nI see nothing personnally...", "Error (nothin' much tho) ! ;)"); Close(); }
            getPath();
            HeyTxt();
            LangTxt();
            setAllLang();
            getInstallPath();
            App.Default.Save();
        }

        private async void setAllLang()
        {
            bool setAllLang = await ws.GetAllLang();

            if (setAllLang)
            {
                var str = App.Default.all_lang.Replace("[","").Replace("]", "").Replace("\"", "");
                var strArray = str.Split(',');  // now you have an array of 3 strings
                allLanguage.Items.AddRange(strArray);
            }
            else
            {
                allLanguage.Items.Add("Language not found");
            }
        }

        private void getInstallPath()
        {

            App.Default.metadata_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"Riot Games\Metadata\valorant.live");
            App.Default.metadata_productsettings = Path.Combine(App.Default.metadata_path, "valorant.live.product_settings.yaml");
            //product_install_full_path: "F:/Riot Games/VALORANT/live"
            //C:\ProgramData\Riot Games\Metadata\valorant.live

            if(App.Default.debug)
            {
                Debug.WriteLine("=======================================================================================================================================");
                Debug.WriteLine("[DEBUG] - Main.cs:metadata_path : " + App.Default.metadata_path);
                Debug.WriteLine("[DEBUG] - Main.cs:metadata_productsettings : " + App.Default.metadata_productsettings);
            }

            if (File.Exists(App.Default.metadata_productsettings))
            {
                string text = File.ReadAllText(App.Default.metadata_productsettings);

                App.Default.local_gamepath = text.Split("product_install_full_path: \"")[1].Split("\"")[0];

                if (App.Default.debug)
                {
                    Debug.WriteLine("[DEBUG] - Main.cs:local_gamepath : " + App.Default.local_gamepath); ;
                    Debug.WriteLine("=======================================================================================================================================");
                }
            }
        }

        private async void HeyTxt()
        {
            bool setName = await ws.GetLocaluser();

            if(setName)
            {
                string[] hellostrs = { "Hey", "Yop", "Hello", "Salutations", "Bonjour", "Holà", "おはよう", "Ohayō", "Hi", "Heyyy~" };
                Random rand = new Random();
                int index = rand.Next(hellostrs.Length);

                nameHey.Text = hellostrs[index] + " " + App.Default.local_user + "#" + App.Default.local_tag + "!";
                nameHey.Location = new Point(Width / 2 - nameHey.Width / 2, Height / 2 - nameHey.Height / 2);
            } 
            else
            {
                nameHey.Text = "Can't get username? Is your launcher REALLLYY opened?";
            }
        }
        private async void LangTxt()
        {
            bool setLang = await ws.GetLocalLang();
            if (setLang)
            {
                currentLang.Text = "Current voice language is " + App.Default.local_lang;
            }
            else
            {
                currentLang.Text = "Can't get lang? Is your launcher REALLLYY opened?";
            }
        }

        private async void changeBtn_Click(object sender, EventArgs e)
        {
            changeBtn.Enabled = !changeBtn.Enabled;
            if(!App.Default.all_lang.Contains(App.Default.selected_lang) || App.Default.selected_lang == "") 
            {
                MessageBox.Show("Invalid language");
                return;
            }

            PakDL pakDL = new PakDL();
            bool boolean = await pakDL.downloadPak();
            if (boolean)
            {
                MessageBox.Show("Text language changed to " + App.Default.selected_lang);
            }
            changeBtn.Enabled = !changeBtn.Enabled;
            return;
        }

        private void allLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.Default.selected_lang = allLanguage.SelectedItem as string;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
