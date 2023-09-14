using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftUniStarter
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            txb_softUni.Text = Properties.Settings.Default.UserInput;
        }


        public string WebsiteURL
        {
            get { return txb_softUni.Text; }
            set { txb_softUni.Text = value; }
        }

        private void btn_saveAndExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserInput = txb_softUni.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txb_softUni_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
