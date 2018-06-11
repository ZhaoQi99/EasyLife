namespace EasyLife.Login
{
    partial class ForgetPassword
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.BtnCacel = new CCWin.SkinControl.SkinButton();
            this.BtnForgetPwd = new CCWin.SkinControl.SkinButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCacel
            // 
            this.BtnCacel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCacel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnCacel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnCacel.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnCacel.DownBack")));
            this.BtnCacel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnCacel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCacel.Location = new System.Drawing.Point(353, 188);
            this.BtnCacel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCacel.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnCacel.MouseBack")));
            this.BtnCacel.Name = "BtnCacel";
            this.BtnCacel.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnCacel.NormlBack")));
            this.BtnCacel.Palace = true;
            this.BtnCacel.Size = new System.Drawing.Size(111, 31);
            this.BtnCacel.TabIndex = 26;
            this.BtnCacel.Text = "取消";
            this.BtnCacel.UseVisualStyleBackColor = false;
            this.BtnCacel.Click += new System.EventHandler(this.BtnCacel_Click);
            // 
            // BtnForgetPwd
            // 
            this.BtnForgetPwd.BackColor = System.Drawing.Color.Transparent;
            this.BtnForgetPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnForgetPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnForgetPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.DownBack")));
            this.BtnForgetPwd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnForgetPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnForgetPwd.Location = new System.Drawing.Point(239, 188);
            this.BtnForgetPwd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnForgetPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.MouseBack")));
            this.BtnForgetPwd.Name = "BtnForgetPwd";
            this.BtnForgetPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnForgetPwd.NormlBack")));
            this.BtnForgetPwd.Palace = true;
            this.BtnForgetPwd.Size = new System.Drawing.Size(111, 31);
            this.BtnForgetPwd.TabIndex = 27;
            this.BtnForgetPwd.Text = "找回密码";
            this.BtnForgetPwd.UseVisualStyleBackColor = false;
            this.BtnForgetPwd.Click += new System.EventHandler(this.BtnForgetPwd_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(105, 93);
            this.skinLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(387, 20);
            this.skinLabel7.TabIndex = 28;
            this.skinLabel7.Text = "您输入的密码不正确，您要找回密码吗？";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 66);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.BtnCacel);
            this.Controls.Add(this.BtnForgetPwd);
            this.Name = "ForgetPassword";
            this.Size = new System.Drawing.Size(477, 238);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton BtnCacel;
        private CCWin.SkinControl.SkinButton BtnForgetPwd;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
