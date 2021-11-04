using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000SayiyiSiralayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] sayilar = new int[1000];
            int temp;
            for (int i = 0; i < 1000; i++)
            {
                sayilar[i] = rnd.Next(0, 10000);
            }
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    for (int j = i+1; j < sayilar.Length; j++)
            //    {
            //        if (sayilar[i]>sayilar[j])
            //        {
            //            temp = sayilar[i];
            //            sayilar[i] = sayilar[j];
            //            sayilar[j] = temp;
            //        }
            //    }
            //}

            //Bubble Sort ile
            int n = sayilar.Length-1;
            
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        temp = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = temp;
                    }
                    
                }
                
            }
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }
    }
}
