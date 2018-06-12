using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    CmoBoxFromSta.Items.Add("666");
                    Exist[1] = true;
                }
            }
        }
        #endregion

        private void BtnTicUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnTicQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
