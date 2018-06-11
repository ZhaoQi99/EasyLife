using EasyLife.Spider;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new LoginForm());
            /*
            Spider.SpiderTicket s = new Spider.SpiderTicket("2018-06-03","GGQ","OTQ","ADULT");
            s.getTicket();
            Ticket t= s.index(0);
            Console.Write(t.ArriveTime);
            */
            SchoolId s = new SchoolId("http://edutech.snnu.edu.cn/ecard/ccc.asp");
            Console.WriteLine(s.Search("201608735"));
        }
    }
}
