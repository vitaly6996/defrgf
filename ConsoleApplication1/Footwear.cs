using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Footwear
    {

        public string Prod { get; set; }


        public double Size { get; set; }

        public double Price { get; set; }


        public Footwear()
        {
            this.Prod = Prod;
            this.Size = Size;
            this.Price = Price;

        }
        public void Writing()
        {      
                
                Console.WriteLine("Введите производителя");
                this.Prod = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите размер");
                this.Size = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите цену");
                this.Price = Convert.ToDouble(Console.ReadLine());
                
        }

        public override string ToString()
        {
            return "Производитель - " + this.Prod + " Размер - " + this.Size + " Цена - " + this.Price;
        }
    } 
    }
