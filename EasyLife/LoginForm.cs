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
            if (TextId.SkinTxt.Text.Length == 0 || TextPwd.SkinTxt.Text.Length == 0)
            {
                MessageBoxEx.Show("用户名或密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Default.GetBytes(SecCodeText.Text.ToString().ToUpper()));//不区分大小写
            string input = BitConverter.ToString(result);
            Console.WriteLine(input);
            Console.WriteLine(securitycode.MD5Encrypt());
            if (input.Equals(securitycode.MD5Encrypt())==true)//验证码校验通过
            {
                if(false)
                {

                }
                else
                {
                    MessageBoxEx.Show("用户名或密码错误，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TextId.SkinTxt.Text = "";
                    TextPwd.SkinTxt.Text = "";
                    SecCodeText.Text = "";
                    securitycode.UpdateVerifyCode();
                    SecCodePic.Image = securitycode.getImage();
                }
            }
            else
            {
                MessageBoxEx.Show("验证码错误，请重新输入！", "错误",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                securitycode.UpdateVerifyCode();
                SecCodeText.Text = "";
                SecCodePic.Image = securitycode.getImage();
                return;
            }
        }
        #endregion
        #region 登录跳转

        #endregion

        #region

        #endregion

    }
}
