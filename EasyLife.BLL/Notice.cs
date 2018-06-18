using EasyLife.Spider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.BLL
{
    public class Notice
    {
        private readonly DAL.Notice dal = new DAL.Notice();
        //添加一条通知或新闻记录
        public int Add(Model.Notice model)
        {
            return dal.Add(model);
        }
        public bool Exist(string Link)
        {
            return dal.Exist(Link);
        }
        public Dictionary<string, string> RegEx(string Department, string Type)
        {
            OleDbDataReader reader = dal.RegEx(Department, Type);
            reader.Read();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int n = reader.FieldCount;
            for (int i = 0; i < n; i++)
            {
                string key = reader.GetName(i);
                string value = reader.GetValue(i).ToString();
                dict.Add(key, value);
            }
            reader.Close();
            return dict;
        }
        public DataSet GetList(string Department, string Type, string Date)
        {
            StringBuilder Sql = new StringBuilder();
            bool flag = false;
            if (Department != string.Empty)
            {
                if (flag == false)
                    Sql.Append("Department='" + Department + "' ");
                flag = true;
            }
            if (Type != string.Empty)
            {
                if (flag == false)
                    Sql.Append("Type='" + Type + "' ");
                else
                    Sql.Append("AND Type='" + Type + "' ");
                flag = true;
            }
            if (Date != string.Empty)
            {
                DateTime temp = DateTime.ParseExact(Date, "yyyy-M-d", System.Globalization.CultureInfo.InstalledUICulture);
                if (flag == false)
                    Sql.Append("[Date]='" + temp.ToString("yyyy-MM-dd") + "' ");
                else
                    Sql.Append("AND [Date]='" + temp.ToString("yyyy-MM-dd") + "' ");
            }
            return dal.GetList(Sql.ToString());
        }
        public int Update(string Department, string Type)
        {
            Dictionary<string, string> dict = RegEx(Department, Type);
            string MoreLink = dict["MoreLink"].ToString();
            string pattern = dict["RuleStr"].ToString();
            string Encode = dict["Encode"].ToString();
            string UrlMain = dict["PublicLink"].ToString();
            string Parse = dict["Parse"].ToString();
            SpiderNotice spider = new SpiderNotice(MoreLink, pattern, UrlMain, Department, Type);
            spider.encode = Encode;
            spider.parse = Parse;
            spider.Get();
            Model.Notice[] AllNotice = new Model.Notice[spider.Count()];
            AllNotice = spider.GetAll();
            return dal.Add(AllNotice);
        }
        public string[] QueryDep()
        {
            return dal.QueryDep();
        }
        public bool Exist(string Department, string Type)
        {
            return dal.Exist(Department, Type);
        }
    }
}
