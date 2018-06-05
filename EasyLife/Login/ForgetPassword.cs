using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLife.Login
{
    public partial class ForgetPassword : UserControl
    {
        private DialogResult diglog;
        public DialogResult Diglog
        {
            get { return diglog; }
            set { diglog = value; }
        }
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void BtnForgetPwd_Click(object sender, EventArgs e)
        {
            this.Diglog = DialogResult.OK;
            this.Visible = false;
        }

        private void BtnCacel_Click(object sender, EventArgs e)
        {
            this.Diglog = DialogResult.Cancel;
            this.Visible = false;
        }
    }
}
