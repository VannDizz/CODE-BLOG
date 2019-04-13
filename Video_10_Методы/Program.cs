using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_10_Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan", "Ivanov");
            Person p2 = new Person("Oleg", "Petrov");
            p1.Hello();
            p2.Hello();

            for (var i = 0; i < 10; i++)
            {
                var s = p1.Run();
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        public static int PrintHello(string name)
        {
            Console.WriteLine($"Привет, {name}!");


            return 1;
        }

    }
}
