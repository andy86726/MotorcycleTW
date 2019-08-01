using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MotorcycleTW.Models;
namespace MotorcycleTW.Severce
{
    public class MailService
    {
        public void MailService_1(string email,string code)
        {
            System.Net.Mail.MailMessage MyMail = new System.Net.Mail.MailMessage();//建立MAIL   
            MyMail.From = new System.Net.Mail.MailAddress("motorcycle95@gmail.com", "MotorcycleTW");//寄信人(From)
            MyMail.To.Add(new System.Net.Mail.MailAddress(email));//收信人1(To) 
            MyMail.Subject = "Welcome to Guru. Please verify your account to become Guru's member.";//主題   
            MyMail.Body = "Hello,\n\n Thank you for your registration\n\n This is your account verification code \n\n" + code + "\n\n Best Regards,\n\n";//內容 
                                                                                                                                                         //SmtpClient將信件發送出去，參考文獻(https://aspnetmars.blogspot.com/2017/05/email-send-c-smtpclient.html)
                                                                                                                                                         //SmtpClient的參考文獻(https://docs.microsoft.com/zh-tw/dotnet/api/system.net.mail.smtpclient?view=netframework-4.8)
            System.Net.Mail.SmtpClient Client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);//GMAIL主機   
                                                                                                      //System.Net.Mail.SmtpClient Client = new System.Net.Mail.SmtpClient("msa.hinet.net");//hinet主機   
            Client.Credentials = new System.Net.NetworkCredential("gash86726@gmail.com", "gash7525199786726");//帳密，Hinet不用但須在它的ADLS(區段)裡面   
            Client.EnableSsl = true;//Gmail需啟動SSL，Hinet不用   
            Client.Send(MyMail);//寄出
        }
        
    }
   
}