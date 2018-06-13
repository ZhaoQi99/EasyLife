using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.DAL
{
    public class User
    {
        /// <summary>
        /// 是否存在该用户
        /// </summary>
        public bool Exists(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from [User]");
            strSql.Append(" where UserName=" + "'" + username + "'");

            return SqlHelper.Exists(strSql.ToString());
        }
        /// <summary>
        /// 校验用户名和密码
        /// </summary>
        public bool Check(string username, string password)
        {
            return true;
        }
        /// <summary>
        /// 添加一个用户
        /// </summary>
        public void Add(Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [User](");
            strSql.Append("[UserName],[PassWord],[Email],[Tel],[School],[Sex],[ForgetQue],[ForgetAns])");
            strSql.Append(" values (");
            strSql.Append("@UserName,@PassWord,@Email,@Tel,@School,@Sex,@ForgetQue,@ForgetAns)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.VarChar,255),
                    new OleDbParameter("@PassWord", OleDbType.VarChar,255),
                    new OleDbParameter("@Email", OleDbType.VarChar,255),
                    new OleDbParameter("@Tel", OleDbType.VarChar,255),
                    new OleDbParameter("@School", OleDbType.VarChar,255),
                    new OleDbParameter("@Sex", OleDbType.VarChar,255),
                    new OleDbParameter("@ForgetQue", OleDbType.VarChar,255),
                    new OleDbParameter("@ForgetAns", OleDbType.VarChar,255)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.PassWord;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.Tel;
            parameters[4].Value = model.School;
            parameters[5].Value = model.Sex;
            parameters[6].Value = model.ForgetQue;
            parameters[7].Value = model.ForgetAns;
            SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新用户数据
        /// </summary>
        public void Update(Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [User] set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("Email=@Email,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("School=@School,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("ForgetQue=@ForgetQue,");
            strSql.Append("ForgetAns=@ForgetAns");
            strSql.Append("Memo=@Memo");
            strSql.Append(" where UserName=@UserName ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.VarChar,255),
                    new OleDbParameter("@PassWord", OleDbType.VarChar,255),
                    new OleDbParameter("@Email", OleDbType.VarChar,255),
                    new OleDbParameter("@Tel", OleDbType.VarChar,255),
                    new OleDbParameter("@School", OleDbType.VarChar,255),
                    new OleDbParameter("@Sex", OleDbType.VarChar,255),
                    new OleDbParameter("@ForgetQue", OleDbType.VarChar,255),
                    new OleDbParameter("@ForgetAns", OleDbType.VarChar,255)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.PassWord;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.Tel;
            parameters[4].Value = model.School;
            parameters[5].Value = model.Sex;
            parameters[6].Value = model.ForgetQue;
            parameters[7].Value = model.ForgetAns;
            SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一个用户
        /// </summary>
        public void Delete(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [User] ");
            strSql.Append(" where UserName=@UserName ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.Integer,4)};
            parameters[0].Value = username;

            SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 得到一个用户对象实体
        /// </summary>
        public Model.User GetModel(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserName,PassWord,Email,Tel,School,Sex,ForgetQue,ForgetAns from [User] ");
            strSql.Append(" where UserName=@UserName ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@UserName", OleDbType.Integer,4)};
            parameters[0].Value = username;

            Model.User model = new Model.User();
            DataSet ds = SqlHelper.Query(strSql.ToString(), parameters,"User");
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
                model.PassWord = ds.Tables[0].Rows[0]["PassWord"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.School = ds.Tables[0].Rows[0]["School"].ToString();
                model.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                model.Sex = ds.Tables[0].Rows[0]["Sex"].ToString();
                model.ForgetQue = ds.Tables[0].Rows[0]["ForQue"].ToString();
                model.ForgetAns = ds.Tables[0].Rows[0]["ForgetAns"].ToString();
                return model;
            }
            else
                return null; 
        }
    }
}
