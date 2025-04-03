using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common_Test.Tools 
{
    //Mail : testemail3172@gmail.com
    //sifresi : rvzhpxwpegickwtq
    public static class MailSender
    {
        //Mail'inizi baska projeler üzerinden kullanılarak mail gönderme sisteminde aktifleştirmek icin önce o Mail'e girin

        //Manage your Google Account'a girin
        //Security'i secin
        //Karsınıza Signing in to Goolge kısmında 2-Step Verification Cıkacak
        //Alt tarafta Application Password'ler var orada generate secenegini secin
        //Cıkan sifreyi bosluk olmadan sisteminize entegre edin

        public static void Send(string receiver, string password = "rvzhpxwpegickwtq", string body = "Test mesajıdır", string subject = "Email Testi", string sender = "testemail3172@gmail.com")
        {

            MailAddress senderEmail = new(sender); //Gonderen kesim (biz)
            MailAddress receiverEmail = new(receiver); //Alan kesim (Kullanıcı)

            //Bizim Email işlemlerimiz SMTP'ye göre yapılır.

            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };



            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }





        }

    }
}
