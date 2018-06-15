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
            this.TextPwd = new CCWin.SkinControl.SkinTextBox();
            this.Btnlogin = new CCWin.SkinControl.SkinButton();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnRegister = new CCWin.SkinControl.SkinButton();
            this.BtnForgetPwd = new CCWin.SkinControl.SkinButton();
            this.SecCodeText = new CCWin.SkinControl.SkinTextBox();
            this.ForgetPassword = new EasyLife.Login.ForgetPassword();
            this.FindPwd = new EasyLife.Login.FindPassword();
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).BeginInit();
            this.TextId.SuspendLayout();
            this.SuspendLayout();
            // 
            // SecCodePic
            // 
            this.SecCodePic.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SecCodePic, "SecCodePic");
            this.SecCodePic.Name = "SecCodePic";
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
            resources.ApplyResources(this.TextId, "TextId");
            this.TextId.MaxLength = 32767;
            this.TextId.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextId.MouseBack")));
            this.TextId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextId.Multiline = true;
            this.TextId.Name = "TextId";
            this.TextId.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextId.NormlBack")));
            this.TextId.ReadOnly = false;
            this.TextId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.TextId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextId.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.TextId.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.TextId.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.TextId.SkinTxt.Multiline = ((bool)(resources.GetObject("resource.Multiline")));
            this.TextId.SkinTxt.Name = "BaseText";
            this.TextId.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.TextId.SkinTxt.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.TextId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextId.SkinTxt.WaterText = "用户名";
            this.TextId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextId.WaterText = "用户名";
            this.TextId.WordWrap = true;
            // 
            // BtnId
            // 
            this.BtnId.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.BtnId, "BtnId");
            this.BtnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnId.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnId.DownBack")));
            this.BtnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnId.IsEnabledDraw = false;
            this.BtnId.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnId.MouseBack")));
            this.BtnId.Name = "BtnId";
            this.BtnId.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnId.NormlBack")));
            this.BtnId.UseVisualStyleBackColor = false;
            // 
            // TextPwd
            // 
            this.TextPwd.BackColor = System.Drawing.Color.Transparent;
            this.TextPwd.DownBack = null;
            this.TextPwd.Icon = null;
            this.TextPwd.IconIsButton = true;
            this.TextPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextPwd.IsPasswordChat = '●';
            this.TextPwd.IsSystemPasswordChar = false;
            this.TextPwd.Lines = new string[0];
            resources.ApplyResources(this.TextPwd, "TextPwd");
            this.TextPwd.MaxLength = 32767;
            this.TextPwd.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextPwd.MouseBack")));
            this.TextPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextPwd.Multiline = true;
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextPwd.NormlBack")));
            this.TextPwd.ReadOnly = false;
            this.TextPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.TextPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPwd.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.TextPwd.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.TextPwd.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.TextPwd.SkinTxt.Multiline = ((bool)(resources.GetObject("resource.Multiline1")));
            this.TextPwd.SkinTxt.Name = "BaseText";
            this.TextPwd.SkinTxt.PasswordChar = ((char)(resources.GetObject("resource.PasswordChar")));
            this.TextPwd.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.TextPwd.SkinTxt.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.TextPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextPwd.SkinTxt.WaterText = "密码";
            this.TextPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextPwd.WaterText = "密码";
            this.TextPwd.WordWrap = true;
            // 
            // Btnlogin
            // 
            resources.ApplyResources(this.Btnlogin, "Btnlogin");
            this.Btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.Btnlogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btnlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btnlogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btnlogin.DownBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.DownBack")));
            this.Btnlogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btnlogin.ForeColor = System.Drawing.Color.White;
            this.Btnlogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.MouseBack")));
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btnlogin.NormlBack")));
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
            resources.ApplyResources(this.BtnRegister, "BtnRegister");
            this.BtnRegister.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnRegister.MouseBack")));
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnRegister.NormlBack")));
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
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
            resources.ApplyResources(this.BtnForgetPwd, "BtnForgetPwd");
            this.BtnForgetPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.MouseBack")));
            this.BtnForgetPwd.Name = "BtnForgetPwd";
            this.BtnForgetPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.NormlBack")));
            this.BtnForgetPwd.UseVisualStyleBackColor = false;
            this.BtnForgetPwd.Click += new System.EventHandler(this.BtnForgetPwd_Click);
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
            resources.ApplyResources(this.SecCodeText, "SecCodeText");
            this.SecCodeText.MaxLength = 32767;
            this.SecCodeText.MouseBack = null;
            this.SecCodeText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.SecCodeText.Multiline = true;
            this.SecCodeText.Name = "SecCodeText";
            this.SecCodeText.NormlBack = null;
            this.SecCodeText.ReadOnly = false;
            this.SecCodeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // 
            // 
            this.SecCodeText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecCodeText.SkinTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.SecCodeText.SkinTxt.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.SecCodeText.SkinTxt.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.SecCodeText.SkinTxt.Multiline = ((bool)(resources.GetObject("resource.Multiline2")));
            this.SecCodeText.SkinTxt.Name = "BaseText";
            this.SecCodeText.SkinTxt.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.SecCodeText.SkinTxt.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.SecCodeText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SecCodeText.SkinTxt.WaterText = " 验证码";
            this.SecCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecCodeText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SecCodeText.WaterText = " 验证码";
            this.SecCodeText.WordWrap = true;
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.ForgetPassword, "ForgetPassword");
            this.ForgetPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForgetPassword.Diglog = System.Windows.Forms.DialogResult.None;
            this.ForgetPassword.Name = "ForgetPassword";
            // 
            // FindPwd
            // 
            this.FindPwd.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            resources.ApplyResources(this.FindPwd, "FindPwd");
            this.FindPwd.Name = "FindPwd";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Btnlogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.CloseBoxSize = new System.Drawing.Size(30, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.FindPwd);
            this.Controls.Add(this.ForgetPassword);
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
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(30, 30);
            this.MobileApi = false;
            this.Name = "LoginForm";
            this.ShowDrawIcon = false;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).EndInit();
            this.TextId.ResumeLayout(false);
            this.TextId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox SecCodePic;
        private CCWin.SkinControl.SkinTextBox TextId;
        private CCWin.SkinControl.SkinButton BtnId;
        private CCWin.SkinControl.SkinTextBox TextPwd;
        private CCWin.SkinControl.SkinButton Btnlogin;
        private new System.Windows.Forms.ToolTip ToolTip;
        private CCWin.SkinControl.SkinButton BtnRegister;
        private CCWin.SkinControl.SkinButton BtnForgetPwd;
        private CCWin.SkinControl.SkinTextBox SecCodeText;
        private Login.ForgetPassword ForgetPassword;
        private Login.FindPassword FindPwd;
    }
}