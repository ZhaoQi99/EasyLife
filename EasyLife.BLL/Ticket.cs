using System;
using System.Data;
using System.Text;
using EasyLife.Spider;
using System.Threading;
using System.Xml;

namespace EasyLife.BLL
{
    public class Ticket
    {
        private readonly DAL.Ticket dal = new DAL.Ticket();

        private string StationCode(string StationName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Environment.CurrentDirectory + "/Data/StationName.xml");
            XmlNodeList data = doc.DocumentElement.ChildNodes;
            foreach (XmlNode node in data)
            {
                XmlElement xe = (XmlElement)node;
                XmlNodeList xnl0 = xe.ChildNodes;
                string s = xnl0.Item(0).InnerText;
                if(s==StationName)
                {
                    return xnl0.Item(1).InnerText;
                }
            }
            return string.Empty;
        }
        public DataSet GetList(string FromStation, string ToStation, DateTime Date,string Identity)
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("SearchFrom='" + FromStation+"'");
            strWhere.Append(" AND SearchTo='" + ToStation + "'");
            strWhere.Append(" AND TicketDate='" + Date.ToString("yyyyMMdd") + "'");
            strWhere.Append(" AND Identity='" + Identity + "'");
            return dal.GetList(strWhere.ToString());
        }
        public  int  Delete(string FromStation, string ToStation, DateTime Date, string Identity)
        {
            return dal.Delete(FromStation,ToStation,Date,Identity);
        }
        public int Add(string SearchFrom,string SearchTo,Model.Ticket model)
        {
            return dal.Add(SearchFrom,SearchTo,model);
        }
        public bool Exists(string FromStation,string ToStation,DateTime Date,string Identity)
        {
            return dal.Exists(FromStation, ToStation, Date,Identity);
        }
        public string QueryDate(string FromStation, string ToStation, DateTime Date,string Identity)
        {
            return dal.QueryDate(FromStation,ToStation,Date,Identity);
        }
        public int Update(string FromStation, string ToStation, DateTime Date,string Id)
        {
            string FromCode = StationCode(FromStation);
            string ToCode = StationCode(ToStation);
            string IdCode = string.Empty;
            if (Id == "成人")
                IdCode = "ADULT";
            if (Id == "学生")
                IdCode = "0X00";
            SpiderTicket spider = new SpiderTicket( Date.ToString("yyyy-MM-dd"),FromCode, ToCode,IdCode);
            spider.Get();
            Model.Ticket[] AllTicket= new Model.Ticket[spider.Count()];
            AllTicket = spider.GetAll();
            for (int i = 0; i < AllTicket.Length; i++)
            {
                AllTicket[i].Identity = Id;
            }
            return dal.Add(FromStation, ToStation,AllTicket);
        }
    }
}
