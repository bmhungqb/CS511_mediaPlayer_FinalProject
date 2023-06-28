using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.Mail
{
    public class GetPassword
    {
        public void handleSendCode(string gmail, string name, string code)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("bmhung17903@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "oufskirzzlnecpap");
            smtp.Host = "smtp.gmail.com";
            //recipient
            mail.To.Add(new MailAddress(gmail));
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Subject = "GET PASSWORD";
            mail.Body = $"Hi {name}, <br/> This is your password. <br/> Please do not share this message with anyone. <br/> Password: <b>{code}</b> <br/> Wishing you a great day.";
            smtp.Send(mail);
        }
    }
}
