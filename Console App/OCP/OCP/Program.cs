using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Digdörtgen alan hesabı
            try
            {
                Console.Write("Lütfen uzun kenar ölçüsünü giriniz:");
                double widht=double.Parse(Console.ReadLine());
                Console.Write("Lütfen kısa kenar ölçüsünü giriniz:");
                double height = double.Parse(Console.ReadLine());

                Regtangle regtangle=new Regtangle(widht,height);
                Console.WriteLine(regtangle.Area());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Kare alan hesabı
            try
            {
                Console.Write("Lütfen bir kenarın ölçüsünü giriniz:");
                double edge = double.Parse(Console.ReadLine());

                Square square = new Square(edge);
                Console.WriteLine(square.Area());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}
