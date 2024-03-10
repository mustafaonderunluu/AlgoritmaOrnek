using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele Harf Üretme 

            Random rnd = new Random();
            String Harfler = "qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string üret = " ";
            for (int i = 0; i <= 10; i++)
            {

                üret += Harfler[rnd.Next(Harfler.Length)];

            }
            Console.WriteLine(üret);
        
            // İsimleri Tersten Yazdırma 

            string[] isimler = { "Önder,Erdem,Deniz,Cengiz,Ufuk,Umut" };
            int son = isimler.Length-1;
            for (int i = son; i >= 0; --i) {

                Console.WriteLine(isimler[i]);

            }
            Console.ReadLine();














        }
    }
}
