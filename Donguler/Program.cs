using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] 
            { 
                "Yazılım Geliştirici Kampı" , 
                "Temel Başlangıç Kursu",
                "Java Kursu",
                "Python Kursu",
                "C# .Net Core"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-------------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-------------");
        }
    }
}
