using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Footwear
    {
        
        public string Prod
        {
            get { return this.Prod; }
            set { this.Prod = value; }
        }
      
        public double Size 
        {
            get { return this.Size; }
            set { this.Size = value; }
        }
       
        public double Price
        {
            get { return this.Price; }
            set { this.Price= value; }
        }

     
        public void Writing()
        {                
                Console.WriteLine("Введите производителя");
                Prod = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите размер");
                Size = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите цену");
                Price = Convert.ToDouble(Console.ReadLine());         
        }

        public override string ToString()
        {
            return "Производитель" + this.Prod + "Размер" + this.Size + "Цена" + this.Price;
        }
    } 
    }
