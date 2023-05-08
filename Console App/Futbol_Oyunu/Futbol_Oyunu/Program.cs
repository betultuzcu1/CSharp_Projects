using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Futbol> takim= new List<Futbol>();
            takim.Add(new Futbol("Kaleci",1));
            takim.Add(new Defans("Defans1", 2));
            takim.Add(new Defans("Defans2", 3));
            takim.Add(new Defans("Defans3", 4));
            takim.Add(new Defans("Defans4", 5));
            takim.Add(new OrtaSaha("OrtaSaha1", 6));
            takim.Add(new OrtaSaha("OrtaSaha2", 7));
            takim.Add(new OrtaSaha("OrtaSaha3", 8));
            takim.Add(new OrtaSaha("OrtaSaha4", 9));
            takim.Add(new Forvet("Forvet1", 10));
            takim.Add(new Forvet("Forvet2", 11));
            Random Rastgele= new Random();
            int formaNo;
            int pasKontrol=12;
            formaNo = Rastgele.Next(1, 12);
            Boolean golOlabilir = true;
            for (int i = 1; i <= 3; i++)
            {
                while (pasKontrol == formaNo)
                {

                    formaNo = Rastgele.Next(1, 12);
                }
                pasKontrol = formaNo;
                if (!takim[formaNo - 1].PasVer())
                {
                    Console.WriteLine($"{formaNo} numaralı oyuncunun pası başarısız");
                    golOlabilir=false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{formaNo} numaralı oyuncunun pası tam isabet!!!");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine($"{formaNo} numaralı oyuncu kaleci ile karşı karşıya!!!");
            System.Threading.Thread.Sleep(1000);
            if ( golOlabilir ==true) 
            {
                if (takim[formaNo - 1].GolVurusu())
                {
                    Console.WriteLine($"{formaNo} numaralı oyuncu vurdu ve GGGOOOOOOOOOOOOOOOOOLLLLL!!!");
                }
                else 
                {
                    Console.WriteLine($"{formaNo} numaralı oyuncu az farkla kaçırdı");
                }
            }

            Console.ReadLine();
        }
    }
}
