using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Footwear
    {
        public Footwear(string prod, float size, double price) 
        {
            prod=prod;
            size=size;
            price=price;
        }
        public string prod {
            get; set;
        }
        public float size {
            get; set;
        }
        public double price {
            get; set;
        }
    }
        
    }
}
