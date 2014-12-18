using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.name = "Mouse";
            item1.unitPrice = 400;
            item1.discountAmount = 30;

            string item1Name = item1.name;
            double item1Price = item1.unitPrice;

            Console.WriteLine(item1Name+ " : " +item1Price);
            
           

            Item item2 = new Item();
            item2.name = "Keyboard";
            item2.unitPrice = 300;
            item2.discountAmount = 20;

            string item2Name = item2.name;
            double item2Price = item2.unitPrice;

            Console.WriteLine(item2Name + " : " + item2Price);

            Console.ReadLine();
        }
    }
}
