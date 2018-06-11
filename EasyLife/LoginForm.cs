using CCWin;
using CCWin.SkinControl;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLife
{
    public partial class LoginForm : CCSkinMain
    {
        #region 变量
        SecurityCode securitycode;
        public EasyLife.BLL.User user = new EasyLife.BLL.User();
        #endregion
        public LoginForm()
        {
            InitializeComponent();
            securitycode = new SecurityCode(4);
        }
        #region 窗口加载
        private void Login_Load(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
            ForgetPassword.Left = (this.Width - ForgetPassword.Width) / 2;//还原位置
            ForgetPassword.Visible = false;
        }
        #endregion

        #region 验证码
        private void SecCodePic_Click(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
        }
        #endregion

        #region 小键盘按下事件
        private void BtnJpPwd_Click(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + TextPwd.Left - 25, this.Top + TextPwd.Bottom + 1, TextPwd.SkinTxt);
            pass.Show(this);
        }
        #endregion

        #region 登录检查
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (securitycode.Check(SecCodeText.Text) == false)//验证码错误
            {
                MessageBoxEx.Show("验证码错误，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                securitycode.UpdateVerifyCode();
                SecCodeText.Text = "";
                SecCodePic.Image = securitycode.getImage();
                return;
            }
            if (TextId.SkinTxt.Text.Length == 0 || TextPwd.SkinTxt.Text.Length == 0)//用户名或密码为空
            {
                MessageBoxEx.Show("用户名或密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (user.Exists(TextId.SkinTxt.Text.ToString()) == false)//用户不存在
            {
                MessageBoxEx.Show("用户不存在，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                securitycode.UpdateVerifyCode();
                SecCodeText.Text = "";
                TextId.Text = "";
                TextPwd.Text = "";
                SecCodePic.Image = securitycode.getImage();
                return;
            }
            if (user.Check(TextId.Text, TextPwd.Text) == true)//密码正确
            {
                new MainForm().Show();
                this.Hide();
                return;
            }
            else//密码错误
            {
                ForgetPassword.Visible = true;
                ForgetPassword.Show();
                TextId.SkinTxt.Text = "";
                TextPwd.SkinTxt.Text = "";
                SecCodeText.Text = "";
                securitycode.UpdateVerifyCode();
                SecCodePic.Image = securitycode.getImage();
            }
        }
        #endregion

        #region 注册
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            this.Visible = false;
            register.Show();
        }
        #endregion
    }
}
