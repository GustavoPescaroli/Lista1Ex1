using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int h;
            int a;
            //base
            Console.Write("informe a base:");
            b = int.Parse(Console.ReadLine());
            //altura
            Console.Write("informe a altura:");
            h = int.Parse(Console.ReadLine());
            //resultado
            a = b * h;
            Console.WriteLine("valor da area {0}", a);
        }
    }
}
