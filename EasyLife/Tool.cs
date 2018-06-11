using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        public static string MD5Encrypt(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(str));//不区分大小写
            return BitConverter.ToString(result);
        }
        #endregion
    }
}
