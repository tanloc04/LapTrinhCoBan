using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhToaDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập x = ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập y = ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"Tọa độ của {x} và {y} nằm tại Q1");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Tọa  độ của {x} và {y} nằm tại Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Tọa độ của {x} và {y} nằm tại Q4");
            else
                Console.WriteLine($"Tọa độ của {x} và {y} nằm tại Q2");

            Console.ReadKey();
        }   
    }
}
