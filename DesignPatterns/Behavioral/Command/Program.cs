// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *    Uygulamanızda aynı işi (komut) birden fazla yöntemle yapmanız gerekiyor. Her bir komutu yöntemden nasıl izole edersiniz?
 *    
 *  Komutları kullanıcı arayüzü veya client object'den bağımsız hale getirmek.  
 */
CommandInvoker commandInvoker = new CommandInvoker();
commandInvoker.AddCommand(new CreateCustomerCommand());

DBCommandReceiver commandReceiver = new DBCommandReceiver();

commandInvoker.AddCommand(new CreateOrderAndUpdateStockCommand(commandReceiver, "Türkay", "deneme"));
commandInvoker.ExecuteAll();

