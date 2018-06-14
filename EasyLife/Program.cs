using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using EasyLife.Spider;
using System.Web.Services;

namespace EasyLife
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            /*
            Spider.SpiderTicket s = new Spider.SpiderTicket("2018-06-03","GGQ","OTQ","ADULT");
            s.getTicket();
            Ticket t= s.index(0);
            Console.Write(t.ArriveTime);
            */
            //SchoolId s = new Spider.SchoolId();
            //Console.WriteLine(s.Search("201608735"));
            //Tool.StationNameXml();
            /*
            BLL.Ticket x = new BLL.Ticket();
            Model.Ticket xx = new Model.Ticket();
            x.Add(xx);
            */
            /*
            Spider.SpiderNotice s = new SpiderNotice("http://www.snnu.edu.cn/tzgg.htm", @"info/1085/(?<link>\d+.htm)"""" target=""""_blank"""">(?<title>\S{4,100})（(?<date>\d*-\d*-\d*)）", "666", "sss");
            string p= "info/1085/(?<link>\\d+.htm)\" target=\"_blank\">(?<title>\\S{4,100})（(?<date>\\d*-\\d*-\\d*)）";
            Regex r = new Regex(p, RegexOptions.ExplicitCapture);
            string ss = s.getHtml();
            MatchCollection mc = r.Matches(ss);
            foreach (Match m in mc)
            {
                GroupCollection group = m.Groups;
                Console.WriteLine(group[0].Value);
                Console.WriteLine(group[1].Value);
                Console.WriteLine(group[2].Value);

            }
            */
        }
    }
}
