/// doğru bilgiler girilene kadar kullanıcı bilgilerin isteme 

using System.Reflection.Metadata.Ecma335;

namespace ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Kullanıcı adı giriniz:");
                String a = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Şifrenizi giriniz:");
                String b = Convert.ToString(Console.ReadLine());

                if (a == "admin" && b == "123")
                {
                    Console.WriteLine("Hoşgeldiniz...");
                    return;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş yaptınız...");
                    continue;
                }
            }
            Console.WriteLine("3 Kere hatalı giriş yaptığınız için hesabınız bloke olmuştur.....");













        }
    }
}