using System.Diagnostics;
using System.Net;
using System.Text;

namespace LanguageChanger
{
    public partial class Main : Form
    {
        WSClient ws = new WSClient();

        public Main()
        {
            InitializeComponent();
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

        private void Main_Load(object sender, EventArgs e)
        {
            nameHey.Text = "Loading";

            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            App.Default.lockfile_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Riot Games\Riot Client\Config\lockfile");

            if (!LockfileFound()) { MessageBox.Show("Is riot Launched?"); Close(); }
            getPath();
            HeyTxt();
            LangTxt();
            setAllLang();
            getInstallPath();
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
    }
}
