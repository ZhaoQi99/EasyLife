using System;

namespace EasyLife.BLL
{
    public static class Weather
    {
        public static string[] Get(string City)
        {
            string[]r= new string[22];
            try
            {
                cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
             r = w.getWeatherbyCityName(City);
            }
            catch(Exception)
            {

            }
            return r;
        }
    }
}
