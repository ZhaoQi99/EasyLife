using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.DAL
{
    public class Ticket
    {
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [TrainId] as 车次号,[FromStation] as 出发站,[ToStation] as 到达站,[StartTime] as 出发时间,[ArriveTime] as 到达时间,[LastedTime] as 历时,[TzNum] as 特等座," +
                "[YdNum] as 一等座,[EdNum] as 二等座,[GrwNum] as 高级软卧,[RwNum] as 软卧,[DwNum] as 动卧,[YwNum] as 硬卧,[RzNum] as 软座,[YzNum] as 硬座,[WzNum] as 无座,[QtNum] as 其他  ");
            strSql.Append(" FROM Ticket ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.Query(strSql.ToString(), "Ticket");
        }
        public int Delete(string FromStation, string ToStation, DateTime Date, string Identity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Ticket] ");
            strSql.Append(" where SearchFrom=@SearchFrom AND SearchTo=@SearchTo AND TicketDate=@TicketDate AND Identity=@Identity");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@SearchFrom", OleDbType.VarChar,255),
                    new OleDbParameter("@SearchTo", OleDbType.VarChar,255),
                    new OleDbParameter("@TicketDate", OleDbType.VarChar,255),
                    new OleDbParameter("@Identity", OleDbType.VarChar,255)};
            parameters[0].Value = FromStation;
            parameters[1].Value = ToStation;
            parameters[2].Value = Date.ToString("yyyyMMdd");
            parameters[3].Value = Identity;
            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        public int Add(string SearchForm,string SearchTo,Model.Ticket model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Ticket](");
            strSql.Append("[TrainId],[FromStation],[ToStation],[SearchFrom],[SearchTo],[TicketDate],[StartTime],[ArriveTime],[LastedTime],[TzNum]," +
                "[YdNum],[EdNum],[GrwNum],[RwNum],[DwNum],[YwNum],[RzNum],[YzNum],[WzNum],[QtNum],[Identity],[QueryTime] )");
            strSql.Append(" values (");
            strSql.Append("@TrainId,@FromStation,@ToStation,@SearchFrom,@SearchTo,@TicketDate,@StartTime,@ArriveTime,@LastedTime,@TzNum," +
                "@YdNum,@EdNum,@GrwNum,@RwNum,@DwNum,@YwNum,@RzNum,@YzNum,@WzNum,@QtNum,@Identity,@QueryTime)");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@TrainId", OleDbType.VarChar,255),
                    new OleDbParameter("@FromStation", OleDbType.VarChar,255),
                    new OleDbParameter("@ToStation", OleDbType.VarChar,255),
                    new OleDbParameter("@SearchFrom", OleDbType.VarChar,255),
                    new OleDbParameter("@SearchTo", OleDbType.VarChar,255),
                    new OleDbParameter("@TicketDate", OleDbType.VarChar,255),
                    new OleDbParameter("@StartTime", OleDbType.VarChar,255),
                    new OleDbParameter("@ArriveTime", OleDbType.VarChar,255),
                    new OleDbParameter("@LastedTime", OleDbType.VarChar,255),
                    new OleDbParameter("@TzNumNum", OleDbType.VarChar,255),
                    new OleDbParameter("@YdNum", OleDbType.VarChar,255),
                    new OleDbParameter("@EdNum", OleDbType.VarChar,255),
                    new OleDbParameter("@GrwNum", OleDbType.VarChar,255),
                    new OleDbParameter("@RwNum", OleDbType.VarChar,255),
                    new OleDbParameter("@DwNum", OleDbType.VarChar,255),
                    new OleDbParameter("@YwNum", OleDbType.VarChar,255),
                    new OleDbParameter("@RzNum", OleDbType.VarChar,255),
                    new OleDbParameter("@YzNum", OleDbType.VarChar,255),
                    new OleDbParameter("@WzNum", OleDbType.VarChar,255),
                    new OleDbParameter("@QtNum", OleDbType.VarChar,255),
                    new OleDbParameter("@Identity", OleDbType.VarChar,255),
                    new OleDbParameter("@QueryTime", OleDbType.VarChar,255)};
            parameters[0].Value = model.TrainId;
            parameters[1].Value = model.FromStation;
            parameters[2].Value = model.ToStation;
            parameters[3].Value = SearchForm;
            parameters[4].Value = SearchTo;
            parameters[5].Value = model.TicketDate;
            parameters[6].Value = model.StartTime;
            parameters[7].Value = model.ArriveTime;
            parameters[8].Value = model.LastedTime;
            parameters[9].Value = model.TzNum;
            parameters[10].Value = model.YdNum;
            parameters[11].Value = model.EdNum;
            parameters[12].Value = model.GrwNum;
            parameters[13].Value = model.RwNum;
            parameters[14].Value = model.DwNum;
            parameters[15].Value = model.YwNum;
            parameters[16].Value = model.RzNum;
            parameters[17].Value = model.YzNum;
            parameters[18].Value = model.WzNum;
            parameters[19].Value = model.QtNum;
            parameters[20].Value = model.Identity;
            parameters[21].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        public int Add(string SearchForm, string SearchTo, Model.Ticket[] Allmodel)
        {
            int n = 0;
            for (int i = 0; i < Allmodel.Length; i++)
            {
                Model.Ticket model = new Model.Ticket();
                model = Allmodel[i];
                n += Add(SearchForm, SearchTo, model);
            }
            return n;
        }
        public bool Exists(string FromStation, string ToStation, DateTime Date, string Identity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from [Ticket]");
            strSql.Append(" where SearchFrom=@SearchFrom AND SearchTo=@SearchTo AND TicketDate=@TicketDate AND Identity=@Identity");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@SearchFrom", OleDbType.VarChar,255),
                    new OleDbParameter("@SearchTo", OleDbType.VarChar,255),
                    new OleDbParameter("@TicketDate", OleDbType.VarChar,255),
                    new OleDbParameter("@Identity", OleDbType.VarChar,255)};
            parameters[0].Value = FromStation;
            parameters[1].Value = ToStation;
            parameters[2].Value = Date.ToString("yyyyMMdd"); ;
            parameters[3].Value = Identity;
            return SqlHelper.Exists(strSql.ToString(), parameters);
        }

        public string QueryDate(string FromStation, string ToStation, DateTime Date, string Identity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select QueryTime from [Ticket]");
            strSql.Append(" where SearchFrom=@SearchFrom AND SearchTo=@SearchTo AND TicketDate=@TicketDate AND Identity=@Identity");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@SearchFrom", OleDbType.VarChar,255),
                    new OleDbParameter("@SearchTo", OleDbType.VarChar,255),
                    new OleDbParameter("@TicketDate", OleDbType.VarChar,255),
                    new OleDbParameter("@Identity", OleDbType.VarChar,255)};
            parameters[0].Value = FromStation;
            parameters[1].Value = ToStation;
            parameters[2].Value = Date.ToString("yyyyMMdd");
            parameters[3].Value = Identity;
            object o = SqlHelper.ExecuteScalar(strSql.ToString(), parameters);
            return o as string;
        }
    }
}
