using System;

namespace hesap_makinesi_c_sarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string secim;
            double x, y;
            Console.WriteLine("say gir");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("say gir");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("islem sec");
            Console.WriteLine("toplama (t)");
            Console.WriteLine("cıkarma (c)");
            Console.WriteLine("bolme (b)");
            Console.WriteLine("carpma (ç)");
            Console.WriteLine("mod alma (m)");
            secim = Console.ReadLine();
            if(secim == "t")
            {
                double t = x + y;
                Console.WriteLine(t);
            }
            else if (secim == "c")
            {
                double c = x - y;
                Console.WriteLine(c);
            }
            else if (secim == "b")
            {
                double b = x / y;
                Console.WriteLine(b);
            }
            else if (secim == "ç")
            {
                double ç = x * y;
                Console.WriteLine(ç);
            }
            else if (secim == "m")
            {
                double m = x % y;
                Console.WriteLine(m);
            }
            else { Console.WriteLine("yanlıs secim"); }



        }
    }
}
