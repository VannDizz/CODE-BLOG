using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_5_Коллекции
{
    class Video5
    {
        static void Main(string[] args)
        {
            //Объявление одномерного массива с десятью переменными
            int[] array1 = new int[10];
            array1[0] = 1;
            array1[9] = 5;

            int[,] array2 = new int[10, 10];

            //Создание пустого списка
            List<string> day = new List<string>();
            //Добавление значений
            day.Add("One");
            day.Add("Too");
            day.Add("Tri");



            Console.WriteLine(day.ToString());
            Console.ReadKey();
        }
    }
}
