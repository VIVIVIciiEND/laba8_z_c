using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Base
{
    class Company
    {
        string title; 
        public  Company(string title) => this.title = title;
        public void Print() => Console.WriteLine($"компания {title}");

    }
    class Person
    {
        string name;
        Company company;
        public Person(string name, Company company)
        {
            this.name = name;
            this.company = company;
        }
        public void Print()
        {
            Console.WriteLine($"Имя : {name}");
            company.Print();
         }

    }
}

