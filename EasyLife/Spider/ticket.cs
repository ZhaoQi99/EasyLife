using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
    class Ticket
    {
        public string TrainId;//车次
        public string FromStation="--";//出发站
        public string ToStation="--";//到达站
        public string StartTime="--";//发车时间
        public string ArriveTime="--";//到达时间
        public string LastedTime="--";//历时
        public string TzNum="--";//特等座
        public string YdNum="--";//一等座
        public string EdNum="--";//二等座
        public string GrwNum="--";//高级软卧
        public string RwNum="--";//软卧
        public string DwNum="--";//动卧
        public string YwNum="--";//硬卧
        public string RzNum="--";//软座
        public string YzNum="--";//硬座
        public string WzNum="--";//无座
        public string QtNum="--";//其他

        public Ticket() { }

        Dictionary<string, string> getMap()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("出发站", FromStation);
            result.Add("到达站",ToStation);
            result.Add("发车时间", StartTime);
            result.Add("到达时间", ArriveTime);
            result.Add("历时", LastedTime);
            result.Add("特等座", TzNum);
            result.Add("一等座", YdNum);
            result.Add("二等座", EdNum);
            result.Add("高级软卧", GrwNum);
            result.Add("软卧", RwNum);
            result.Add("动卧", DwNum);
            result.Add("硬卧", YwNum);
            result.Add("软座", RzNum);
            result.Add("硬座", YzNum);
            result.Add("无座", WzNum);
            result.Add("其他", QtNum);
            return result;
        }
    }
}
