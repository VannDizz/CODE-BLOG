using System;
using System.IO;
using System.Text;

namespace Video_16_Stream_File
{
    class Program
    {
        public static string text = "Hello World!";
        static void Main(string[] args)
        {
            
            using (var sw = new StreamWriter("test.txt",true, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }

            using(var sr = new StreamReader("test.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var s = sr.ReadLine();
                    Console.WriteLine(s);
                    
                }
                Console.ReadKey();

                //sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                var text = sr.ReadToEnd();
                Console.WriteLine(text);
                Console.ReadLine();
            }


        }
    }
}
