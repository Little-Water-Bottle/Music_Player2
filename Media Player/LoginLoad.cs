using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class LoginLoad : Form
    {
        public LoginLoad()
        {
            InitializeComponent();
        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            
            if(panelProgressbar.Width >= 300)
                panelProgressbar.Width += 10;
            else
                panelProgressbar.Width += 5;

            if (panelProgressbar.Width >= 650)
            {
                timerProgressbar.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
