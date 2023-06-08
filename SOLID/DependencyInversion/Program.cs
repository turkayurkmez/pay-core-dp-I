// See https://aka.ms/new-console-template for more information

using DependencyInversion;

TelegramSender telegramSender = new TelegramSender();
Report report = new Report(telegramSender);
report.SendReport("abx");
Console.WriteLine("Hello, World!");
