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
            SetStyles();
        }

        private void BtnForgetPwd_Click(object sender, EventArgs e)
        {
            this.Diglog = DialogResult.OK;
            this.Visible = false;
        }
        private void SetStyles()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        private void BtnCacel_Click(object sender, EventArgs e)
        {
            this.Diglog = DialogResult.Cancel;
            this.Visible = false;
        }
    }
}
