using System;

namespace HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = Convert.ToInt32("Öğrenci sayısını giriniz..");

            for (int i =0; i<n; i++)
            {
                Console.WriteLine($"{i + 1}. öğrenci vizesi");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{i + 1}. öğrenci finali");
                float final = Convert.ToSingle(Console.ReadLine());

                float ortalama = (vize * 0.4f + final * 0.6f);

                Console.WriteLine($"Öğrenci ortalaması = {ortalama}");
            }
             Console.ReadKey();
        }
    }
}
