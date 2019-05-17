using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_11_Перегрузка_операторов
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple1 = new Apple("Red Cherif", 100, 100);
            var apple2 = new Apple("Зеленое", 456, 500);

            var meat1 = new Meat("Свинина", 500, 300);
            var meat2 = new Meat("Говядина", 300, 300);

            var apple3 = Apple.Add(apple1, apple2);
            var apple4 = apple1 + apple3;
            var apple5 = apple4 + 300;


            Console.WriteLine(apple1.ToString());
            Console.WriteLine(apple2.ToString());
            Console.WriteLine(apple3.ToString());
            Console.WriteLine(apple4.ToString());
            Console.WriteLine(apple5.ToString());
            Console.WriteLine();


            Console.WriteLine(meat1.ToString());
            Console.WriteLine(meat2.ToString());




            Console.ReadLine();

        }
    }
}
