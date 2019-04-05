using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_8_ООП
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Yuriy";
            p1.LastName = "Klobukov";


            Person p2 = new Person();
            p2.FirstName = "Lelik";
            p2.LastName = "Tyavin";

            Doctor p3 = new Doctor();
            p3.Profil = "Terapevt";

            var p4 = new Intern();
            p4.Sostoyanie = "Ebushun";


            Console.WriteLine(p3.Profil);
            Console.ReadKey();


        }
    }
}
