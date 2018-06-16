namespace EasyLife
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.BtnRegister = new CCWin.SkinControl.SkinButton();
            this.SecCodePic = new CCWin.SkinControl.SkinPictureBox();
            this.SecCodeText = new CCWin.SkinControl.SkinTextBox();
            this.TextPwd = new CCWin.SkinControl.SkinTextBox();
            this.TextId = new CCWin.SkinControl.SkinTextBox();
            this.TextEmail = new CCWin.SkinControl.SkinTextBox();
            this.TextTel = new CCWin.SkinControl.SkinTextBox();
            this.CmoBoxSex = new CCWin.SkinControl.SkinComboBox();
            this.CmoBoxSchool = new CCWin.SkinControl.SkinComboBox();
            this.UserLicense = new System.Windows.Forms.LinkLabel();
            this.Agree = new CCWin.SkinControl.SkinCheckBox();
            this.CmoBoxForQue = new CCWin.SkinControl.SkinComboBox();
            this.CmoBoxForAns = new CCWin.SkinControl.SkinComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegister.BaseColor = System.Drawing.Color.LimeGreen;
            this.BtnRegister.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.DownBack = null;
            this.BtnRegister.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(250, 460);
            this.BtnRegister.MouseBack = null;
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.NormlBack = null;
            this.BtnRegister.Size = new System.Drawing.Size(112, 55);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "立即注册";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // SecCodePic
            // 
            this.SecCodePic.BackColor = System.Drawing.Color.Transparent;
            this.SecCodePic.Location = new System.Drawing.Point(304, 363);
            this.SecCodePic.Name = "SecCodePic";
            this.SecCodePic.Size = new System.Drawing.Size(146, 48);
            this.SecCodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecCodePic.TabIndex = 1;
            this.SecCodePic.TabStop = false;
            this.SecCodePic.Click += new System.EventHandler(this.SecCodePic_Click);
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
            this.SecCodeText.Location = new System.Drawing.Point(215, 375);
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
            this.SecCodeText.TabIndex = 9;
            this.SecCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecCodeText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SecCodeText.WaterText = " 验证码";
            this.SecCodeText.WordWrap = true;
            // 
            // TextPwd
            // 
            this.TextPwd.BackColor = System.Drawing.Color.Transparent;
            this.TextPwd.DownBack = null;
            this.TextPwd.Icon = null;
            this.TextPwd.IconIsButton = false;
            this.TextPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextPwd.IsPasswordChat = '●';
            this.TextPwd.IsSystemPasswordChar = false;
            this.TextPwd.Lines = new string[0];
            this.TextPwd.Location = new System.Drawing.Point(212, 67);
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
            this.TextPwd.TabIndex = 2;
            this.TextPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextPwd.WaterText = "密码";
            this.TextPwd.WordWrap = true;
            // 
            // TextId
            // 
            this.TextId.BackColor = System.Drawing.Color.Transparent;
            this.TextId.DownBack = null;
            this.TextId.Icon = null;
            this.TextId.IconIsButton = false;
            this.TextId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextId.IsPasswordChat = '\0';
            this.TextId.IsSystemPasswordChar = false;
            this.TextId.Lines = new string[0];
            this.TextId.Location = new System.Drawing.Point(212, 28);
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
            this.TextId.SkinTxt.WaterText = "用户名";
            this.TextId.TabIndex = 1;
            this.TextId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextId.WaterText = "用户名";
            this.TextId.WordWrap = true;
            // 
            // TextEmail
            // 
            this.TextEmail.BackColor = System.Drawing.Color.Transparent;
            this.TextEmail.DownBack = null;
            this.TextEmail.Icon = null;
            this.TextEmail.IconIsButton = false;
            this.TextEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextEmail.IsPasswordChat = '\0';
            this.TextEmail.IsSystemPasswordChar = false;
            this.TextEmail.Lines = new string[0];
            this.TextEmail.Location = new System.Drawing.Point(212, 149);
            this.TextEmail.Margin = new System.Windows.Forms.Padding(0);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextEmail.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextEmail.MouseBack")));
            this.TextEmail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextEmail.Multiline = true;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextEmail.NormlBack")));
            this.TextEmail.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.TextEmail.ReadOnly = false;
            this.TextEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextEmail.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TextEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEmail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextEmail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextEmail.SkinTxt.Multiline = true;
            this.TextEmail.SkinTxt.Name = "BaseText";
            this.TextEmail.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.TextEmail.SkinTxt.TabIndex = 0;
            this.TextEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextEmail.SkinTxt.WaterText = "邮箱";
            this.TextEmail.SkinTxt.WordWrap = false;
            this.TextEmail.TabIndex = 4;
            this.TextEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextEmail.WaterText = "邮箱";
            this.TextEmail.WordWrap = false;
            // 
            // TextTel
            // 
            this.TextTel.BackColor = System.Drawing.Color.Transparent;
            this.TextTel.DownBack = null;
            this.TextTel.Icon = null;
            this.TextTel.IconIsButton = false;
            this.TextTel.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextTel.IsPasswordChat = '\0';
            this.TextTel.IsSystemPasswordChar = false;
            this.TextTel.Lines = new string[0];
            this.TextTel.Location = new System.Drawing.Point(212, 107);
            this.TextTel.Margin = new System.Windows.Forms.Padding(0);
            this.TextTel.MaxLength = 32767;
            this.TextTel.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextTel.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("TextTel.MouseBack")));
            this.TextTel.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextTel.Multiline = true;
            this.TextTel.Name = "TextTel";
            this.TextTel.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("TextTel.NormlBack")));
            this.TextTel.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.TextTel.ReadOnly = false;
            this.TextTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextTel.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.TextTel.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTel.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTel.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextTel.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextTel.SkinTxt.Multiline = true;
            this.TextTel.SkinTxt.Name = "BaseText";
            this.TextTel.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.TextTel.SkinTxt.TabIndex = 0;
            this.TextTel.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextTel.SkinTxt.WaterText = "电话";
            this.TextTel.SkinTxt.WordWrap = false;
            this.TextTel.TabIndex = 3;
            this.TextTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextTel.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextTel.WaterText = "电话";
            this.TextTel.WordWrap = false;
            // 
            // CmoBoxSex
            // 
            this.CmoBoxSex.ArrowColor = System.Drawing.Color.Black;
            this.CmoBoxSex.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.CmoBoxSex.BorderColor = System.Drawing.Color.White;
            this.CmoBoxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmoBoxSex.DropDownHeight = 100;
            this.CmoBoxSex.DropDownWidth = 194;
            this.CmoBoxSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmoBoxSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmoBoxSex.IntegralHeight = false;
            this.CmoBoxSex.ItemBorderColor = System.Drawing.Color.DodgerBlue;
            this.CmoBoxSex.ItemHeight = 25;
            this.CmoBoxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.CmoBoxSex.Location = new System.Drawing.Point(212, 234);
            this.CmoBoxSex.Name = "CmoBoxSex";
            this.CmoBoxSex.Size = new System.Drawing.Size(194, 31);
            this.CmoBoxSex.TabIndex = 6;
            this.CmoBoxSex.WaterText = "性别";
            this.CmoBoxSex.SelectedIndexChanged += new System.EventHandler(this.CmoBoxSex_SelectedIndexChanged);
            // 
            // CmoBoxSchool
            // 
            this.CmoBoxSchool.ArrowColor = System.Drawing.Color.Black;
            this.CmoBoxSchool.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.CmoBoxSchool.BorderColor = System.Drawing.Color.White;
            this.CmoBoxSchool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmoBoxSchool.DropDownHeight = 100;
            this.CmoBoxSchool.DropDownWidth = 194;
            this.CmoBoxSchool.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmoBoxSchool.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmoBoxSchool.IntegralHeight = false;
            this.CmoBoxSchool.ItemBorderColor = System.Drawing.Color.DodgerBlue;
            this.CmoBoxSchool.ItemHeight = 25;
            this.CmoBoxSchool.Items.AddRange(new object[] {
            "计算机科学学院",
            "学生处",
            "教务处",
            "图书馆",
            "马克思主义学院",
            "文学院",
            "历史文化学院",
            "教育学院",
            "心理学院",
            "外国语学院",
            "数学与信息科学学院",
            "物理学与信息技术学院",
            "化学化工学院",
            "材料科学与工程学院",
            "生命科学学院",
            "地理科学与旅游学院",
            "\"新闻与传播学院",
            "体育学院",
            "音乐学院",
            "美术学院",
            "国际商学院",
            "食品工程与营养科学学院"});
            this.CmoBoxSchool.Location = new System.Drawing.Point(212, 191);
            this.CmoBoxSchool.Name = "CmoBoxSchool";
            this.CmoBoxSchool.Size = new System.Drawing.Size(194, 31);
            this.CmoBoxSchool.TabIndex = 5;
            this.CmoBoxSchool.WaterText = "学院";
            this.CmoBoxSchool.SelectedIndexChanged += new System.EventHandler(this.CmoBoxSchool_SelectedIndexChanged);
            // 
            // UserLicense
            // 
            this.UserLicense.AutoSize = true;
            this.UserLicense.BackColor = System.Drawing.Color.Transparent;
            this.UserLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLicense.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserLicense.LinkColor = System.Drawing.Color.GhostWhite;
            this.UserLicense.Location = new System.Drawing.Point(250, 419);
            this.UserLicense.Name = "UserLicense";
            this.UserLicense.Size = new System.Drawing.Size(135, 19);
            this.UserLicense.TabIndex = 13;
            this.UserLicense.TabStop = true;
            this.UserLicense.Text = "同意用户协议";
            this.UserLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserLicense_LinkClicked);
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.BackColor = System.Drawing.Color.Transparent;
            this.Agree.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Agree.DefaultCheckButtonWidth = 17;
            this.Agree.DownBack = null;
            this.Agree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Agree.Location = new System.Drawing.Point(218, 419);
            this.Agree.MouseBack = null;
            this.Agree.Name = "Agree";
            this.Agree.NormlBack = null;
            this.Agree.SelectedDownBack = null;
            this.Agree.SelectedMouseBack = null;
            this.Agree.SelectedNormlBack = null;
            this.Agree.Size = new System.Drawing.Size(18, 17);
            this.Agree.TabIndex = 10;
            this.Agree.UseVisualStyleBackColor = false;
            // 
            // CmoBoxForQue
            // 
            this.CmoBoxForQue.ArrowColor = System.Drawing.Color.Black;
            this.CmoBoxForQue.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.CmoBoxForQue.BorderColor = System.Drawing.Color.White;
            this.CmoBoxForQue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmoBoxForQue.DropDownHeight = 100;
            this.CmoBoxForQue.DropDownWidth = 194;
            this.CmoBoxForQue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmoBoxForQue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmoBoxForQue.IntegralHeight = false;
            this.CmoBoxForQue.ItemBorderColor = System.Drawing.Color.DodgerBlue;
            this.CmoBoxForQue.ItemHeight = 25;
            this.CmoBoxForQue.Items.AddRange(new object[] {
            "我的出生地是？",
            "我的学号是？",
            "我母亲的生日是？",
            "我父亲的生日是？",
            "我配偶的姓名是？",
            "我最熟悉的学校宿舍舍友是？"});
            this.CmoBoxForQue.Location = new System.Drawing.Point(212, 277);
            this.CmoBoxForQue.Name = "CmoBoxForQue";
            this.CmoBoxForQue.Size = new System.Drawing.Size(194, 31);
            this.CmoBoxForQue.TabIndex = 7;
            this.CmoBoxForQue.WaterText = "密保问题";
            this.CmoBoxForQue.SelectedIndexChanged += new System.EventHandler(this.CmoBoxForQue_SelectedIndexChanged);
            // 
            // CmoBoxForAns
            // 
            this.CmoBoxForAns.ArrowColor = System.Drawing.Color.Black;
            this.CmoBoxForAns.BaseColor = System.Drawing.Color.DeepSkyBlue;
            this.CmoBoxForAns.BorderColor = System.Drawing.Color.White;
            this.CmoBoxForAns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmoBoxForAns.DropDownHeight = 100;
            this.CmoBoxForAns.DropDownWidth = 194;
            this.CmoBoxForAns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmoBoxForAns.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmoBoxForAns.IntegralHeight = false;
            this.CmoBoxForAns.ItemBorderColor = System.Drawing.Color.DodgerBlue;
            this.CmoBoxForAns.ItemHeight = 25;
            this.CmoBoxForAns.Location = new System.Drawing.Point(212, 320);
            this.CmoBoxForAns.Name = "CmoBoxForAns";
            this.CmoBoxForAns.Size = new System.Drawing.Size(194, 31);
            this.CmoBoxForAns.TabIndex = 8;
            this.CmoBoxForAns.WaterText = "密保答案";
            this.CmoBoxForAns.SelectedIndexChanged += new System.EventHandler(this.CmoBoxForAns_SelectedIndexChanged);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.BtnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 536);
            this.CloseBoxSize = new System.Drawing.Size(32, 30);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.CmoBoxForAns);
            this.Controls.Add(this.CmoBoxForQue);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.UserLicense);
            this.Controls.Add(this.CmoBoxSchool);
            this.Controls.Add(this.TextTel);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.CmoBoxSex);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.SecCodeText);
            this.Controls.Add(this.SecCodePic);
            this.Controls.Add(this.BtnRegister);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecCodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton BtnRegister;
        private CCWin.SkinControl.SkinPictureBox SecCodePic;
        private CCWin.SkinControl.SkinTextBox SecCodeText;
        private CCWin.SkinControl.SkinTextBox TextPwd;
        private CCWin.SkinControl.SkinTextBox TextId;
        private CCWin.SkinControl.SkinTextBox TextEmail;
        private CCWin.SkinControl.SkinTextBox TextTel;
        private CCWin.SkinControl.SkinComboBox CmoBoxSex;
        private CCWin.SkinControl.SkinComboBox CmoBoxSchool;
        private System.Windows.Forms.LinkLabel UserLicense;
        private CCWin.SkinControl.SkinCheckBox Agree;
        private CCWin.SkinControl.SkinComboBox CmoBoxForQue;
        private CCWin.SkinControl.SkinComboBox CmoBoxForAns;
    }
}