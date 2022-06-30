using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıGirisİşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kadı = "admin", ksifre = "123";
            string kullaniciad, kullanicisifre;
            int hak = 3;
            do
            {
                Console.WriteLine("Kullsnıcı adını giriniz");
                kullaniciad = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz");
                kullanicisifre = Console.ReadLine();

                if (kullaniciad == kadı && kullanicisifre == ksifre)
                {
                    Console.WriteLine("HOŞGELDİNİZ");
                }
                else
                {
                    hak--;
                    if (hak == 0)
                    {
                        Console.Write("Üç defa doğru Kullanıcı adı ve Şifre giremediniz !");
                    }
                }
            } while ((kullaniciad!= kadı || kullanicisifre!= ksifre)&& hak!= 0);

            Console.ReadLine();
        }

    }
}
