using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjectForDotNet
{
    internal class Program
    {
        void Add()
        {
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine("Addition is: " + c);
        }
          void Sub()
        {
            int a = 10, b = 20, c;
            c = a - b;
            Console.WriteLine("Substration is: " + c);
        }

        void Mul()
        {
            int a = 10, b = 20, c;
            c = a * b;
            Console.WriteLine("Multiplication is: " + c);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Add();
            p.Sub();
        }
    }
}
