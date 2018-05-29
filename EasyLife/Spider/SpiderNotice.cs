using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyLife.Spider;
using System.Collections;
using System.Text.RegularExpressions;

namespace EasyLife.Spider
{
    class SpiderNotice : Spider
    {
        private string url_main;//各个通知链接的公共部分
        private string subject;//发送邮件的标题
        private string pattern;//
        private ArrayList all_notice = new ArrayList();
        public string parse { get; set; } = string.Empty;
        public SpiderNotice(string url, string pattern, string url_main,string subject) : base(url)
        {
            this.subject = subject;
            this.pattern = pattern;
            this.url_main = url_main;
            this.parse = "yyyy-MM-dd";
        }
        public void getNotice()
        {
            all_notice.Clear();
            Regex r = new Regex(pattern, RegexOptions.ExplicitCapture);
            MatchCollection mc = r.Matches(getHtml());
            foreach (Match m in mc)
            {
                GroupCollection group = m.Groups;
                DateTime date = DateTime.ParseExact(group["date"].Value, parse, System.Globalization.CultureInfo.InstalledUICulture);
                string link = url_main + group["link"].Value;
                Notice n = new Notice(group["title"].Value, link, date);
                all_notice.Add(n);
            }
        }
        public Notice index(int index)
        {
            if (index >= all_notice.Count)
                return null;
            else
                return all_notice[index] as Notice;
        }
    }
}
