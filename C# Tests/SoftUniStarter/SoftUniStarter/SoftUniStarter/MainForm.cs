using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftUniStarter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();  //this and the row below opens the setting form 
            settings.Show();
        }

        public void btn_softUniLink_Click(object sender, EventArgs e)
        {

            using (Settings settingsForm = new Settings())
            {
                string websiteUrl = settingsForm.WebsiteURL;

                ProcessStartInfo softUniLink = new ProcessStartInfo
                {
                    FileName = websiteUrl,
                    UseShellExecute = true
                };

                Process.Start(softUniLink);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}