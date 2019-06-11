using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife
{
    public  class Clock
    {
        private int width;
        public Clock(int width)
        {
            this.width = width;
        }
        public  Bitmap get()
        {
            Bitmap map = new Bitmap(width, width);
            Graphics g = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Black,1f);
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.HighQuality;
            int r = width/2;
            PointF center = new PointF(width/2, width/2);
            g.DrawArc(pen, new RectangleF(center.X - r, center.Y - r, 2 * r - 3, 2 * r - 3), 0, 360);
            GraphicsPath round = new GraphicsPath();
            round.AddArc(new RectangleF(center.X - r, center.Y - r, 2 * r - 3, 2 * r - 3), 0, 360);

            for (int i = 0; i < 59; i++)
            {
                g.ResetTransform(); //重置为单位矩阵
                g.TranslateTransform(center.X, center.Y);   // 通过左乘指定的平移来更改系统的坐标原点
                g.RotateTransform(i * 6);    //旋转 ，每一秒旋转6度
                if ((i == 0) || (i % 5 == 4))//绘制表盘的刻度
                {
                    g.DrawLine(new Pen(Color.Black, 2.5f), r - 12, 0, r - 5, 0); //小时标准刻度
                }
                else
                {
                    g.DrawLine(pen, r - 6, 0, r - 5, 0);//分钟标准刻度
                }
            }

            float hour, minute, second;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            hour = hour + minute / 60f + second / 3600f;
            minute = minute + second / 60f;

            g.ResetTransform();
            g.TranslateTransform(center.X, center.Y);//画时针
            g.RotateTransform(hour * 30 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 2.5f), 0, 0, r * 0.5f, 0f); //绘出时针

            g.ResetTransform();//画分针 ,坐标系恢复到默认状态，Graphics对象回到默认坐标系中绘图。
            g.TranslateTransform(center.X, center.Y);//通过左乘指定的平移来更改系统的坐标原点
            g.RotateTransform(minute * 6 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 1.5f), 0, 0, r * 0.6f, 0f);

            g.ResetTransform();//画秒针
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(second * 6 + 270 - 6);
            g.DrawLine(new Pen(Color.Black, 0.5f), 0, 0, r * 0.7f, 0f);//绘出秒针
            return map;
        }
    }
}
