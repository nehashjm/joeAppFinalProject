using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int quantity { get; set; }

        public string GetName()
        {
            return $"Pizza:{Name}";
        }
        public string GetPrice()
        {
            return $"Pizza:{Price}";
        }
        public string GetQuantity()
        {
            return $"Pizza:{quantity}";
        }
    }
}
