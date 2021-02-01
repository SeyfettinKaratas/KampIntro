using System;

public string MyKursAdı { get; set; }
public string Egıtmen { get; set; }
public int IzlenmeOranı { get; set; }

namespace ClassIntro
{ 
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "seyfo";
            int yas = 26;
            kurs kurs1 = new kurs();
            kurs1.MyKursAdı = "c#";
            kurs1.Egıtmen = "seyfo";
            kurs1.IzlenmeOranı = 75;

            kurs kurs2 = new kurs();
            kurs2.MyKursAdı = "c++";
            kurs2.Egıtmen = "seyfo";
            kurs2.IzlenmeOranı = 35;

            kurs kurs3 = new kurs();
            kurs3.MyKursAdı = "html5";
            kurs3.Egıtmen = "seyfo";
            kurs3.IzlenmeOranı = 95;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.MyKursAdı);
                Console.WriteLine(kurs.MyKursAdı + " : " + kurs.Egıtmen);

            }




        }
    }



