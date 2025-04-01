using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucLuaChon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            //Giải PT bậc 2
            Console.Write("Nhập a = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c = ");
            double c = int.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }

            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép:");
                double x = -b / 2 * a;
                Console.WriteLine($"x = {Math.Round(x)}");
            }

            else
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }

            //Xác định tọa độ
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
        
            //Tìm số lớn nhất trong 3 số
            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());

            int max = 0;
            
            if (a > b && a > c)
            {
                max = a;
                Console.WriteLine($"Số lớn nhất là: {a}");
            }
            else if (b > a && b > c)
            {
                max = b;
                Console.WriteLine($"Số lớn nhất là: {b}");
            }
            else
            {
                max = c;
                Console.WriteLine($"Số lớn nhất là: {c}");
            }
            

            //Tính tiền sản phẩm
            Console.Write("Nhập vào mã sản phẩm: ");
            double maSanPham = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số lượng: ");
            double soLuong = double.Parse(Console.ReadLine());

            double thanhTien = 0;
            string productName = "";
            double price;

            switch (maSanPham)
            {
                case 1:
                    price = 4;
                    thanhTien = soLuong * price;
                    productName = "Cochorro Quente";
                    Console.WriteLine($"{"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL (R$)",12}");
                    Console.WriteLine($"{productName,-20} | {price,12} | {soLuong,12} | {thanhTien,12}");
                    break;
                case 2:
                    price = 4.5;
                    thanhTien = soLuong * price;
                    productName = "X-Salada";
                    Console.WriteLine($"{"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL (R$)",12}");
                    Console.WriteLine($"{productName,-20} | {price,12} | {soLuong,12} | {thanhTien,12}");
                    break;
                case 3:
                    price = 5;
                    thanhTien = soLuong * price;
                    productName = "X-Bacon";
                    Console.WriteLine($"{"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL (R$)",12}");
                    Console.WriteLine($"{productName,-20} | {price,12} | {soLuong,12} | {thanhTien,12}");
                    break;
                case 4:
                    price = 2;
                    thanhTien = soLuong * price;
                    productName = "Torrada simples";
                    Console.WriteLine($"{"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL (R$)",12}");
                    Console.WriteLine($"{productName,-20} | {price,12} | {soLuong,12} | {thanhTien,12}");
                    break;
                case 5:
                    price = 1;
                    thanhTien = soLuong * price;
                    productName = "Refrigerante";
                    Console.WriteLine($"{"PRODUCT NAME", -20} | {"PRICE", 12} | {"QUANTITY", 12} | {"TOTAL (R$)", 12}");
                    Console.WriteLine($"{productName,-20} | {price, 12} | {soLuong, 12} | {thanhTien, 12}");
                    break;
            } */

            //Bài toán tính lương nhân viên
            Console.Write("Nhập vào lương hiện tại của nhân viên: ");
            double luongHienTai = double.Parse(Console.ReadLine());
            
            if ( luongHienTai > 0 && luongHienTai <= 400)
            {
                double luongMoi = luongHienTai + luongHienTai * 0.15;
                Console.WriteLine($"Lương của nhân viên này là: {luongMoi}.");
            }

            Console.ReadKey();
        }
    }

    
}
