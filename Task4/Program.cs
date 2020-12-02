using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Task4
{
    class pr {
        public int a1 = Convert.ToInt32(Console.ReadLine());
        public int a2 = Convert.ToInt32(Console.ReadLine());
        public int b1 = Convert.ToInt32(Console.ReadLine());
        public int b2 = Convert.ToInt32(Console.ReadLine());
        public int c1 = Convert.ToInt32(Console.ReadLine());
        public int c2 = Convert.ToInt32(Console.ReadLine());
        public int d1 = Convert.ToInt32(Console.ReadLine());
        public int d2 = Convert.ToInt32(Console.ReadLine());

        public int C2 { get => c2; set => c2 = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pr A = new pr();
            int k = ((A.a1 - A.b1)*(A.a1 - A.b1)+(A.a2 - A.b2)*(A.a2 - A.b2));
            double k1 = Convert.ToDouble(Math.Sqrt(k));
            int l = ((A.b1 - A.c1) * (A.b1 - A.c1) + (A.b2 - A.c2) * (A.b2 - A.c2));
            double l1 = Convert.ToDouble(Math.Sqrt(l));
            double S = k1 * l1;
            double r = k1 * k1 + l1 * l1;
            double R = Convert.ToDouble(Math.Sqrt(r));
            Console.WriteLine("Площа прямокутника= " + S);
            Console.WriteLine("\nРадіус описаного кола= " + R);

        }
    }
}
