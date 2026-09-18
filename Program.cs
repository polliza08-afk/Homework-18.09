// See https://aka.ms/new-console-template for more information
using MyStaticClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("-- Тестування класу Laptop --");

Laptop defaultLaptop = new Laptop();
Console.WriteLine("Ноутбук за замовчуванням: " + defaultLaptop);

Laptop gamingLaptop = new Laptop("Asus ROG", 240, 500, 2);
Console.WriteLine("Ігровий ноутбук: " + gamingLaptop);

// Перевіряє обмежень
Laptop customLaptop = new Laptop();
customLaptop.Model = "Custom Beast";
customLaptop.ScreenRefreshRate = 600; //Спрацює перевірка (> 500)
customLaptop.Brightness = 1200;       //Спрацює перевірка (> 1000)
customLaptop.SsdSize = 16;             //Спрацює перевірка (> 8)

Console.WriteLine("\nЗагальна кількість створених ноутбуків = " + Laptop.GetCountItems());
