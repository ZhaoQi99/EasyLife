using CCWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyLife.Send
{
    class SendMail
    {
        public string host { get; set; }//服务器地址
        public int port { get; set; }//服务器端口号
        public string mailfrom { get; set; } = string.Empty;//发件人地址
        public string fromwho { get; set; } = string.Empty;//发件人姓名

        private string password = string.Empty;//发件人密码
        private SmtpClient smtp;

        public SendMail(string mailfrom, string password, string fromwho, string host, int port = 25, bool enablessl = true)
        {
            //163邮箱使用25端口,EnableSsl属性设置为false/true
            //QQ邮箱使用25端口,EnableSsl属性设置为true
            smtp = new SmtpClient(host, port);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = enablessl;//是否使用SSL加密连接
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;//指定邮件发送方式
            smtp.Credentials = new System.Net.NetworkCredential(mailfrom, password);
            this.host = host;
            this.port = port;
            this.mailfrom = mailfrom;
            this.password = password;
            this.fromwho = fromwho;
        }
        //发送邮件
        public int send(string mailto, string subject, string body, string Priority)
        {
            int status = 0;//邮件发送结果

            string[] address = mailto.Split(',');//收件人地址列表
            MailMessage msg = new MailMessage();//邮件信息
            try
            {
                msg.From = new MailAddress(mailfrom, fromwho, Encoding.UTF8);
                msg.Subject = subject;//邮件标题
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = body;//邮件正文
                msg.BodyEncoding = Encoding.UTF8;

                //邮件优先级
                if (Priority == "高")
                    msg.Priority = MailPriority.High;
                else if (Priority == "低")
                    msg.Priority = MailPriority.Low;
                else
                    msg.Priority = MailPriority.Normal;
                for (int i = 0; i < address.Length; i++)
                    msg.To.Add(address[i]);

                smtp.Send(msg);
                status++;
                msg.Dispose();
            }
            catch (Exception e)
            {
                //Todo:handle Exception
                MessageBoxEx.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return status;
            }
            return status;
        }
    }
}
