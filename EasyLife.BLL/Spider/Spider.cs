using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.Spider
{
    public class Spider
    {
        private string url = string.Empty;//要爬取的网页的url
        public HttpWebRequest request;
        public HttpWebResponse response;
        public string encode = "UTF-8";//目标url的网页编码格式
        public string Method = string.Empty;
        public string Url
        {
            get { return url; }
            set
            {
                url = value;
            }
        }
        public string Encode
        {
            get { return encode; }
            set
            {
                if (value == "UTF-8" || value == "GBK")
                {
                    encode = value;
                }
                else
                {
                    //Todo:handle exception
                }
            }
        }

        public Spider(string url,string method)
        {
            this.url = url;
            this.Method = method;
            Create();
        }
        public Spider() { }

        public void Create()
        {
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = Method;
            request.Credentials = CredentialCache.DefaultCredentials;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
        }
        //获取目标url的Html代码
        public string getHtml()
        {
            string reader = string.Empty;
            try
            {
                Create();
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encode));
                    reader = sr.ReadToEnd();
                    sr.Close();
                    response.Close();//关闭response响应流
                }
                else
                    throw new Exception();
            }
            catch
            {
                //Todo:Hanle Exception
            }
            return reader;
        }

    }
}
