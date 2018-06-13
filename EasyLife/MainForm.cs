using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EasyLife
{
    public partial class MainForm : CCSkinMain
    {
        #region 变量
        ToolStripMenuItem SelectItem;//当前选择的皮肤
        BLL.Ticket ticket = new BLL.Ticket();
        BLL.Notice notice = new BLL.Notice();
        bool[] Exist = new bool[10];
        #endregion

        public MainForm()
        {
            InitializeComponent();
            SelectItem = SkinTool0;
        }

        #region 窗体加载
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(63, 176, 215);
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
        private void MainForm_SysBottomClick(object sender, CCWin.SkinControl.SysButtonEventArgs e)
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
        //访问EasyLife
        private void Link_Click(object sender, EventArgs e)
        {

        }
        //关于
        private void About_Click(object sender, EventArgs e)
        {

        }
        //选择语言
        private void Language_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 选项卡切换事件
        private void TabShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabShow.SelectedIndex == 6)
                Application.Exit();
            if(TabShow.SelectedIndex==1)
            {
                if(Exist[1]==false)//动态加载下拉选项
                {
                    try
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(Environment.CurrentDirectory + "/Data/StationName.xml");
                        XmlNodeList data = doc.DocumentElement.ChildNodes;
                        foreach(XmlNode node in data)
                        {
                            XmlElement xe = (XmlElement)node;
                            XmlNodeList xnl0 = xe.ChildNodes;
                            string s = xnl0.Item(0).InnerText;
                            CmoBoxFromSta.Items.Add(s);
                            CmoBoxToSta.Items.Add(s);
                        }
                    }
                    catch(Exception)
                    {

                    }
                    Exist[1] = true;
                }
            }
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
            string SelectRadText = RadBtnAdult.Checked == true ? RadBtnAdult.Text : RadBtnStuTic.Text;
            ticket.Delete(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            ticket.Update(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            DataGridViewTicket.DataSource = ticket.GetList(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText).Tables["Ticket"].DefaultView;
            LabelQueTime2.Text = ticket.QueryDate(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
        }
        private void BtnTicQuery_Click(object sender, EventArgs e)
        {
            if (CmoBoxFromSta.SelectedItem == null||CmoBoxFromSta.SelectedItem.ToString()==string.Empty)
            {
                MessageBoxEx.Show("出发站不能为空!", "错误",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxToSta.SelectedItem == null || CmoBoxToSta.SelectedItem.ToString() == string.Empty)
            {
                MessageBoxEx.Show("到达站不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime SelectDate = DateTime.ParseExact(DateTimeTic.Text, "yyyy-M-d", System.Globalization.CultureInfo.InstalledUICulture);
            if( (DateTime.Compare(SelectDate,DateTime.Now)<0)&&(SelectDate.ToString("d")!=DateTime.Now.ToString("d")))
            {
                MessageBoxEx.Show("出发日期不能小于当前系统日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string SelectRadText = RadBtnAdult.Checked == true ? RadBtnAdult.Text : RadBtnStuTic.Text;
            if (ticket.Exists(CmoBoxFromSta.Text,CmoBoxToSta.Text,SelectDate, SelectRadText) ==false)//尚未查询过
            {
                ticket.Update(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
            }
            DataGridViewTicket.DataSource = ticket.GetList(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText).Tables["Ticket"].DefaultView;
            LabelQueTime2.Text = ticket.QueryDate(CmoBoxFromSta.Text, CmoBoxToSta.Text, SelectDate, SelectRadText);
        }
        #endregion

        #region 校园新闻Page
        private void BtnQueNotice_Click(object sender, EventArgs e)
        {
            if (CmoBoxDep.Text == string.Empty)
            {
                MessageBoxEx.Show("所属部门不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxType.Text == string.Empty)
            {
                MessageBoxEx.Show("类型不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTImePicNotice.Text!=string.Empty&&Regex.IsMatch(DateTImePicNotice.Text, @"\d{4}-\d{1,2}-\d{1,2}") == false)
            {
                MessageBoxEx.Show("日期格式错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Department = CmoBoxDep.Text.ToString();
            string Type = CmoBoxType.Text.ToString();
            string Date = DateTImePicNotice.Text;
            DataGridViewNotice.DataSource = notice.GetList(Department, Type, Date).Tables["Notice"].DefaultView;
        }
        private void BtnUpdNotice_Click(object sender, EventArgs e)
        {
            if(CmoBoxDep.Text==string.Empty)
            {
                MessageBoxEx.Show("所属部门不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmoBoxType.Text==string.Empty)
            {
                MessageBoxEx.Show("类型不能为空!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            notice.Update(CmoBoxDep.Text.ToString(), CmoBoxType.Text.ToString());
            string Department = CmoBoxDep.Text.ToString();
            string Type = CmoBoxType.Text.ToString();
            string Date = DateTImePicNotice.Text;
            DataGridViewNotice.DataSource = notice.GetList(Department, Type, Date).Tables["Notice"].DefaultView;
        }
        private void DataGridViewNotice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                this.DataGridViewNotice.CurrentCell = this.DataGridViewNotice.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string Link = this.DataGridViewNotice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                System.Diagnostics.Process.Start(Link);
            }
        }
        private void CmoBoxType_SelectedValueChanged(object sender, EventArgs e)
        {
            CmoBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmoBoxDep_SelectedValueChanged(object sender, EventArgs e)
        {
            CmoBoxDep.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

    }
}
