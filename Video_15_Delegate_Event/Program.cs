using System;


namespace Video_15_Delegate_Event
{
    /// <summary>
    /// Самый первый делегат
    /// </summary>
    public delegate void MyDelegate();

    

    class Program
    {
        static void Main(string[] args)
        {
            #region delegate
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;

            //myDelegate();
            #endregion

            var pers = new Person
            {
                Name = "Vasia"
            };

            pers.GoToSleep += Pers_GoToSleep;
            pers.DoWork += Pers_DoWork;

            pers.TakeTime(DateTime.Parse("13.05.2019 10:10:10"));
            pers.TakeTime(DateTime.Parse("13.05.2019 07:10:10"));

            Console.ReadLine();

        }

        private static void Pers_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} Пошел работать");
            }
        }

        private static void Pers_GoToSleep()
        {
            Console.WriteLine($" Пошёл спать");
        }

        #region metods
        //public static void Method1()
        //{
        //    Console.WriteLine("Method1");
        //}

        //public static int Method2()
        //{
        //    Console.WriteLine("Method2");
        //    return 0;
        //}

        //public static int Method3(int i)
        //{
        //    Console.WriteLine("Method3");
        //    return i;
        //}

        //public static void Method4()
        //{
        //    Console.WriteLine("Method4");
        //}
        #endregion
    }
}
