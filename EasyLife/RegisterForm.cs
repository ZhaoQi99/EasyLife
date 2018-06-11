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
    public partial class RegisterForm : CCSkinMain
    {
        #region 变量
        private LoginForm login;
        private SecurityCode securitycode;
        private BLL.User user;
        #endregion
        public RegisterForm(LoginForm login)
        {
            this.login = login;
            InitializeComponent();
            securitycode = new SecurityCode(4);
            user = new BLL.User();
        }
        #region 窗体关闭
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
            this.Dispose();
        }
        #endregion

        #region 窗体加载
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = login.DesktopLocation;
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
        }
        #endregion

        #region 注册事件
        private void BtnRegister_Click(object sender, EventArgs e)
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
            if (Agree.Checked==false)
            {
                MessageBoxEx.Show("请阅读用户协议!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (user.Exists(TextId.SkinTxt.Text.ToString()) == true)//用户已经存在
            {
                MessageBoxEx.Show("用户已存在，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                securitycode.UpdateVerifyCode();
                SecCodeText.Text = "";
                TextId.Text = "";
                TextPwd.Text = "";
                SecCodePic.Image = securitycode.getImage();
                return;
            }
            Model.User newuser = new Model.User()
            {
                UserName = TextId.Text,
                PassWord = TextId.Text,
                ForgetQue = CmoBoxForQue.Text,
                ForgetAns = CmoBoxForAns.Text,
                School=CmoBoxSchool.Text,
                Tel=TextTel.Text,
                Email=TextEmail.Text,
                Sex=CmoBoxSex.Text
         
            };
            user.Add(newuser);
            MessageBoxEx.Show("注册成功！","成功",MessageBoxButtons.OK,MessageBoxIcon.None);
            this.Close();
        }
        #endregion
        #region 更新验证码
        private void SecCodePic_Click(object sender, EventArgs e)
        {
            securitycode.UpdateVerifyCode();
            SecCodePic.Image = securitycode.getImage();
        }
        #endregion
        #region 解决bug
        //解决默认DropDownStyle属性为DropDownList时,窗体加载时不会显示WaitText的Bug
        private void CmoBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmoBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CmoBoxSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmoBoxSchool.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmoBoxForQue_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmoBoxForQue.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmoBoxForAns_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmoBoxForAns.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
    }
}
