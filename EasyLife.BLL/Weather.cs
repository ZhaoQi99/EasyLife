using System;
using System.Windows.Forms;

namespace EasyLife.BLL
{
    public static class Weather
    {
        public static string[] Get(string City)
        {
            string[] r = new string[22];
            try
            {
                cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
                r = w.getWeatherbyCityName(City);
            }
            catch (Exception e)
            {
                Log.Write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss ") + e.Message, "Exception");
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return r;
        }
    }
}
