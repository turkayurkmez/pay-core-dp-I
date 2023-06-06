// See https://aka.ms/new-console-template for more information

using InheritanceAndPolymorphism;

Kofte kofte = new Kofte();
TazeFasulye tazeFasulye = new TazeFasulye();
Baklava baklava = new Baklava();

Asci asci = new Asci();
asci.Pisir(tazeFasulye);
asci.Pisir(kofte);

asci.Pisir(baklava);

Console.WriteLine("Hello, World!");
