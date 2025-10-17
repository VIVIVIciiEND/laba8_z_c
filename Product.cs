using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8_z_c
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    _quantity = 0;
                else
                    _quantity = value;
            }
        }
        public decimal TotalPrice
        {
            get { return Price * Quantity; }
        }
    }
}
