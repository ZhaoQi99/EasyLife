using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.DAL
{
    public class PhoneBook
    {
        public DataSet Query(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Campus as 校区,Department as 所在单位,SecondDepartment as 所在部门,TelNumber as 电话号码");
            strSql.Append(" FROM Tel ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.Query(strSql.ToString(), "Tel");
        } 
        public string[]QueryDep()
        {
            StringBuilder strSql = new StringBuilder();
            int n = Convert.ToInt32( SqlHelper.ExecuteScalar("select count(*) from Tel"));
            strSql.Append("select Department");
            strSql.Append(" FROM Tel");
            OleDbDataReader reader = SqlHelper.ExecuteReader(strSql.ToString());
            string[] AllDep = new string[n];
            int flag = 0;
            while(reader.Read())
            {
                AllDep[flag++] = reader.GetValue(0).ToString();
            }
            reader.Close();
            return AllDep;
        }
        public int Add(Model.PhoneBook model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Tel](");
            strSql.Append("[Department],[Campus],[TelNumber],[SecondDepartment] )");
            strSql.Append(" values (");
            strSql.Append("@Department,@Campus,@TelNumber,@SecondDepartment)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@Department", OleDbType.VarChar,255),
                    new OleDbParameter("@Campus", OleDbType.VarChar,255),
                    new OleDbParameter("@TelNumber", OleDbType.VarChar,255),
                    new OleDbParameter("@SecondDepartment", OleDbType.VarChar,255) };
            parameters[0].Value = model.Department;
            parameters[1].Value = model.Campus;
            parameters[2].Value = model.TelNumber;
            parameters[3].Value = model.SecondDepartment;
            return SqlHelper.ExecuteNonQuery(strSql.ToString(),parameters);
        }
        public int Delete(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete FROM Tel");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteNonQuery(strSql.ToString());
        }
    }
}
