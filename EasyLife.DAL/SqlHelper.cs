using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.DAL
{
    /// <summary>
    /// SqlServer数据访问帮助类
    /// </summary>
    class SqlHelper
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb";
        #region 私有构造函数和方法
        private SqlHelper() { }
        private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, string cmdText, OleDbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (OleDbParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
        #endregion

        #region 简单SQL语句
        public static bool Exists(string sql)
        {
            object obj = ExecuteScalar(sql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                cmdresult = 0;
            else
                cmdresult = int.Parse(obj.ToString());
            return cmdresult != 0;
        }
        public static object ExecuteScalar(string SQLString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                            return null;
                        else
                            return obj;
                    }
                    catch (OleDbException e)
                    {
                        connection.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        public static int ExecuteNonQuery(string sql)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        int n = cmd.ExecuteNonQuery();
                        return n;
                    }
                    catch (OleDbException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }
        public static int ExecuteNonQuery(string SQLString, params OleDbParameter[] cmdParms)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, SQLString, cmdParms);
                        int n = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return n;
                    }
                    catch (OleDbException E)
                    {
                        throw new Exception(E.Message);
                    }
                }
            }
        }
        #endregion

    }

}