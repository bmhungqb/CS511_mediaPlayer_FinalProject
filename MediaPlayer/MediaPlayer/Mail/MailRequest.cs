using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace MediaPlayer.Mail
{
    public class MailRequest
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
            mail.Subject = "ACCOUNT REGISTRATION CONFIRMATION";
            mail.Body = $"Hi {name}, <br/> Thank you for registering an account with ZingMedia. <br/> Please enter the verification code to complete the registration: <br/> Code: <b>{code}</b> <br/> Wishing you a great day <3";
            smtp.Send(mail);
        }
    }
}
