// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
/*
 * Problem: 
 * Uygulama boyunca sadece tek bir instance'ı olması gereken bir sınıf inşa ettiniz. Bu tekliği nasıl sağlarsınız?
 * 
 */

MailSender mailSender = MailSender.CreateMailSender();
mailSender.MailAddress = "sample@address.com";

MailSender mailSender2 = MailSender.CreateMailSender();
Console.WriteLine(mailSender2.MailAddress);