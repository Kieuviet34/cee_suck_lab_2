using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "bai 2";
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Tính diện tích hình tròn");
                Console.WriteLine("2. Tính diện tích hình chữ nhật");
                Console.WriteLine("3. Tính diện tích hình tam giác");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn một tùy chọn: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập bán kính: ");
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("Diện tích hình tròn: " + (Math.PI * radius * radius));
                        break;
                    case 2:
                        Console.Write("Nhập chiều dài: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Nhập chiều rộng: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Diện tích hình chữ nhật: " + (length * width));
                        break;
                    case 3:
                        Console.Write("Nhập cạnh đáy: ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.Write("Nhập chiều cao: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Diện tích hình tam giác: " + (0.5 * baseLength * height));
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
