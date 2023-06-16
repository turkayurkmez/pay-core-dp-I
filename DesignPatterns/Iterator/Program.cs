// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bellekte bulunan bir koleksiyon içerisinde hareket etmeniz gerekiyor. Yani tek tek dönebilir belirli bir konuma gidebilir ileri ya da geri ilerleyebilirsiniz.
 *   
 */
Iterator<News> newsGallery = new Iterator<News>()
{
    new(){ Title ="Güzel haber"},
    new(){ Title ="Türk Fizikçi nobele aday"},
    new(){ Title ="Türkiye Milli takımı....."},
};

var second = newsGallery.Next();
Console.WriteLine(second.Title);
Console.WriteLine(newsGallery.First().Title);
Console.WriteLine(newsGallery.Last().Title);

