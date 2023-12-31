﻿using System.Net.Mail;

namespace NewCenterCursos.Api
{
    public class ConfigEmail
    {
        public string GetItemLabelValueEmail(string label, string value)
        {
            return $"<b style='font-size:18px'>{label}: </b><span style='font-size:15px;font-weight:normal'>{value}</span><br>";
        }

        public string GetBodyEmail(string Subject, string ItensBody)
        {
            return "<div style='text-align:center'><div style='max-width: 600px; margin: 0 auto;'>" +
                      $"<h2>{Subject}<h2><br>" +
                      $"<div style='text-align:left;word-wrap: break-word'>{ItensBody}</div><br /></div>";
        }

        public bool EmailEnviado(string emailDestino, string subject, string body, string tituloErro)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.hostinger.com");


                mail.From = new MailAddress("newcentercursos@andersondomingos.eti.br");
                mail.To.Add(new MailAddress("newcentercursos.pho@gmail.com"));
                mail.CC.Add(new MailAddress("anderson.ferdomingos@gmail.com"));
                mail.ReplyToList.Add(new MailAddress(emailDestino));
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = false;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("cadastro@unieja.com.br", "Unieja@22");

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
