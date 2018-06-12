using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace EasyLife
{
    public static class Tool
    {
        #region 私有方法
        //得到图程序集中的图片对象
        private static Stream FindStream(string str)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resNames = assembly.GetManifestResourceNames();
            foreach (string s in resNames)
            {
                if (s == str)
                {
                    return assembly.GetManifestResourceStream(s);
                }
            }
            return null;
        }
        #endregion

        #region 共有方法
        //得到要绘置的图片对象
        public static Bitmap GetResBitmap(string str)
        {
            Stream sm = FindStream(str);
            if (sm == null) return null;
            return new Bitmap(sm);
        }
        //对字符串进行MD5加密
        public static string MD5Encrypt(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(str));//不区分大小写
            return BitConverter.ToString(result);
        }

        //获取车站代码与车站名，并写入xml中
        public static void StationNameXml()
        {
            Spider.Spider s = new Spider.Spider("https://kyfw.12306.cn/otn/resources/js/framework/station_name.js?station_version=1.9055");
            string str = s.getHtml();
            string pattern = @"@\S{2,5}?[|](?<Name>\S{1,8}?)[|](?<Code>\S{3,5}?)[|]";
            Regex r = new Regex(pattern, RegexOptions.ExplicitCapture);

            XmlDocument xmldoc = new XmlDocument();
            XmlDeclaration xmldecl;

            xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);//加入XML的声明段落
            xmldoc.AppendChild(xmldecl);

            XmlElement root = xmldoc.CreateElement("", "Dict", "");//加入一个根元素
            xmldoc.AppendChild(root);

            MatchCollection mc = r.Matches(str);
            foreach (Match m in mc)
            {
                GroupCollection group = m.Groups;
                XmlNode node = xmldoc.CreateNode(XmlNodeType.Element, "Pair", null);

                XmlNode temp = xmldoc.CreateNode(XmlNodeType.Element, "Station", null);
                temp.InnerText = group["Name"].Value; 
                node.AppendChild(temp);

                XmlNode temp2 = xmldoc.CreateNode(XmlNodeType.Element, "Code", null);
                temp2.InnerText = group["Code"].Value;
                node.AppendChild(temp2);

                root.AppendChild(node);
            }
            string nowpath = Environment.CurrentDirectory;
            if (Directory.Exists(nowpath+"/Data")==false)
                Directory.CreateDirectory(nowpath + "/Data");//创建新路径
            xmldoc.Save(nowpath+"/Data/"+"StationName.xml");
        }
        #endregion
    }
}
