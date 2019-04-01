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
            //МАССИВЫ ------------------------------------------------
            //Объявление одномерного массива 
            int[] numbers = { -9, -8, -7 ,- 6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5,6, 7, 8, 9 };
            
            // Перебор foreach -------------------------------------------
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int n = numbers.Length;
            int k = n / 2;
            int temp;

            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;

            }




            //Перебор FORом-----------------------------------------------
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i]);
            //}


            //Перебор foreach -------------------------------------------
            foreach (int i in numbers)
                {
                    Console.Write(i + " ");
                }




            // СПИСКИ --------------------------------------------------------
            //Создание пустого списка
            List<string> day = new List<string>();
            //Добавление значений
            day.Add("One");
            day.Add("Too");
            day.Add("Tri");



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
