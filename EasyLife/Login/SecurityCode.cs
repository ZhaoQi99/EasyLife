using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Login
{
    class SecurityCode
    {
        private Random rand = new Random();//生成随机数
        private string VerificationText = string.Empty;//验证码字符串
        private Bitmap map;//验证码的位图
        private int length;//验证码的字符个数
        private int width;//验证码图片的宽度
        private int height;//验证码图片的高度

        public SecurityCode(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public SecurityCode(int length)
        {
            this.length = length;
            this.width = (length+1) * 25;
            this.height = 40;
        }

        //随机生成验证码字符串
        private void CreateVerificationText(int length)
        {
            VerificationText = string.Empty;
            string dictionary = "ABCDEFGHIJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";//去除O,o,0 ,l,1
            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(0, dictionary.Length);
                VerificationText += dictionary[index].ToString();
            }
        }

        //刷新验证码
        public void UpdateVerifyCode()
        {
            CreateVerificationText(length);
            CreateImage();
            //Console.WriteLine(MD5Encrypt(VerificationText));//Only for test
        }
        //生成验证码图片
        private void CreateImage()
        {
            map = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(map);
            Pen pen = new Pen(Color.Black);
            string[] font = { "Verdana", "Microsoft Sans Serif", "Consolas", "Arial", "宋体" };
            Font f = new Font("Arial", 20, FontStyle.Bold);
            g.Clear(Color.White);
            SolidBrush brush = new SolidBrush(Color.White);

            //绘制干扰线条
            pen.Width = 0.1F;
            for (int i = 0; i < 15; i++)
            {
                pen.Color = RandColor();
                g.DrawLine(pen, RandPoint(),RandPoint());
            }
            //绘制干扰点
            for (int i = 0; i < 80; i++)
            {
                Point p = RandPoint();
                map.SetPixel(p.X, p.Y,RandColor());
            }
            //绘制字符串
            SizeF  StringSizeF= g.MeasureString(VerificationText,f);
            PointF StartPoint = new Point(0,(height-(int)StringSizeF.Height)/2);
            for (int i = 0; i < length; i++)
            {
                brush.Color = RandColor();
                int index = rand.Next(5);
                f=new Font(font[index], 20, FontStyle.Bold);
                StartPoint.X += 5;
                g.DrawString(VerificationText[i].ToString(), f, brush, StartPoint);
                SizeF CharSizeF = g.MeasureString(VerificationText[i].ToString(), f);
                StartPoint.X += CharSizeF.Width;
            }
            g.Dispose();

        }
        //生成随机颜色
        private Color RandColor()
        {
            Color c = Color.FromArgb(rand.Next(1, 256), rand.Next(1, 255), rand.Next(1, 255));
            return c;
        }
        //生成随机点
        private Point RandPoint()
        {
            int x = rand.Next(0, map.Width);
            int y = rand.Next(0, map.Height);
            return new Point(x, y);
        }
        //返回验证码图片
        public Bitmap getImage()
        {
            return map;
        }
        //返回经MD5加密过的验证码字符串
        public string MD5Encrypt()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.UTF8.GetBytes(VerificationText.ToUpper()));//不区分大小写
            return BitConverter.ToString(result);
        }
        //返回校验结果
        public bool Check(string text)
        {
            return text.ToUpper().Equals(VerificationText.ToUpper());//不区分大小写
        }
    }
}
