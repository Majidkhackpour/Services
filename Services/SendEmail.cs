using System;
using System.Net;
using System.Net.Mail;

namespace Services
{
    public class SendEmail
    {
        public static bool Send(string to, string subject, string body, string sender = "", string password = "")
        {
            try
            {
                if (string.IsNullOrEmpty(sender))
                {
                    sender = "aradenj2211@gmail.com";
                    password = "09382420272";
                }
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(sender, "گروه مهندسی آراد");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                //mail.IsBodyHtml = true;

                //System.Net.Mail.Attachment attachment;
                // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
                // mail.Attachments.Add(attachment);

                smtpServer.EnableSsl = true;
                smtpServer.UseDefaultCredentials = true;
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(sender, password);


                smtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return false;
            }
        }
    }
}
