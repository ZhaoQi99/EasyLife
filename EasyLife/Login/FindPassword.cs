using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace EasyLife.Login
{
    public partial class FindPassword : UserControl
    {
        private BLL.User user = new BLL.User();
        public FindPassword()
        {
            InitializeComponent();
            TextBoxPdw1.Text = TextBoxPdw2.Text = TextBoxForPwdAns.Text = CmoBoxForQue.Text = TextBoxUserNam.Text = string.Empty;
        }

        private void BtnUpdatePass_Click(object sender, EventArgs e)
        {
            if(TextBoxPdw1.Text!=TextBoxPdw2.Text)
            {
                MessageBoxEx.Show("两次输入的密码不一致,请重新输入!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(user.Exists(TextBoxUserNam.Text)==false)
            {
                MessageBoxEx.Show("用户不存在!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(user.CheckForget(TextBoxUserNam.Text,CmoBoxForQue.Text,TextBoxForPwdAns.Text)==false)
            {
                MessageBoxEx.Show("密保问题或密保答案错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Model.User model = user.GetModel(TextBoxUserNam.Text);
            model.PassWord = TextBoxPdw1.Text;
            user.Update(model);
            MessageBoxEx.Show("密码更新成功!", "完成", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide();
        }

        private void BtnCacelForPwd_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextBoxPdw1.Text = TextBoxPdw2.Text = TextBoxForPwdAns.Text = CmoBoxForQue.Text = TextBoxUserNam.Text = string.Empty;
        }

        private void FindPassword_Load(object sender, EventArgs e)
        {
            TextBoxPdw1.Text = TextBoxPdw2.Text = TextBoxForPwdAns.Text = CmoBoxForQue.Text = TextBoxUserNam.Text = string.Empty;
        }
        public void SetText(string text)
        {
            TextBoxUserNam.Text = text;
            TextBoxUserNam.Enabled = false;
        }
    }
}
