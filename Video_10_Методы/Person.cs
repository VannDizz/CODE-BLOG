using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_10_Методы
{
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Person (string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;

            X = 0;
            Y = 0;

        }

        public void Hello()
        {
            Console.WriteLine($"Hello {FirstName} {SecondName}");
        }

        public string Run()
        {
            var rnd = new Random();
            X += rnd.Next(100);
            Y += rnd.Next(100);


            return $"{FirstName} ({X}) ({Y})";
        }

        public string Run(int x, int y)
        {
            X += x;
            Y += y;
            return $"{FirstName} ({X}) ({Y})";
        }



    }
}
