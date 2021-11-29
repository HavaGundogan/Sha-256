using System;
using System.Threading;

namespace Sifreleme
{
    class Program
    {
        static string sifrelenmisMetin;
        static Thread iplik;
        static void Main(string[] args)
        {
            Console.Write("Lütfen Şifrenizi Giriniz: ");
            var metin = Console.ReadLine();
            sifrelenmisMetin = SHASifreleme.SHA_512_Encrypting(metin);
            Console.WriteLine("Şifrenizin Şifrelenmiş Metini: " + sifrelenmisMetin);
            Console.WriteLine("\n*****************Şifremizi Kontrol Etmeye Başlıyoruz**********************\n");
            iplik = new Thread(girisler);
            iplik.Start();
        }

        public static void girisler()
        {
            while (true)
            {
                Thread.Sleep(10);
                Tekrarlama();
            }
        }

        public static void Tekrarlama()
        {
            Console.Write("Şifre: ");
            var giris = Console.ReadLine();
            var girisEncrypt = SHASifreleme.SHA_512_Encrypting(giris);
            if (girisEncrypt == sifrelenmisMetin)
                Console.WriteLine("Şifreyi Doğru Girdiniz");
            else
                Console.WriteLine("Yanlış Şifre");

        }

    }
}
