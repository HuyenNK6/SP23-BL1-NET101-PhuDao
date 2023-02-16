using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
    internal class Program
    {
        /*
         * Bài 1: Tạo 1 menu gồm các chức năng sau.
         * Menu chỉ dừng lại khi chọn 0.
            1. Nhập vào số nguyên dương. Kiểm tra xem đó là số chẵn hay lẻ
            2. Nhập vào số n. Tính tổng các số lẻ từ 1 tới n
            3. Nhập vào số n. Tính tích các số chẵn từ 1 tới n
            0. Thoát
        Bài 2: Tạo 1 menu gồm các chức năng sau. Menu chỉ dừng lại khi chọn 0.
            1. Nhập vào 1 số nguyên dương n . Tính tích các số chia hết cho 5 từ 1 tới n.
            2. Nhập thông tin gồm tên , tuổi, địa chỉ, điểm, trường học của bản thân và in ra .
            3. Nhập thông tin gồm tên, điểm, chuyên ngành, tuổi, trường học của bản thân.
            4. Nhập vào 1 mảng số nguyên và tính tích của các phần tử có giá trị lẻ ở trong mảng.
            5. Nhập vào 1 mảng số nguyên và tính tổng của tất các các phần tử trong mảng.
             0.  Thoát

         */
        /*
         *  while(điều kiện){
         *          //công việc
         *  }
         *  do{
         *      //công việc
         *  }while(điều kiện)
         */
        static void Main(string[] args)
        {
            int chon;
            do
            {
                Console.WriteLine("------MENU--------");
                Console.WriteLine("--1. bai 1    ----");
                Console.WriteLine("--2. bai 2    ----");
                Console.WriteLine("--3. bai 3    ----");
                Console.WriteLine("--0. thoat    ----");
                Console.WriteLine("Moi lua chon (1-3): ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("--1. bai 1    ----");
                        //1. Nhập vào số nguyên dương.
                        //Kiểm tra xem đó là số chẵn hay lẻ
                        Console.WriteLine("Nhap so nguyen duong: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        if (a > 0)
                        {
                            if (a % 2 == 0)
                            {
                                Console.WriteLine($"{a} la so chan");
                            }
                            else
                            {
                                Console.WriteLine($"{a} la so le");
                            }
                        }
                        else
                        {//a <= 0
                            Console.WriteLine("Nhap lai diiiiii!!!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("--2. bai 2    ----");
                        //2. Nhập vào số n. Tính tổng các số lẻ từ 1 tới n
                        Console.WriteLine("Nhap so n= ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        //for   tab
                        int tong = 0;
                        for (int i = 1; i <= n; i++)
                        {
                            if (i % 2 != 0)
                            {
                                tong += i;//tong = tong + i;
                            }
                        }
                        Console.WriteLine($"tong cac so le tu 1-{n}= {tong}");
                        break;
                    case 3:
                        Console.WriteLine("--3. bai 3    ----");
                        //int tich = 1;
                        break;
                    case 0:
                        Console.WriteLine("--0. thoat    ----");
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai!!!!!!!!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
