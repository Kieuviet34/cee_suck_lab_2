using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "bai 3";
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("Tổng s = " + sum);
            Console.ReadLine();
        }
    }
}
