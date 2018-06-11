using System;
using System.Collections.Generic;
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
            strSql.Append(" where UserName="+"'"+username+"'");

            return SqlHelper.Exists(strSql.ToString());
        }
        /// <summary>
        /// 校验用户名和密码
        /// </summary>
        public bool Check(string username,string password)
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

        }
        /// <summary>
        /// 得到一个用户对象实体
        /// </summary>
        public EasyLife.Model.User GetModel(string username)
        {
            return null;
        }
    }
}
