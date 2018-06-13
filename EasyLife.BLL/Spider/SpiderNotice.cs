using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyLife.Spider;
using System.Collections;
using System.Text.RegularExpressions;
using EasyLife.Model;

namespace EasyLife.Spider
{
    public class SpiderNotice : Spider
    {
        private string url_main;//各个通知链接的公共部分
        private string department;//所属部门
        private string type;//通知类型
        private string pattern;//用于匹配的正则表达式规则
        private ArrayList all_notice = new ArrayList();//所有的通知
        public string parse  = string.Empty;//日期的解析规则
        public SpiderNotice(string url, string pattern, string url_main,string department,string type) : base(url,"GET")
        {
            this.department = department;
            this.pattern = pattern;
            this.url_main = url_main;
            this.type = type;
            this.parse = "yyyy-MM-dd";
        }
        public void Get()
        {
            all_notice.Clear();
            Regex r = new Regex(pattern, RegexOptions.ExplicitCapture);
            string s = getHtml();
            if (s == null)
                throw new ArgumentNullException("html");
            MatchCollection mc = r.Matches(s);
            foreach (Match m in mc)
            {
                GroupCollection group = m.Groups;
                DateTime date = DateTime.ParseExact(group["date"].Value, parse, System.Globalization.CultureInfo.InstalledUICulture);
                string link = url_main + group["link"].Value;
                Notice n = new Notice();
                n.Title = group["title"].Value;
                n.Link = link;
                n.Date = date;
                n.Department = department;
                n.Type=type;
                all_notice.Add(n);
            }
        }
        public Notice index(int index)
        {
            if (index >= all_notice.Count)
                throw new IndexOutOfRangeException();
            else
                return all_notice[index] as Notice;
        }
        public Notice[] GetAll()
        {
            Notice[] All = new Notice[all_notice.Count];
            int flag = 0;
            foreach (object t in all_notice)
            {
                All[flag++] = t as Notice;
            }
            return All;
        }
        public int Count()
        {
            return all_notice.Count;
        }
    }
}
