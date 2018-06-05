using System.Drawing;

namespace EasyLife
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.SecCodePic = new CCWin.SkinControl.SkinPictureBox();
            this.TextId = new CCWin.SkinControl.SkinTextBox();
            this.BtnId = new CCWin.SkinControl.SkinButton();
            this.BtnJpPwd = new CCWin.SkinControl.SkinButton();
            this.TextPwd = new CCWin.SkinControl.SkinTextBox();
            this.Btnlogin = new CCWin.SkinControl.SkinButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnRegister = new CCWin.SkinControl.SkinButton();
            this.BtnForgetPwd = new CCWin.SkinControl.SkinButton();
            this.SecCodeText = new CCWin.SkinControl.SkinTextBox();
            this.ForgetPassword = new EasyLife.Login.ForgetPassword();
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).BeginInit();
            this.TextId.SuspendLayout();
            this.TextPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecCodePic
            // 
            this.SecCodePic.BackColor = System.Drawing.Color.Transparent;
            this.SecCodePic.Location = new System.Drawing.Point(237, 201);
            this.SecCodePic.Name = "SecCodePic";
            this.SecCodePic.Size = new System.Drawing.Size(178, 44);
            this.SecCodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecCodePic.TabIndex = 1;
            this.SecCodePic.TabStop = false;
            this.SecCodePic.Click += new System.EventHandler(this.SecCodePic_Click);
            // 
            // TextId
            // 
            this.TextId.BackColor = System.Drawing.Color.Transparent;
            this.TextId.Controls.Add(this.BtnId);
            this.TextId.DownBack = null;
            this.TextId.Icon = null;
            this.TextId.IconIsButton = false;
            this.TextId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextId.IsPasswordChat = '\0';
            this.TextId.IsSystemPasswordChar = false;
            this.TextId.Lines = new string[0];
            this.TextId.Location = new System.Drawing.Point(161, 124);
            this.TextId.Margin = new System.Windows.Forms.Padding(0);
            this.TextId.MaxLength = 32767;
            this.TextId.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextId.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextId.MouseBack")));
            this.TextId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextId.Multiline = true;
            this.TextId.Name = "TextId";
            this.TextId.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextId.NormlBack")));
            this.TextId.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.TextId.ReadOnly = false;
            this.TextId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextId.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TextId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextId.SkinTxt.Multiline = true;
            this.TextId.SkinTxt.Name = "BaseText";
            this.TextId.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.TextId.SkinTxt.TabIndex = 0;
            this.TextId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextId.SkinTxt.WaterText = "用户名/邮箱";
            this.TextId.TabIndex = 2;
            this.TextId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextId.WaterText = "用户名/邮箱";
            this.TextId.WordWrap = true;
            // 
            // BtnId
            // 
            this.BtnId.BackColor = System.Drawing.Color.White;
            this.BtnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnId.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnId.DownBack")));
            this.BtnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnId.IsEnabledDraw = false;
            this.BtnId.Location = new System.Drawing.Point(170, 3);
            this.BtnId.Margin = new System.Windows.Forms.Padding(0);
            this.BtnId.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnId.MouseBack")));
            this.BtnId.Name = "BtnId";
            this.BtnId.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnId.NormlBack")));
            this.BtnId.Size = new System.Drawing.Size(22, 24);
            this.BtnId.TabIndex = 36;
            this.BtnId.UseVisualStyleBackColor = false;
            // 
            // BtnJpPwd
            // 
            this.BtnJpPwd.BackColor = System.Drawing.Color.White;
            this.BtnJpPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnJpPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnJpPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnJpPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJpPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnJpPwd.DownBack")));
            this.BtnJpPwd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnJpPwd.Location = new System.Drawing.Point(172, 6);
            this.BtnJpPwd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnJpPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnJpPwd.MouseBack")));
            this.BtnJpPwd.Name = "BtnJpPwd";
            this.BtnJpPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnJpPwd.NormlBack")));
            this.BtnJpPwd.Size = new System.Drawing.Size(15, 16);
            this.BtnJpPwd.TabIndex = 41;
            this.ToolTip.SetToolTip(this.BtnJpPwd, "打开软键盘");
            this.BtnJpPwd.UseVisualStyleBackColor = false;
            this.BtnJpPwd.Click += new System.EventHandler(this.BtnJpPwd_Click);
            // 
            // TextPwd
            // 
            this.TextPwd.BackColor = System.Drawing.Color.Transparent;
            this.TextPwd.Controls.Add(this.ForgetPassword);
            this.TextPwd.Controls.Add(this.BtnJpPwd);
            this.TextPwd.DownBack = null;
            this.TextPwd.Icon = null;
            this.TextPwd.IconIsButton = true;
            this.TextPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextPwd.IsPasswordChat = '●';
            this.TextPwd.IsSystemPasswordChar = false;
            this.TextPwd.Lines = new string[0];
            this.TextPwd.Location = new System.Drawing.Point(161, 155);
            this.TextPwd.Margin = new System.Windows.Forms.Padding(0);
            this.TextPwd.MaxLength = 32767;
            this.TextPwd.MinimumSize = new System.Drawing.Size(0, 28);
            this.TextPwd.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextPwd.MouseBack")));
            this.TextPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextPwd.Multiline = true;
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextPwd.NormlBack")));
            this.TextPwd.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.TextPwd.ReadOnly = false;
            this.TextPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextPwd.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TextPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextPwd.SkinTxt.Multiline = true;
            this.TextPwd.SkinTxt.Name = "BaseText";
            this.TextPwd.SkinTxt.PasswordChar = '●';
            this.TextPwd.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.TextPwd.SkinTxt.TabIndex = 0;
            this.TextPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextPwd.SkinTxt.WaterText = "密码";
            this.TextPwd.TabIndex = 3;
            this.TextPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextPwd.WaterText = "密码";
            this.TextPwd.WordWrap = true;
            // 
            // Btnlogin
            // 
            this.Btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.Btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btnlogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btnlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btnlogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btnlogin.DownBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.DownBack")));
            this.Btnlogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btnlogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Btnlogin.ForeColor = System.Drawing.Color.White;
            this.Btnlogin.Location = new System.Drawing.Point(161, 270);
            this.Btnlogin.Margin = new System.Windows.Forms.Padding(0);
            this.Btnlogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.MouseBack")));
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.NormlBack")));
            this.Btnlogin.Size = new System.Drawing.Size(194, 30);
            this.Btnlogin.TabIndex = 1;
            this.Btnlogin.Text = "登  录";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnRegister.Create = true;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnRegister.DownBack")));
            this.BtnRegister.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(367, 135);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegister.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnRegister.MouseBack")));
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnRegister.NormlBack")));
            this.BtnRegister.Size = new System.Drawing.Size(48, 11);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // BtnForgetPwd
            // 
            this.BtnForgetPwd.BackColor = System.Drawing.Color.Transparent;
            this.BtnForgetPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnForgetPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnForgetPwd.Create = true;
            this.BtnForgetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnForgetPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.DownBack")));
            this.BtnForgetPwd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnForgetPwd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnForgetPwd.Location = new System.Drawing.Point(367, 164);
            this.BtnForgetPwd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnForgetPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.MouseBack")));
            this.BtnForgetPwd.Name = "BtnForgetPwd";
            this.BtnForgetPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.NormlBack")));
            this.BtnForgetPwd.Size = new System.Drawing.Size(48, 11);
            this.BtnForgetPwd.TabIndex = 6;
            this.BtnForgetPwd.UseVisualStyleBackColor = false;
            // 
            // SecCodeText
            // 
            this.SecCodeText.BackColor = System.Drawing.Color.Transparent;
            this.SecCodeText.DownBack = null;
            this.SecCodeText.Icon = null;
            this.SecCodeText.IconIsButton = false;
            this.SecCodeText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.SecCodeText.IsPasswordChat = '\0';
            this.SecCodeText.IsSystemPasswordChar = false;
            this.SecCodeText.Lines = new string[0];
            this.SecCodeText.Location = new System.Drawing.Point(161, 208);
            this.SecCodeText.Margin = new System.Windows.Forms.Padding(0);
            this.SecCodeText.MaxLength = 32767;
            this.SecCodeText.MinimumSize = new System.Drawing.Size(28, 28);
            this.SecCodeText.MouseBack = null;
            this.SecCodeText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.SecCodeText.Multiline = true;
            this.SecCodeText.Name = "SecCodeText";
            this.SecCodeText.NormlBack = null;
            this.SecCodeText.Padding = new System.Windows.Forms.Padding(5);
            this.SecCodeText.ReadOnly = false;
            this.SecCodeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SecCodeText.Size = new System.Drawing.Size(73, 30);
            // 
            // 
            // 
            this.SecCodeText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecCodeText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecCodeText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.SecCodeText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.SecCodeText.SkinTxt.Multiline = true;
            this.SecCodeText.SkinTxt.Name = "BaseText";
            this.SecCodeText.SkinTxt.Size = new System.Drawing.Size(63, 20);
            this.SecCodeText.SkinTxt.TabIndex = 0;
            this.SecCodeText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SecCodeText.SkinTxt.WaterText = " 验证码";
            this.SecCodeText.TabIndex = 4;
            this.SecCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecCodeText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SecCodeText.WaterText = " 验证码";
            this.SecCodeText.WordWrap = true;
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.Location = new System.Drawing.Point(-69, -107);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(347, 263);
            this.ForgetPassword.TabIndex = 7;
            this.ForgetPassword.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(580, 385);
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.SecCodeText);
            this.Controls.Add(this.BtnForgetPwd);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.SecCodePic);
            this.EffectCaption = CCWin.TitleType.None;
            this.MaximizeBox = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MinimumSize = new System.Drawing.Size(430, 330);
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.MobileApi = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyLife";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).EndInit();
            this.TextId.ResumeLayout(false);
            this.TextId.PerformLayout();
            this.TextPwd.ResumeLayout(false);
            this.TextPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox SecCodePic;
        private CCWin.SkinControl.SkinTextBox TextId;
        private CCWin.SkinControl.SkinButton BtnId;
        private CCWin.SkinControl.SkinButton BtnJpPwd;
        private CCWin.SkinControl.SkinTextBox TextPwd;
        private CCWin.SkinControl.SkinButton Btnlogin;
        private new System.Windows.Forms.ToolTip ToolTip;
        private CCWin.SkinControl.SkinButton BtnRegister;
        private CCWin.SkinControl.SkinButton BtnForgetPwd;
        private CCWin.SkinControl.SkinTextBox SecCodeText;
        private Login.ForgetPassword ForgetPassword;
    }
}