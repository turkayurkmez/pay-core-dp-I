// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Aynı amaç ile kullandığınız iki farklı nesneniz var (fonksiyonel olarak benzer işler yapıyorlar fakat farklı biçimleri var). Bu iki nesneyle de çalışmanız gerekiyor. Nasıl hareket edersiniz.
 * 
 * Senaryo:
 *  İki farkli API'den döviz kurları çekiyoruz birisi JSON diğeri XML döndürüyor. Her ikisinden gelen veriyi okuyup parse edip ekranda göstermek istiyorsunuz.....
 */
CurrencyAdaptee currencyAdaptee = new CurrencyAdaptee();
currencyAdaptee.GetCurrencies(new XMLServiceProvider()).ForEach(c => Console.WriteLine(c.FromProvider));
currencyAdaptee.GetCurrencies(new JsonServiceProvider()).ForEach(c => Console.WriteLine(c.FromProvider));

