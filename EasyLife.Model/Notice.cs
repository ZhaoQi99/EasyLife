using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Model
{
    public class Notice
    {
        #region 数据模型
        private string title;
        private string link;
        private DateTime date;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Link
        {
            set
            {
                link = value;
            }
            get
            {
                return link;
            }
        }
        #endregion
        override public string ToString()
        {
            return string.Format("标题:{0}\n时间:{1}\n链接:{2}\n", title, date.ToString("yyyy-MM-dd"), link);

        }
    }
}
