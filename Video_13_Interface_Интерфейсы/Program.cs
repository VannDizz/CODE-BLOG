using System;
using System.Collections.Generic;

namespace Video_13_Interface_Интерфейсы
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();

            cars.Add(new Lada());
            cars.Add(new BMW());


            foreach(var car in cars)
            {
                Console.WriteLine(car.Move(200));
            }

            Cyborg cyborg = new Cyborg();
            Console.WriteLine( cyborg.Move(90));



            Console.ReadLine();
        }
    }
}
