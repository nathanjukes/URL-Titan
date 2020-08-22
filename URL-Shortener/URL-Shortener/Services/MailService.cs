using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using URL_Shortener.Models;

namespace URL_Shortener.Services
{
    public class MailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendMail(ContactMeModel contactModel)
        {
            string[] credentials = new string[]
            {
                _configuration.GetValue<string>("MailCredentials:0"),
                _configuration.GetValue<string>("MailCredentials:1")
            }; //0 / 1 for credentials

            //Setting up MailAddress'
            MailAddress sender = new MailAddress(credentials[0]);
            MailAddress receiver = new MailAddress("njukesuniversity@gmail.com");

            //Setting up MailMessage
            MailMessage message = new MailMessage(sender, receiver);
            message.Subject = $"Message from URL-Titan - Subject: {contactModel.Subject}";
            message.Body = $"Name: {contactModel.Name}\nEmail: {contactModel.Email}\n\nSubject: {contactModel.Subject}\n\nMessage: {contactModel.Message}\n\n\n\n\n\nThis email was sent from URL-Titan";

            //Setting up SMTP Client 
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(credentials[0], credentials[1]);
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(message);
            }
            catch (Exception e)
            { }
        }
    }
}
