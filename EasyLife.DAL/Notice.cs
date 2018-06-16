using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.DAL
{
    public class Notice
    {
        //插入一条记录
        public int Add(Model.Notice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Notice](");
            strSql.Append("[Type],[Link],[Title],[Department],[Date])");
            strSql.Append(" values (");
            strSql.Append("@Type,@Link,@Title,@Department,@Date)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@Type", OleDbType.VarChar,255),
                    new OleDbParameter("@Link", OleDbType.VarChar,255),
                    new OleDbParameter("@Title", OleDbType.VarChar,255),
                    new OleDbParameter("@Department", OleDbType.VarChar,255),
                    new OleDbParameter("@Date", OleDbType.VarChar,255)};
            parameters[0].Value = model.Type;
            parameters[1].Value = model.Link;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.Department;
            parameters[4].Value = model.Date.ToString("yyyy-MM-dd");
            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        public int Add(Model.Notice[] Allmodel)
        {
            int n = 0;
            for (int i = 0; i < Allmodel.Length; i++)
            {
                Model.Notice model = new Model.Notice();
                model = Allmodel[i];
                if (Exist(model.Link) == false)
                {
                    n += Add(model);
                }
            }
            return n;
        }
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Department as 部门,Title as 标题,Date as 日期,Link as 链接,Type as 类型");
            strSql.Append(" FROM Notice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.Query(strSql.ToString(), "Notice");
        }

        public bool Exist(string Link)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from [Notice]");
            strSql.Append(" where Link='" + Link + "' ");
            return SqlHelper.Exists(strSql.ToString());
        }
        public OleDbDataReader RegEx(string Department, string type)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Regular]");
            strSql.Append(" where Department='" + Department + "' ");
            strSql.Append("AND Type='" + type + "' ");
            return SqlHelper.ExecuteReader(strSql.ToString());
        }
                public string[]QueryDep()
        {
            StringBuilder strSql = new StringBuilder();
            int n = Convert.ToInt32( SqlHelper.ExecuteScalar("select count(*) from Regular"));
            strSql.Append("select distinct Department");
            strSql.Append(" FROM Regular");
            OleDbDataReader reader = SqlHelper.ExecuteReader(strSql.ToString());
            string[] AllDep = new string[n/2];
            int flag = 0;
            while(reader.Read())
            {
                AllDep[flag++] = reader.GetValue(0).ToString();
            }
            reader.Close();
            return AllDep;
        }
    }
}
