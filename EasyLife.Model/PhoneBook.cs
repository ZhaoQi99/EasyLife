using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Model
{
   public class PhoneBook
    {
        #region 数据模型
        private string department = string.Empty;
        private string telnumber = string.Empty;
        private string campus = string.Empty;
        private string seconddepartment = string.Empty;
        public string Department { get { return department; }set { department = value; } }
        public string TelNumber { get { return telnumber; } set { telnumber = value; } }
        public string Campus { get { return campus; } set { campus = value; } }
        public string SecondDepartment { get { return seconddepartment; } set { seconddepartment = value; } }
        #endregion
    }
}
