using CCWin;
using CCWin.SkinControl;
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
        SecurityCode securitycode;
        public Login()
        {
            InitializeComponent();
            securitycode = new SecurityCode(4);
        }

        private void SecCodePic_Click(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
        }

        private void BtnJpPwd_Click(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + TextPwd.Left - 25, this.Top + TextPwd.Bottom + 1, TextPwd.SkinTxt);
            pass.Show(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
        }
    }
}
