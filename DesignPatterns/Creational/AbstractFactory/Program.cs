// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Doğrudan; nesnenin bounded context'ini inşa etmeden; spesifik nesneler ile çalışmak istersem bu ihtiyacımı nasıl çözerim?
 *   
 *   
 *   
 *   Senaryo:
 *   Factory Method'da yazdığımız harita uygulaması üzerine; bölgesel veya uydu haritası seçenekleri eklemeye karar verdiniz... 
 */

Map<SatelliteCultureMap> satelliteCulture = new Map<SatelliteCultureMap>();
satelliteCulture.ShowDetails();

Map<RegionalReligionMap> regional = new Map<RegionalReligionMap>();
regional.ShowDetails();

