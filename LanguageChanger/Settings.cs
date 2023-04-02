using System.Drawing;
using Transitions;

namespace LanguageChanger
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            if (Properties.App.Default.current_theme == 1)
            {
                theme1.Select();
            }
            if (Properties. App.Default.current_theme == 2)
            {
                theme2.Select();
            }
            if (Properties.App.Default.current_theme == 3)
            {
                theme3.Select();
            }
            if (Properties.App.Default.current_theme == 4)
            {
                theme4.Select();
            }
            reloadSettings();
        }

        private void reloadSettings()
        {
            if (theme1.Checked)
            {
                Transition.run(colorprev1, "BackColor", Color.FromArgb(255, 216, 191, 216), new TransitionType_EaseInEaseOut(100));
                Transition.run(colorprev2, "BackColor", Color.FromArgb(255, 32, 26, 43), new TransitionType_EaseInEaseOut(300));
                Transition.run(colorprev3, "BackColor", Color.FromArgb(255, 138, 43, 255), new TransitionType_EaseInEaseOut(500));
                Transition.run(colorprev4, "BackColor", Color.FromArgb(255, 255, 0, 255), new TransitionType_EaseInEaseOut(700));
            }

            if(theme2.Checked)
            {
                Transition.run(colorprev1, "BackColor", Color.FromArgb(255, 191, 191, 216), new TransitionType_EaseInEaseOut(100));
                Transition.run(colorprev2, "BackColor", Color.FromArgb(255, 28, 28, 46), new TransitionType_EaseInEaseOut(300));
                Transition.run(colorprev3, "BackColor", Color.FromArgb(255, 65, 105, 225), new TransitionType_EaseInEaseOut(500));
                Transition.run(colorprev4, "BackColor", Color.FromArgb(255, 0, 191, 255), new TransitionType_EaseInEaseOut(700));
            }

            if(theme3.Checked)
            {
                Transition.run(colorprev1, "BackColor", Color.FromArgb(255, 216, 216, 191), new TransitionType_EaseInEaseOut(100));
                Transition.run(colorprev2, "BackColor", Color.FromArgb(255, 34, 34, 20), new TransitionType_EaseInEaseOut(300));
                Transition.run(colorprev3, "BackColor", Color.FromArgb(255, 155, 155, 95), new TransitionType_EaseInEaseOut(500));
                Transition.run(colorprev4, "BackColor", Color.FromArgb(255, 252, 252, 155), new TransitionType_EaseInEaseOut(700));
            }

            if(theme4.Checked)
            {
                Transition.run(colorprev1, "BackColor", Color.FromArgb(255, 191, 216, 191), new TransitionType_EaseInEaseOut(100));
                Transition.run(colorprev2, "BackColor", Color.FromArgb(255, 35, 58, 35), new TransitionType_EaseInEaseOut(300));
                Transition.run(colorprev3, "BackColor", Color.FromArgb(255, 95, 155, 95), new TransitionType_EaseInEaseOut(500));
                Transition.run(colorprev4, "BackColor", Color.FromArgb(255, 155, 252, 155), new TransitionType_EaseInEaseOut(700));
            }
        }

        private void theme1_CheckedChanged(object sender, EventArgs e) { if(theme1.Checked) { reloadSettings(); } }
        private void theme2_CheckedChanged(object sender, EventArgs e) { if (theme2.Checked) { reloadSettings(); } }
        private void theme3_CheckedChanged(object sender, EventArgs e) { if (theme3.Checked) { reloadSettings(); } }
        private void theme4_CheckedChanged(object sender, EventArgs e) { if (theme4.Checked) { reloadSettings(); } }

        private void apply_Click(object sender, EventArgs e)
        {
            if (theme1.Checked) { Properties.App.Default.current_theme = 1; }
            if (theme2.Checked) { Properties.App.Default.current_theme = 2; }
            if (theme3.Checked) { Properties.App.Default.current_theme = 3; }
            if (theme4.Checked) { Properties.App.Default.current_theme = 4; }
            Properties.App.Default.Save();
        }
    }
}
