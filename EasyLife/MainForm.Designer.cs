namespace EasyLife
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton2 = new CCWin.CmSysButton();
            this.Loading = new CCWin.SkinControl.SkinProgressIndicator();
            this.ToolShow = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.SkinMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.SkinTool0 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTool4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new CCWin.SkinToolTip(this.components);
            this.SettingsMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Link = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TabShow = new CCWin.SkinControl.SkinTabControl();
            this.News = new CCWin.SkinControl.SkinTabPage();
            this.Notice = new CCWin.SkinControl.SkinTabPage();
            this.Tel = new CCWin.SkinControl.SkinTabPage();
            this.InformationUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolShow.SuspendLayout();
            this.SkinMenu.SuspendLayout();
            this.SettingsMenu.SuspendLayout();
            this.TabShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.AutoStart = true;
            this.Loading.BackColor = System.Drawing.Color.White;
            this.Loading.Location = new System.Drawing.Point(316, 285);
            this.Loading.Name = "Loading";
            this.Loading.Percentage = 30F;
            this.Loading.ShowText = true;
            this.Loading.Size = new System.Drawing.Size(151, 151);
            this.Loading.TabIndex = 0;
            this.Loading.Text = "加载中....";
            this.Loading.TextDisplay = CCWin.SkinControl.TextDisplayModes.Text;
            // 
            // ToolShow
            // 
            this.ToolShow.Arrow = System.Drawing.Color.Black;
            this.ToolShow.AutoSize = false;
            this.ToolShow.Back = System.Drawing.Color.Transparent;
            this.ToolShow.BackColor = System.Drawing.Color.Transparent;
            this.ToolShow.BackRadius = 4;
            this.ToolShow.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.ToolShow.Base = System.Drawing.Color.Transparent;
            this.ToolShow.BaseFore = System.Drawing.Color.Black;
            this.ToolShow.BaseForeAnamorphosis = false;
            this.ToolShow.BaseForeAnamorphosisBorder = 4;
            this.ToolShow.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.ToolShow.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.ToolShow.BaseHoverFore = System.Drawing.Color.White;
            this.ToolShow.BaseItemAnamorphosis = true;
            this.ToolShow.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemBorderShow = true;
            this.ToolShow.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemDown")));
            this.ToolShow.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("ToolShow.BaseItemMouse")));
            this.ToolShow.BaseItemNorml = null;
            this.ToolShow.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BaseItemRadius = 4;
            this.ToolShow.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ToolShow.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.BindTabControl = null;
            this.ToolShow.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ToolShow.Fore = System.Drawing.Color.Black;
            this.ToolShow.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.ToolShow.HoverFore = System.Drawing.Color.White;
            this.ToolShow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolShow.ItemAnamorphosis = true;
            this.ToolShow.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemBorderShow = true;
            this.ToolShow.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ToolShow.ItemRadius = 4;
            this.ToolShow.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ToolShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.ToolShow.Location = new System.Drawing.Point(4, 28);
            this.ToolShow.Name = "ToolShow";
            this.ToolShow.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ToolShow.Size = new System.Drawing.Size(826, 67);
            this.ToolShow.SkinAllColor = true;
            this.ToolShow.TabIndex = 1;
            this.ToolShow.Text = "skinToolStrip1";
            this.ToolShow.TitleAnamorphosis = true;
            this.ToolShow.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ToolShow.TitleRadius = 4;
            this.ToolShow.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 64);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 64);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 64);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // SkinMenu
            // 
            this.SkinMenu.Arrow = System.Drawing.Color.Black;
            this.SkinMenu.Back = System.Drawing.Color.White;
            this.SkinMenu.BackRadius = 4;
            this.SkinMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.SkinMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SkinMenu.Fore = System.Drawing.Color.Black;
            this.SkinMenu.HoverFore = System.Drawing.Color.White;
            this.SkinMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SkinMenu.ItemAnamorphosis = true;
            this.SkinMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemBorderShow = true;
            this.SkinMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.ItemRadius = 4;
            this.SkinMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SkinMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkinTool0,
            this.SkinTool1,
            this.SkinTool2,
            this.SkinTool3,
            this.SkinTool4});
            this.SkinMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SkinMenu.Name = "SkinMenu";
            this.SkinMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SkinMenu.Size = new System.Drawing.Size(139, 134);
            this.SkinMenu.SkinAllColor = true;
            this.SkinMenu.TitleAnamorphosis = true;
            this.SkinMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.SkinMenu.TitleRadius = 4;
            this.SkinMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // SkinTool0
            // 
            this.SkinTool0.Checked = true;
            this.SkinTool0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkinTool0.Name = "SkinTool0";
            this.SkinTool0.Size = new System.Drawing.Size(138, 26);
            this.SkinTool0.Tag = "0";
            this.SkinTool0.Text = "默认皮肤";
            this.SkinTool0.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool1
            // 
            this.SkinTool1.Name = "SkinTool1";
            this.SkinTool1.Size = new System.Drawing.Size(138, 26);
            this.SkinTool1.Tag = "1";
            this.SkinTool1.Text = "炫彩紫色";
            this.SkinTool1.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool2
            // 
            this.SkinTool2.Name = "SkinTool2";
            this.SkinTool2.Size = new System.Drawing.Size(138, 26);
            this.SkinTool2.Tag = "2";
            this.SkinTool2.Text = "悠然百合";
            this.SkinTool2.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool3
            // 
            this.SkinTool3.Name = "SkinTool3";
            this.SkinTool3.Size = new System.Drawing.Size(138, 26);
            this.SkinTool3.Tag = "3";
            this.SkinTool3.Text = "绿色环保";
            this.SkinTool3.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // SkinTool4
            // 
            this.SkinTool4.Name = "SkinTool4";
            this.SkinTool4.Size = new System.Drawing.Size(138, 26);
            this.SkinTool4.Tag = "4";
            this.SkinTool4.Text = "恭贺新春";
            this.SkinTool4.Click += new System.EventHandler(this.SkinTool_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 800;
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.Arrow = System.Drawing.Color.Black;
            this.SettingsMenu.Back = System.Drawing.Color.White;
            this.SettingsMenu.BackRadius = 4;
            this.SettingsMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.SettingsMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SettingsMenu.Fore = System.Drawing.Color.Black;
            this.SettingsMenu.HoverFore = System.Drawing.Color.White;
            this.SettingsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SettingsMenu.ItemAnamorphosis = true;
            this.SettingsMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SettingsMenu.ItemBorderShow = true;
            this.SettingsMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SettingsMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SettingsMenu.ItemRadius = 4;
            this.SettingsMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationUpdate,
            this.Language,
            this.TopMost,
            this.toolStripSeparator1,
            this.Link,
            this.About,
            this.toolStripSeparator2,
            this.Exit});
            this.SettingsMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.SettingsMenu.Name = "Menu";
            this.SettingsMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.SettingsMenu.Size = new System.Drawing.Size(169, 160);
            this.SettingsMenu.SkinAllColor = true;
            this.SettingsMenu.TitleAnamorphosis = true;
            this.SettingsMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.SettingsMenu.TitleRadius = 4;
            this.SettingsMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // Language
            // 
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(168, 24);
            this.Language.Text = "语言设置";
            this.Language.Click += new System.EventHandler(this.Language_Click);
            // 
            // TopMost
            // 
            this.TopMost.Name = "TopMost";
            this.TopMost.Size = new System.Drawing.Size(168, 24);
            this.TopMost.Text = "窗口置顶";
            this.TopMost.Click += new System.EventHandler(this.TopMost_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // Link
            // 
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(168, 24);
            this.Link.Text = "访问EasyLife";
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(168, 24);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(168, 24);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前版本:V0.1.0";
            // 
            // TabShow
            // 
            this.TabShow.AnimationStart = true;
            this.TabShow.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.TabShow.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabShow.BackColor = System.Drawing.Color.White;
            this.TabShow.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.TabShow.Controls.Add(this.News);
            this.TabShow.Controls.Add(this.Notice);
            this.TabShow.Controls.Add(this.Tel);
            this.TabShow.HeadBack = null;
            this.TabShow.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.TabShow.ItemSize = new System.Drawing.Size(70, 36);
            this.TabShow.Location = new System.Drawing.Point(12, 99);
            this.TabShow.Name = "TabShow";
            this.TabShow.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("TabShow.PageArrowDown")));
            this.TabShow.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("TabShow.PageArrowHover")));
            this.TabShow.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("TabShow.PageCloseHover")));
            this.TabShow.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("TabShow.PageCloseNormal")));
            this.TabShow.PageDown = ((System.Drawing.Image)(resources.GetObject("TabShow.PageDown")));
            this.TabShow.PageHover = ((System.Drawing.Image)(resources.GetObject("TabShow.PageHover")));
            this.TabShow.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.TabShow.PageNorml = null;
            this.TabShow.SelectedIndex = 0;
            this.TabShow.Size = new System.Drawing.Size(815, 528);
            this.TabShow.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabShow.TabIndex = 4;
            // 
            // News
            // 
            this.News.BackColor = System.Drawing.Color.White;
            this.News.Dock = System.Windows.Forms.DockStyle.Fill;
            this.News.Location = new System.Drawing.Point(0, 36);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(815, 492);
            this.News.TabIndex = 0;
            this.News.TabItemImage = null;
            this.News.Text = "校园新闻";
            // 
            // Notice
            // 
            this.Notice.BackColor = System.Drawing.Color.White;
            this.Notice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notice.Location = new System.Drawing.Point(0, 36);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(815, 492);
            this.Notice.TabIndex = 1;
            this.Notice.TabItemImage = null;
            this.Notice.Text = "新闻公告";
            // 
            // Tel
            // 
            this.Tel.BackColor = System.Drawing.Color.White;
            this.Tel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tel.Location = new System.Drawing.Point(0, 36);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(815, 492);
            this.Tel.TabIndex = 2;
            this.Tel.TabItemImage = null;
            this.Tel.Text = "电话查询";
            // 
            // InformationUpdate
            // 
            this.InformationUpdate.Name = "InformationUpdate";
            this.InformationUpdate.Size = new System.Drawing.Size(168, 24);
            this.InformationUpdate.Text = "修改个人信息";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(176)))), ((int)(((byte)(215)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackLayout = false;
            this.BackShade = false;
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(834, 668);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.TabShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.ToolShow);
            this.EffectCaption = CCWin.TitleType.Title;
            this.MaximizeBox = false;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(732, 0, 32, 20);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(732, 0);
            cmSysButton1.Name = "Settings";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(32, 20);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "设置";
            cmSysButton2.Bounds = new System.Drawing.Rectangle(712, 0, 20, 20);
            cmSysButton2.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton2.Location = new System.Drawing.Point(712, 0);
            cmSysButton2.Name = "Skin";
            cmSysButton2.OwnerForm = this;
            cmSysButton2.Size = new System.Drawing.Size(20, 20);
            cmSysButton2.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonDown")));
            cmSysButton2.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonMouse")));
            cmSysButton2.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonNorml")));
            cmSysButton2.ToolTip = "皮肤";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1,
            cmSysButton2});
            this.Text = "EasyLife";
            this.SysBottomClick += new CCWin.CCSkinMain.SysBottomEventHandler(this.MainForm_SysBottomClick);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ToolShow.ResumeLayout(false);
            this.ToolShow.PerformLayout();
            this.SkinMenu.ResumeLayout(false);
            this.SettingsMenu.ResumeLayout(false);
            this.TabShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinProgressIndicator Loading;
        private CCWin.SkinControl.SkinToolStrip ToolShow;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private CCWin.SkinControl.SkinContextMenuStrip SkinMenu;
        private System.Windows.Forms.ToolStripMenuItem SkinTool0;
        private System.Windows.Forms.ToolStripMenuItem SkinTool1;
        private System.Windows.Forms.ToolStripMenuItem SkinTool2;
        private System.Windows.Forms.ToolStripMenuItem SkinTool3;
        private System.Windows.Forms.ToolStripMenuItem SkinTool4;
        private CCWin.SkinToolTip ToolTip;
        private CCWin.SkinControl.SkinContextMenuStrip SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem Language;
        private System.Windows.Forms.ToolStripMenuItem TopMost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Link;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinTabControl TabShow;
        private CCWin.SkinControl.SkinTabPage News;
        private CCWin.SkinControl.SkinTabPage Notice;
        private CCWin.SkinControl.SkinTabPage Tel;
        private System.Windows.Forms.ToolStripMenuItem InformationUpdate;
    }
}