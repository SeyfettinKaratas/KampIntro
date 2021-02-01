using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrayy
            string[] kurslar = new string[] { "yazılım kursu", "program kursu", "java","c++","c#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



        }
    }
}
