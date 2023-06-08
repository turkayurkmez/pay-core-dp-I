// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bir nesne; başka nesneler ile (dependency) varolmak zorundaysa, bunu istemciden bağımsız olacak biçimde nasıl yönetirsiniz?
 *   
 *   Sniper nisanci = new Sniper();
 *   
 *   Senaryo:
 *   
 *   Bir turistik harita yapmak istiyoruz. Turist, görmek istediği türü seçtikten sonra bu türdeki ziyaret noktaları haritada gözüksün istiyoruz.
 *    Örnek: Turist, kültürel ziyaret noktalarını isterse; bulunduğu bölgedeki
 *        * Müze
 *        * Sergi salonu
 *        * Mimari Eserler
 *   
 *   KulturHarita kultur = new KulturHarita();
 *   kultur.ZiyaretNoktalari // işte bu koleksiyonu dolu bir biçimde gelecek!
 */

CultureMap cultureMap = new CultureMap();
cultureMap.VisitPoints.ForEach(vp => Console.WriteLine($"{vp.Title}"));

ReligionMap religionMap = new ReligionMap();
religionMap.VisitPoints.ForEach(vp => Console.WriteLine($"{vp.Title}"));
