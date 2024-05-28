using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "bai 5";
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
        for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine("Tổng s = " + sum);
            Console.ReadLine();
        }
    }
}
