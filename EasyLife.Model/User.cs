using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Model
{
   public  class User
    {
        #region 数据模型
        private string username;//用户名
        private string password;//密码
        private string email;//邮箱
        private string tel;//电话号码
        private string school;//学院
        private string  sex;//性别 
        private string forgetque;//密保问题
        private string forgetans;//密保答案
        public string UserName { get { return username; } set { username = value; } }
        public string PassWord { get { return password; } set { password = value; } }
        public string Email { get { return email; }set { email = value; } }
        public string Tel { get { return tel; } set{tel=value; } }
        public string School { get { return school; } set{ school = value; } }
        public string Sex { get { return sex; }set { sex = value; } }
        public string ForgetQue { get { return forgetque; } set { forgetque = value; } }
        public string ForgetAns { get { return forgetans; } set { forgetans = value; } }
        #endregion
    }
}
