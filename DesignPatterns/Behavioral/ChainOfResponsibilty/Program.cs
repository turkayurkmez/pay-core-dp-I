// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilty;

Console.WriteLine("Hello, World!");
/*
 * Problem: 
 * Yönetici admin paneli senaryosunda aşağıdaki işlemleri gerçekleştireceksiniz.
 * 1. Authanticate 
 * 2. Authorize
 * 3. Validation -> Bir hata olursa, işlem iptal.
 * 4. Cache
 * 5. Logging -> Exception Handling
 * 
 *   Senaryo:
 *   Bir toplantı organizasyonu yapılacak; her ülkenin salonları ayrı db'de olsun. Rezervasyon akışında
 *     1. Rezervasyon sahibi denetlenecek
 *     2.   "         tarihi  "
 *     3. Talep edilen katılımcı ve bu salonun kapasitesi 
 *     
 *     4. Uygunsa ilgili db'ye gidilecek
 *   
 * 
 * 
 */

Reservation reservation = new Reservation { Owner = "türkay", CheckIn = DateTime.Now.AddDays(25), CheckOut = DateTime.Now.AddDays(20) };


CheckOwnerResponsible checkOwnerResponsible = new CheckOwnerResponsible();
CheckInAndOut checkInAndOut = new CheckInAndOut();
CompletedToDb completedToDb = new CompletedToDb();

checkOwnerResponsible.Next = checkInAndOut;
checkInAndOut.Next = completedToDb;

checkOwnerResponsible.Handler(reservation);





