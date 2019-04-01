using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_4_Приведение_типов
{
    class Video4
    {
        static void Main(string[] args)
        {
            string UserName;        //Верхняя верблюжья нотация или Паскаль нотация
            string userName = "123";        //Нижняя верблюжья нотация
            string user_name;       //Змеиная нотация
            string USER_NAME ="";       //Толстая змеиная нотация
            // string user-name;    //Шашлычная нотация
            string sUserName;       //Венгерская нотация


            bool b = true;
            user_name = Convert.ToString( b);

            

            //userName = "Hoock";
            Console.WriteLine(user_name);
            Console.ReadKey();

            

            if (int.TryParse(userName, out int result))
            {
                Console.WriteLine(result);
                USER_NAME = Console.ReadLine();
                Console.WriteLine(USER_NAME);
                Console.ReadKey();
            }

            
        }
    }
}
