﻿using CCWin;
using CCWin.SkinControl;
using EasyLife.BLL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace EasyLife
{
    public partial class MainForm : CCSkinMain
    {
        #region 变量
        ToolStripMenuItem SelectItem;//当前选择的皮肤
        BLL.Ticket ticket = new BLL.Ticket();
        BLL.Notice notice = new BLL.Notice();
        BLL.PhoneBook phonebook = new BLL.PhoneBook();
        BLL.User user = new BLL.User();
        bool[] Exist = new bool[10];
        Clock clock = new Clock(180);
        Model.User u;
        int selectindex = 0;
        #endregion

        public MainForm(Model.User u)
        {
            InitializeComponent();
            SelectItem = SkinTool0;
            this.u = u;
        }

        #region 窗体加载
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(63, 176, 215);
            LoadingIndex.Show();
            TimerLoad.Enabled = true;
            TimerLoad.Interval = 4000;
            TimerClock.Enabled = true;
            TimerClock.Interval = 1000;
            LblVersion.Text = LblVersion.Text + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            CmoBoxPrior.SelectedIndex = 1;
            FindPwd.Left = (this.Width - FindPwd.Width) / 2;//还原位置
            FindPwd.Visible = false;
            Tool.StationNameXml();

            LblShowEmail.Text = "邮箱:" + u.Email;
            LblShowTel.Text = "电话:" + u.Tel;
            LblUserNameShow.Text = "用户名:" + u.UserName;
            LblShowDep.Text = "所在单位:" + u.School;

            LoadingEmail.Hide();
            LoadingNews.Hide();
            LoadingTicket.Hide();

        }
        #endregion

        #region 窗体关闭
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 更换皮肤
        private void SkinTool_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = true;
            SelectItem.Checked = false;
            SelectItem = item;
            if (item.Tag.ToString().Equals("0"))//默认皮肤
            {
                this.Back = null;
                this.BackColor = Color.FromArgb(63, 176, 215);
                this.Opacity = this.SkinOpacity = 0.9;
            }
            else
            {
                //其他皮肤，从程序集资源中提取，并且设置透明度为不透明
                this.Opacity = this.SkinOpacity = 1;
                this.BackgroundImage = Tool.GetResBitmap(string.Format("EasyLife.Skin.{0}.jpg", item.Tag));
            }
        }
        #endregion

        #region 自定义系统按钮的点击事件
        private void MainForm_SysBottomClick(object sender, SysButtonEventArgs e)
        {
            Point loc = PointToScreen(e.SysButton.Location);//获得弹出坐标
            loc.Y += e.SysButton.Size.Height + 1;
            if (e.SysButton.Name == "Skin")//皮肤菜单
            {
                SkinMenu.Show(loc);
            }
            else if (e.SysButton.Name == "Settings")//设置菜单
            {
                SettingsMenu.Show(loc);
            }
        }
        #endregion

        #region 设置菜单相关事件
        //更新个人信息
        private void InformationUpdate_Click(object sender, EventArgs e)
        {
            FindPwd.Show();
            FindPwd.SetText(u.UserName);

        }
        //退出
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //窗口置顶
        private void TopMost_Click(object sender, EventArgs e)
        {
            if (TopMost.Checked == true)
            {
                this.TopLevel = false;
                TopMost.Checked = false;
            }
            else
            {
                this.TopLevel = true;
                TopMost.Checked = true;
            }
        }
        //帮助
        private void HelpWord_Click(object sender, EventArgs e)
        {
            string now= Environment.CurrentDirectory;
            if (File.Exists(now + "/EasyLife V0.1.0.chm") == false)
                MessageBoxEx.Show("帮助文档不存在!", "错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                Process.Start(now+ "/EasyLife V0.1.0.chm");
        }
        //访问EasyLife
        private void Link_Click(object sender, EventArgs e)
        {
            Process.Start("http://zhaoqi99.github.io/EasyLife/V0.1.0");
        }
        //关于
        private void About_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
        //选择语言
        private void 简体中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (简体中文ToolStripMenuItem.Checked == true)
                return;
            简体中文ToolStripMenuItem.Checked = true;
            英文ToolStripMenuItem.Checked = false;
            Language.SetDefaultLanguage("zh-Hans");
            Language.LoadLanguage(this, typeof(MainForm));
            LblVersion.Text = "当前版本:v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            LblShowEmail.Text = "邮箱:" + u.Email;
            LblShowTel.Text = "电话:" + u.Tel;
            LblUserNameShow.Text = "用户名:" + u.UserName;
            LblShowDep.Text = "所在单位:" + u.School;

            SkinTool0.Text = "默认";
            SkinTool1.Text = "炫彩紫色";
            SkinTool1.Text = "悠然百合";
            SkinTool1.Text = "绿色环保";
            SkinTool1.Text = "恭迎新春";

            InformationUpdate.Text = "修改个人信息";
            TopMost.Text = "窗口置顶";
            About.Text = "关于";
            Link.Text = "访问EasyLife";
            Exit.Text = "退出";
            LanguageSettings.Text = "语言";
            HelpWord.Text = "帮助";
            ShowWeather("西安");
        }
        private void 英文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (英文ToolStripMenuItem.Checked == true)
                return;
            英文ToolStripMenuItem.Checked = true;
            简体中文ToolStripMenuItem.Checked = false;
            Language.SetDefaultLanguage("en");
            Language.LoadLanguage(this, typeof(MainForm));
            LblVersion.Text = "Version:v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            LblShowEmail.Text = "Email:" + u.Email;
            LblShowTel.Text = "Tel:" + u.Tel;
            LblUserNameShow.Text = "UserName:" + u.UserName;
            LblShowDep.Text = "Department:" + u.School;

            SkinTool0.Text = "Defaul";
            SkinTool1.Text = "Purple";
            SkinTool1.Text = "Lily";
            SkinTool1.Text = "Green";
            SkinTool1.Text = "Red";

            InformationUpdate.Text = "Update information";
            TopMost.Text = "TopMost";
            About.Text = "About";
            Link.Text = "Link EasyLife";
            Exit.Text = "Exit";
            LanguageSettings.Text = "Language";
            HelpWord.Text = "Help";
            ShowWeather("西安");
        }
        #endregion

        #region 选项卡切换事件
        private void TabShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabShow.SelectedIndex == 6)
                Application.Exit();
            if (TabShow.SelectedIndex == 1)
            {
                if (Exist[1] == false)//动态加载下拉选项
                {
                    try
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(Environment.CurrentDirectory + "/Data/StationName.xml");
                        XmlNodeList data = doc.DocumentElement.ChildNodes;
                        foreach (XmlNode node in data)
                        {
                            XmlElement xe = (XmlElement)node;
                            XmlNodeList xnl0 = xe.ChildNodes;
                            string s = xnl0.Item(0).InnerText;
                            CmoBoxFromSta.Items.Add(s);
                            CmoBoxToSta.Items.Add(s);
                        }
                    }
                    catch (Exception ee)
                    {
                        Log.Write(ee.Message, "Exception");
                        MessageBox.Show(ee.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Exist[1] = true;
                }
            }
            if (TabShow.SelectedIndex == 2)
            {
                if (Exist[2] == false)
                {
                    string[] AllDep = phonebook.QueryDep();
                    for (int i = 0; i < AllDep.Length; i++)
                    {
                        string s = AllDep[i];
                        CmoBoxTelDep.Items.Add(s);
                    }
                    Exist[2] = true;
                }
            }
            if (TabShow.SelectedIndex == 3)
            {
                if (Exist[3] == false)
                {
                    string[] AllDep = notice.QueryDep();
                    for (int i = 0; i < AllDep.Length; i++)
                    {
                        string s = AllDep[i];
                        CmoBoxNotDep.Items.Add(s);
                    }
                    Exist[3] = true;
                }
            }
            if (TabShow.SelectedIndex == 5)
            {
                if (u.UserName != "Admin")
                {
                    TabShow.SelectedIndex = selectindex;
                    MessageBox.Show("无权访问!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            selectindex = TabShow.SelectedIndex;
        }
        #endregion

        #region 查票Page
        private void BtnTicUpdate_Click(object sender, EventArgs e)
        {
            if (CmoBoxFromSta.SelectedItem == null || CmoBoxFromSta.SelectedItem.ToString() == string.Empty)
            {
                MessageBoxEx.Show("出发站不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxToSta.SelectedItem == null || CmoBoxToSta.SelectedItem.ToString() == string.Empty)
            {
                MessageBoxEx.Show("到达站不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime SelectDate = DateTime.ParseExact(DateTimeTic.Text, "yyyy-M-d", System.Globalization.CultureInfo.InstalledUICulture);
            if ((DateTime.Compare(SelectDate, DateTime.Now) < 0) && (SelectDate.ToString("d") != DateTime.Now.ToString("d")))
            {
                MessageBoxEx.Show("出发日期不能小于当前系统日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadingTicket.Show();
            string SelectRadText = RadBtnAdult.Checked == true ? RadBtnAdult.Text : RadBtnStuTic.Text;
            ticket.Delete(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            ticket.Update(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            DataGridViewTicket.DataSource = ticket.GetList(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText).Tables["Ticket"].DefaultView;
            LabelQueTime2.Text = ticket.QueryDate(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            LoadingTicket.Hide();
            MessageBoxEx.Show("更新完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        private void BtnTicQuery_Click(object sender, EventArgs e)
        {
            if (CmoBoxFromSta.SelectedItem == null || CmoBoxFromSta.SelectedItem.ToString() == string.Empty)
            {
                MessageBoxEx.Show("出发站不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxToSta.SelectedItem == null || CmoBoxToSta.SelectedItem.ToString() == string.Empty)
            {
                MessageBoxEx.Show("到达站不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime SelectDate = DateTime.ParseExact(DateTimeTic.Text, "yyyy-M-d", System.Globalization.CultureInfo.InstalledUICulture);
            if ((DateTime.Compare(SelectDate, DateTime.Now) < 0) && (SelectDate.ToString("d") != DateTime.Now.ToString("d")))
            {
                MessageBoxEx.Show("出发日期不能小于当前系统日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadingTicket.Show();
            string SelectRadText = RadBtnAdult.Checked == true ? RadBtnAdult.Text : RadBtnStuTic.Text;
            if (ticket.Exists(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText) == false)//尚未查询过
            {
                ticket.Update(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            }
            DataGridViewTicket.DataSource = ticket.GetList(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText).Tables["Ticket"].DefaultView;
            LabelQueTime2.Text = ticket.QueryDate(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            LoadingTicket.Hide();
            MessageBoxEx.Show("查询完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        #endregion

        #region 校园新闻Page
        private void BtnQueNotice_Click(object sender, EventArgs e)
        {
            if (DateTImePicNotice.Text != string.Empty && Regex.IsMatch(DateTImePicNotice.Text, @"\d{4}-\d{1,2}-\d{1,2}") == false)
            {
                MessageBoxEx.Show("日期格式错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Department = CmoBoxNotDep.Text.ToString();
            string Type = CmoBoxNotType.Text.ToString();
            string Date = DateTImePicNotice.Text;
            if(notice.Exist(Department,Type)==false)
            {
                notice.Update(Department, Type);
                MessageBoxEx.Show("更新完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            DataGridViewNotice.DataSource = notice.GetList(Department, Type, Date).Tables["Notice"].DefaultView;
            MessageBoxEx.Show("查询完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void BtnUpdNotice_Click(object sender, EventArgs e)
        {
            if (CmoBoxNotDep.Text == string.Empty)
            {
                MessageBoxEx.Show("所属部门不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxNotType.Text == string.Empty)
            {
                MessageBoxEx.Show("类型不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadingNews.Show();
            notice.Update(CmoBoxNotDep.Text.ToString(), CmoBoxNotType.Text.ToString());
            string Department = CmoBoxNotDep.Text.ToString();
            string Type = CmoBoxNotType.Text.ToString();
            string Date = DateTImePicNotice.Text;
            DataGridViewNotice.DataSource = notice.GetList(Department, Type, Date).Tables["Notice"].DefaultView;
            LoadingNews.Hide();
            MessageBoxEx.Show("更新完成！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
        private void DataGridViewNotice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                this.DataGridViewNotice.CurrentCell = this.DataGridViewNotice.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string Link = this.DataGridViewNotice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                System.Diagnostics.Process.Start(Link);
            }
        }
        #endregion

        #region 电话查询Page
        private void BtnTelQue_Click(object sender, EventArgs e)
        {
            this.DataGridViewTel.DataSource = phonebook.GetList(CmoBoxTelDep.Text, CmoBoxCam.Text, TextBoxTelSecDep.Text).Tables["Tel"].DefaultView;
        }

        private void BtnTelAdd_Click(object sender, EventArgs e)
        {
            if (CmoBoxTelDep.Text == string.Empty)
            {
                MessageBoxEx.Show("所属单位不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxCam.Text == string.Empty)
            {
                MessageBoxEx.Show("所在校区不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextBoxTelSecDep.Text == string.Empty)
            {
                MessageBoxEx.Show("所属部门不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextBoxTelNum.Text == string.Empty)
            {
                MessageBoxEx.Show("电话号码不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            phonebook.Add(CmoBoxTelDep.Text, TextBoxTelNum.Text, TextBoxTelSecDep.Text, CmoBoxCam.Text);
            this.DataGridViewTel.DataSource = phonebook.GetList(CmoBoxTelDep.Text, CmoBoxCam.Text, TextBoxTelSecDep.Text).Tables["Tel"].DefaultView;

        }

        private void BtnTelDel_Click(object sender, EventArgs e)
        {
            this.DataGridViewTel.DataSource = phonebook.GetList(CmoBoxTelDep.Text, CmoBoxCam.Text, TextBoxTelSecDep.Text).Tables["Tel"].DefaultView;
            int n;
            n = phonebook.Delete(CmoBoxTelDep.Text, CmoBoxCam.Text, TextBoxTelSecDep.Text);
            MessageBoxEx.Show("成功删除" + n + "条数据!", "完成", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        #endregion

        #region 主页
        private void ShowWeather(string City)
        {
            try
            {
                string[] r = Weather.Get(City);
                LblLoc.Text = "地理位置" + r[0] + " " + r[1];
                LblWeaSim.Text = "今日天气概况:" + r[5] + " " + r[6];
                LblWind.Text = "风向:" + r[7];
                LblNextDay.Text = "明天天气概况" + r[12] + " " + r[13];
                LblWeaComp.Text = r[10];
                LblLife.Text = r[11];
                LblCity.Text = r[22];
                LblThreeDay.Text = "后天天气概况" + r[17] + " " + r[18];

                pictureBox1.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[8][0]));
                pictureBox2.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[9][0]));
                pictureBox3.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[15][0]));
                pictureBox4.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[16][0]));
                pictureBox5.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[20][0]));
                pictureBox6.Image = Tool.GetResBitmap(string.Format("EasyLife.Weather.a_{0}.jpg", r[21][0]));

                pictureBox1.Left = LblWeaSim.Left + LblWeaSim.Width + 5;
                pictureBox1.Top = pictureBox2.Top = LblWeaSim.Top - 8;
                pictureBox2.Left = pictureBox1.Left + pictureBox1.Width + 5;

                pictureBox3.Left = LblNextDay.Left + LblNextDay.Width + 5;
                pictureBox3.Top = pictureBox4.Top = LblNextDay.Top - 8;
                pictureBox4.Left = pictureBox3.Left + pictureBox3.Width + 5;

                pictureBox5.Left = LblThreeDay.Left + LblThreeDay.Width + 5;
                pictureBox5.Top = pictureBox6.Top = LblThreeDay.Top - 8;
                pictureBox6.Left = pictureBox5.Left + pictureBox5.Width + 5;
                LoadingIndex.Hide();
            }
            catch (Exception e)
            {
                BLL.Log.Write( e.Message, "Exception");
                MessageBoxEx.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            if (Exist[0] == false)
            {
                ShowWeather("西安");
                TimerLoad.Enabled = false;
                LoadingIndex.Hide();
                Exist[0] = true;
            }
        }

        #endregion

        #region 邮件
        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            if (CmoBoxMailHost.Text == string.Empty)
            {
                MessageBoxEx.Show("主机地址不能为空!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxPrior.Text == string.Empty)
            {
                MessageBoxEx.Show("优先级不能为空!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextBoxMailFrom.Text == string.Empty)
            {
                MessageBoxEx.Show("发件人不能为空!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextBoxPwd.Text == string.Empty)
            {
                MessageBoxEx.Show("密码不能为空!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TextBoxMailTo.Text == string.Empty)
            {
                MessageBoxEx.Show("收件人不能为空!", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadingEmail.Show();
            Send.SendMail send = new Send.SendMail(TextBoxMailFrom.Text, TextBoxPwd.Text, TextBoxMailFromName.Text, CmoBoxMailHost.Text, Convert.ToInt32(NumUpDownPort.Value));
            int n = send.send(TextBoxMailTo.Text, EmailSubject.Text, RichTextBoxBodey.Text, CmoBoxPrior.Text);
            if (n != 0)
                MessageBoxEx.Show("成功发送" + n + "封邮件", "完成", MessageBoxButtons.OK, MessageBoxIcon.None);
            LoadingEmail.Hide();
        }


        #endregion

        #region 用户管理
        private void BtnUserDel_Click(object sender, EventArgs e)
        {
            user.Delete(TextBoxUsername.Text);
            MessageBoxEx.Show("删除成功!", "完成", MessageBoxButtons.OK, MessageBoxIcon.None);
            DataGridViewUser.DataSource = user.GetList("").Tables["User"].DefaultView;
        }

        private void BtnUserQue_Click(object sender, EventArgs e)
        {
            DataGridViewUser.DataSource = user.GetList(TextBoxUsername.Text).Tables["User"].DefaultView;
        }
        #endregion

        #region 时钟
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            PicBoxClock.Image = clock.get();
            TImeNow2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion


    }
}
