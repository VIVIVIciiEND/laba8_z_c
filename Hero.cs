using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8_z_c
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Mana {  get; set; }
        public int Level { get; set; }
        private int _health;
        private int _maxHealth;
        public Hero( string name , int maxHelth)
        {
            Name = name;
            _maxHealth = maxHelth;
            _health = maxHelth;
            Mana = 100;
            Level = 1;
        }
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else 
                    _health = value;
            }
        }
        //public string Status
        //{
        //    get
        //    {
        //        if (_health > 0) return "жив";
        //        else return "погиб";
        //    }
        //}
        public string Status => _health > 0 ? "жив" : "погиб";
        public void TakeDamage(int damage)
        {
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} уже погиб и не может получать урон");
               return;
            }
            Health -= damage;
            Console.WriteLine($"{Name} получает {damage} урона hp  {Health}статус{Status}");
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} погиб");
            }
        }
        public void Heal(int amount)
        {
            if (_health <= 0) 
            {
                Console.WriteLine($"{Name} не может быть исцелен тк он погиб");
                return;
            }
            Health += amount;
            Console.WriteLine($"{Name} исцелен на {amount} hp {Health} статус {Status}");
        }
    }
}
