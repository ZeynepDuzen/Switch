using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayi giriniz : ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayiyi girin :");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlem türünü girin : + , -, *, / ");
            string islem = Console.ReadLine();
            double islemSonucu = Hesapla(sayi1, sayi2, islem);
            Console.WriteLine("İslem sonucu : " + islemSonucu);

            Console.Read();
        }
            
           static double Hesapla(double sayi1, double sayi2, string islem)
            {
                double sonuc = 0;
                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        break;
                    default:
                        Console.WriteLine("Gecersiz islem");
                        break;
                }

                return sonuc;
            }
        }
    }

