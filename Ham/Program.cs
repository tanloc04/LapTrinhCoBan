using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"S = {TinhTongCuaS(a, m, n)}");
            Console.ReadKey();
        }

        //Hàm tính tổng 2 lũy thừa theo cơ số và số mũ cho trước (cùng cơ số)
        static int TinhTongCuaS(int a, int m, int n)
        {
            int an = 1, am = 1;
            for (int i = 1; i <= n; i++)
                an *= a;
            for (int i = 1; i <= m; i++)
                am *= a;
            return am + an;
        }
    }
}
