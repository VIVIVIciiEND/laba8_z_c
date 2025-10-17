using System.Runtime.InteropServices;

namespace laba8_z_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
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
            Person p1 = new Person();
            p1.name = "dinara";
            Person p2 = new Person();
            p2.name = "diana";
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
        }
    }
}

