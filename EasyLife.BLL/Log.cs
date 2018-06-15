using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLife.BLL
{
    public static class Log
    {
        //记录日志
        public static void Write(string text, string type = "")
        {
            if (Directory.Exists(Application.StartupPath + "/Log") == false)
                Directory.CreateDirectory(Application.StartupPath + "/Log");//创建新路径
            FileStream fs = new FileStream(Application.StartupPath + "/Log/" + type + "_Log.log", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine(text);
            sw.Close();
        }
    }
}
