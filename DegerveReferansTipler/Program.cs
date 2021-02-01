using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            Console.WriteLine(sayı1);

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 333;
            Console.WriteLine(sayılar1[0]);
            Console.WriteLine(sayılar2[0]);
        }
    }
}
