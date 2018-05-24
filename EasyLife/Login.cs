using CCWin;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLife
{
    public partial class Login : CCSkinMain
    {
        SecurityCode securitycode = new SecurityCode(4);
        public Login()
        {
            InitializeComponent();
            securitycode.UpdateVerifyCode();
            pictureBox1.Image = securitycode.getImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            pictureBox1.Image = securitycode.getImage();
        }
    }
}
