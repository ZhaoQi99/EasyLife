using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
   public class Ticket
    {
        #region 数据模型
        private string trainid;//车次
        private string fromstation = "--";//出发站
        private string totation = "--";//到达站
        private string starttime = "--";//发车时间
        private string arrivetime = "--";//到达时间
        private string lastedtime = "--";//历时
        private string tzNum = "--";//特等座
        private string ydNum = "--";//一等座
        private string edNum = "--";//二等座
        private string grwNum = "--";//高级软卧
        private string rwNum = "--";//软卧
        private string dwNum = "--";//动卧
        private string ywNum = "--";//硬卧
        private string rzNum = "--";//软座
        private string yzNum = "--";//硬座
        private string wzNum = "--";//无座
        private string qtNum = "--";//其他

        public string TrainId { get { return trainid; } set { trainid = value; } }
        public string FromStation { get { return fromstation; } set { fromstation = value; } }
        public string ToStation { get { return totation; } set { totation = value; } }
        public string StartTime { get { return starttime; } set { starttime = value; } }
        public string ArriveTime { get { return arrivetime; }set { arrivetime = value; } }
        public string LastedTime { get { return lastedtime; } set { lastedtime = value; } }
        public string TzNum { get { return tzNum; } set { tzNum = value; } }
        public string YdNum { get { return ydNum; } set { ydNum = value; } }
        public string EdNum { get { return edNum; } set { edNum = value; } }
        public string GrwNum { get { return grwNum; } set { grwNum = value; } }
        public string RwNum { get { return rwNum; } set { rwNum = value; } }
        public string DwNum { get { return dwNum; } set { dwNum = value; } }
        public string YwNum {get{ return ywNum; }set{ ywNum = value; } }
        public string RzNum {get{ return rzNum; }set{ rzNum = value; } }
        public string YzNum {get{ return yzNum; }set{ yzNum = value; } }
        public string WzNum {get{ return wzNum; }set{ wzNum = value; } }
        public string QtNum {get{ return qtNum; }set{ qtNum = value; } }
        #endregion
        public Ticket() { }

        Dictionary<string, string> getMap()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("出发站", FromStation);
            result.Add("到达站", ToStation);
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
