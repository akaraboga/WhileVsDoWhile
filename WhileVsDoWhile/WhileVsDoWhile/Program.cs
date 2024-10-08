using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileVsDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*

        Console.WriteLine("Bir limit giriniz"); //Kullanıcıdan kaça tane tekrar etmek istiyorsa limit değişkeni ile alıyoruz
        int limit = Convert.ToInt32(Console.ReadLine());

        int sayaç = 1;//dögünün içinde artıracağımız sayacımız



            while (sayaç <= limit) //Sayaç değişkeni limit değikenine eşit olana kadar çalışacak
            {
                Console.WriteLine(sayaç+"-Ben bir patikalıyım");

                sayaç++;
            }


             */





            Console.WriteLine("Bir limit giriniz");
            int limit = Convert.ToInt32(Console.ReadLine());

            int sayaç = 1;


            do//Yukardakinin aynısını do while kısmına uyguladık.Burda değer yanlış bile olsa bi kereliğine de olsa çalışır.ornek limite -1 girip deneyebilirsiniz.
            {

                Console.WriteLine(sayaç + "-Ben bir patikalıyım");

                sayaç++;

            } while (sayaç <= limit);

            //Yukarda da yaptığımız gibi do-while ile while ın mantığı hemen hemen aynı da olsa en büyük fark;whilde parantez içine yazdığımız koşul yanlış olunca programı sonlandırması,do while da ise bi kerede olsa çalıştırması.



            Console.ReadLine();
        }
    }
}
