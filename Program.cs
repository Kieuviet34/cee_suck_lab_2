using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "bai 1";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập 1 số(1-7): ");
            int so = int.Parse(Console.ReadLine());
            string[] dayweek = {"monday", "tuesday", "wednesday",
            "thursday","friday","saturday","sunday"};
            if(so >= 1 && so <= 7)
            {
                Console.WriteLine("Ngày tương ứng là: " + dayweek[so-1]);
            }
            else
            {
                Console.WriteLine("Số nhập ko hợp lệ");
            }
            Console.ReadLine();
        }
    }
}
