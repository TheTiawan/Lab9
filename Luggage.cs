using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    struct Luggage
    {
        public Luggage(int quantity, double weight)
        {
            Quantity = quantity;
            Weight = weight;
        }

        public int Quantity { get; set; }

        public double Weight { get; set; }
    }
}
