using System;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

//global using Base;
using MyClasss;
using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Threading.Tasks;
using System.Net.Http;
//Person2 anton = new Person2("Anton");
namespace laba8_z_c
{
    internal class Program
    {
        static async Task Main()
        { 
            //Console.WriteLine("введите url сайта"); 
            //string? url = Console.ReadLine();
            //if (!string.IsNullOrEmpty(url))
            //{
            //    try
            //    {
            //        HttpClient client = new HttpClient();
            //        string html = await client.GetStringAsync(url);
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine("ошибка" + ex.Message);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("URL не может быть пустым");
            //}
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(html);
            //var titleNode = doc.DocumentNode.SelectSingleNode("//title");
            //if (titleNode != null)
            //{
            //    Console.WriteLine($"заголвок страницы {titleNode.InnerText}");
            //}
            //else
            //{
            //    Console.WriteLine("заголовок страницы не найден");
            //}
            //Fruit apple = new() { Name = "яблоко", Quantity = 5 };
            //string json = JsonConvert.SerializeObject(apple);
            //Console.WriteLine($" в json " + json);
            //var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
            //Console.WriteLine($"объект {deserialized?.Name} - {deserialized?.Quantity}");
            //Company microsoft = new("Microsoft");
            //Person tom = new Person("Tom", microsoft);
            //tom.Print();
            //Base.Person tom = new("tom");
            //tom.Print();
            //Person person = new Person();
            //Console.WriteLine(person.Age);
            //person.Age = 37;
            //Console.WriteLine(person.Age);
            //person.Age = -23;
            //Console.WriteLine(person.Age);

            //person.Name = "Ivan";
            //string personName = person.Name;
            //Console.WriteLine(personName);
            //Console.WriteLine(person.Name);
            //person.Name = "bob";
            //person.Age = 37;
            //Console.WriteLine(person.Name);
            //person.Print();
            //var apple = new Product { Name = "яблоко", Price = 10.5m, Quantity = 5 };
            //var banana = new Product { Name = "банан", Price = 7.5m, Quantity = -2 };
            //Console.WriteLine($"{apple.Name}x{apple.Price}={apple.Quantity} руб");
            //Console.WriteLine($"{banana.Name}x{banana.Price}={banana.Quantity} руб");
            //Hero hero = new Hero("Ривен", 120);
            //Console.WriteLine($"имя героя {hero.Name}\nуровень греоя {hero.Level}\n мана {hero.Mana}\nстатус{hero.Status}");
            //hero.TakeDamage(50);
            //hero.Heal(30);
            //hero.TakeDamage(200);
            //hero.Heal(50);
            //Person garen;
            //garen.name = "Гарен";
            //garen.age = 25;
            //garen.Print();
            //Person timo = new Person();
            //timo.Print();
            //Person ahri = new();
            //Person brand = new("brand");
            //Person datius = new("darius",25);
            //ahri.Print();
            //brand.Print();
            //datius.Print();
            //int a = 5;
            //int b = a;
            //b = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Person p1 = new Person();
            //p1.name = "dinara";
            //Person p2 = new Person();
            //p2.name = "diana";
            //Console.WriteLine(p1.name);
            //Console.WriteLine(p2.name);
        }
    }
}
