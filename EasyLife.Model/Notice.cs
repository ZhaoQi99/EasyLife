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
        private string title=string.Empty;
        private string link=string.Empty;
        private DateTime date=DateTime.Now;
        private string type=string.Empty;
        private string department=string.Empty;
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
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        #endregion
        override public string ToString()
        {
            return string.Format("标题:{0}\n时间:{1}\n链接:{2}\n", title, date.ToString("yyyy-MM-dd"), link);

        }
    }
}
