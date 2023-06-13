// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");
/*
 * Problem: oluşması uzun süren veya aynı tipte veriden çok fazla kullanan bir nesnemiz olsun. Aynı sınıftan birkaç adet nesneye ihtiyacım olursa, bu oluşturma (constructor) maliyetini nasıl en aza indirebiliriz?
 * 
 * 
 */
string word = "sample";
string another = (string)word.Clone();
another = another.Replace("s", "ex");
Console.WriteLine(another);

string[] words = new[] { "A", "B", "C" };
var wordsClone = (string[])words.Clone();
wordsClone[1] = "D";

wordsClone.ToList().ForEach(w => Console.WriteLine(w));

Color black = new Color();
var red = (Color)black.Clone();
red.R = 255;
var green = (Color)black.Clone();
green.G = 255;
var blue = (Color)black.Clone();
blue.B = 255;
var white = (Color)black.Clone();

white.R = 255;
white.G = 255;
white.B = 255;

Console.WriteLine(black);
Console.WriteLine(white);
Console.WriteLine(red);
Console.WriteLine(green);
Console.WriteLine(blue);
