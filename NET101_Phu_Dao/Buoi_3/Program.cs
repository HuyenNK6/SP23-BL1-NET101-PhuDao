using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLDH ql = new QLDH();
            int chon;
            do
            {
                Console.WriteLine("----MENU-------");
                Console.WriteLine("--1. Nhap DS---");
                Console.WriteLine("--2. Xuat DS---");
                Console.WriteLine("--3. Tim kiem---");
                Console.WriteLine("--0. Thaot ct---");
                Console.WriteLine("---------------");
                Console.WriteLine("Lua chon: ");
                chon = Convert.ToInt32(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("--1. Nhap DS---");
                        ql.NhapDS();
                        break;
                    case 2:
                        Console.WriteLine("--2. Xuat DS---");
                        ql.XuatDS();
                        break;  
                    case 3:
                        Console.WriteLine("--3. Tim kiem---");
                        ql.TimKiemTheoID();
                        break;
                    case 0:
                        Console.WriteLine("--0. Thoat CT---");
                        break;
                    default:
                        Console.WriteLine("Nhap lai!!!!!!!!!!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
