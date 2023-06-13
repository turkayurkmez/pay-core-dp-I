// See https://aka.ms/new-console-template for more information
using Decorator;
using System.Net.Sockets;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Önceden oluşturduğunuz bir nesneye hiç dokunmadan run-time'da; yeni bir özellik (ya da fonkiyon) eklemek istiyorsunuz. Bunu nasıl yaparsınız?
 *   
 *   Karamel şuruplu  Latte   
 *   
 *   Kahve sınıfından miras alır mı?
 *   
 *   
 * 
 */

MemoryStream memoryStream;
FileStream fileStream = null;
NetworkStream networkStream = null;

//GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Decompress);
//CryptoStream cryptoStream = new CryptoStream(gZipStream, null, CryptoStreamMode.Write);


Newsletter newsletter = new Newsletter();
SignedMail signedMail = new SignedMail(newsletter, "Türkay Ü");
signedMail.IsSigned = true;
CryptoMail cryptoMail = new CryptoMail(signedMail);

cryptoMail.Send();