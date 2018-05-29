using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
    class Spider
    {
        public string url { set; get; } = string.Empty;//要爬取的网页的url
        public Encoding encode { set; get; } = Encoding.UTF8;//目标url的网页编码格式

        private WebRequest request;
        private WebResponse response;
        public Spider(string url)
        {
            this.url = url;
            request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
        }

        //获取目标url的Html代码
        public string getHtml()
        {
            string reader=string.Empty;
            try
            {
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), encode).ReadToEnd();
            }
            catch
            {
                //Todo:Hanle Exception
            }
            return reader;
        }
        //关闭response响应流
        public void closeResponse()
        {
            try
            {
                response.Close();
            }
            catch (Exception e)
            {
                //Todo: handle Exception
            }
        }
    }
}
