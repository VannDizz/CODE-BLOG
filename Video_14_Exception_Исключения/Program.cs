using System;


namespace Video_14_Exception_Исключения
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var i = 5;
                var j = i / 0;
                Console.WriteLine(j);
                

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }
        }
    }
}
