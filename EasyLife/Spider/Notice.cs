using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
    class Notice
    {
        private string title;
        private string link;
        private DateTime date;
        public Notice(string title, string link, DateTime date)
        {
            this.title = title;
            this.link = link;
            this.date = date;
        }
        public string getTitle()
        {
            return title;
        }
        public string getLink()
        {
            return link;
        }
        public DateTime getDate()
        {
            return date;
        }
        override public string ToString()
        {
            return  string.Format("标题:{0}\n时间:{1}\n链接:{2}\n", title, date.ToString("yyyy-MM-dd"), link);

        }
    }
}
