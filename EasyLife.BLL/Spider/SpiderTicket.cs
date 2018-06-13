using EasyLife.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
    class SpiderTicket : Spider
    {
        Dictionary<string, string> map;
        private ArrayList AllTicket = new ArrayList();//所有的车票信息

        public SpiderTicket(string date, string from, string to, string id) : base()
        {
            string u = "https://kyfw.12306.cn/otn/leftTicket/query?leftTicketDTO.train_date={0}&leftTicketDTO.from_station={1}&leftTicketDTO.to_station={2}&purpose_codes={3}";
            u = string.Format(u, date, from, to, id);
            Url = u;
            Method = "GET";
        }

        public void Get()
        {
            map = new Dictionary<string, string>();
            string str = getHtml();
            if (str == null)
                throw new Exception("Ticket html is null");
            JObject jo = (JObject)JsonConvert.DeserializeObject(str);
            JToken record = jo["data"]["map"];
            foreach (JProperty item in record)
            {
                map.Add(item.Name.ToString(), item.Value.ToString());
            }

            record = jo["data"]["result"];
            foreach (string s in record)
            {
                string[] result = s.Split('|');
                Ticket t = new Ticket();
                t.TrainId = result[3];
                t.FromStation = map[result[6]];
                t.ToStation = map[result[7]];
                t.StartTime = result[8];
                t.ArriveTime = result[9];
                t.LastedTime = result[10];
                t.TicketDate = result[13];
                t.DwNum = result[33] != "" ? result[33] : t.DwNum;
                t.TzNum = result[32] != "" ? result[32] : t.TzNum;
                t.YdNum = result[31] != "" ? result[31] : t.YdNum;
                t.EdNum = result[30] != "" ? result[30] : t.EdNum;
                t.YzNum = result[29] != "" ? result[29] : t.YzNum;
                t.YwNum = result[28] != "" ? result[28] : t.YwNum;
                t.WzNum = result[26] != "" ? result[26] : t.WzNum;
                t.RzNum = result[24] != "" ? result[24] : t.RzNum;
                t.RwNum = result[23] != "" ? result[23] : t.RwNum;
                t.GrwNum = result[21] != "" ? result[21] : t.GrwNum;
                AllTicket.Add(t);
            }
        }

        public Ticket index(int index)
        {
            if (index >= AllTicket.Count)
                throw new IndexOutOfRangeException();
            else
                return AllTicket[index] as Model.Ticket;
        }
        public Ticket[] GetAll()
        {
            Ticket[] All = new Ticket[AllTicket.Count];
            int flag = 0;
            foreach(object t in AllTicket)
            {
                All[flag++] = t as Ticket;
            }
            return All;
        }

        public int Count()
        {
            return AllTicket.Count;
        }
    }
}
