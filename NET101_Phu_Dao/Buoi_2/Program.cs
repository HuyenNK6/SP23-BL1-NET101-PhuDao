using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  ArrayList
             *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                            danh sách các đối tượng theo kiểu mảng (truy
                            cập các phần tử bên trong thông qua chỉ số
                            index)
                Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                            linh hoạt và có thể tự điều chỉnh kích cỡ một
                            cách tự động.
                Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                            thêm thư viện System.Collections
                Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
             */
            /*
             *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
             *
             *  1.Khai báo:
             *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
             *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
             */
            int[] arr = new int[5];
            ArrayList arrLst1 = new ArrayList();
            arrLst1.Add(100);
            arrLst1.Add("Poly");
            arrLst1.Add(true);
            arrLst1.Add(8.2);
            //1. khởi tạo ra 1 danh sách tuổi: int
            List<int> lstTuoi = new List<int>();
            //2. thêm đối tượng vào danh sách
            lstTuoi.Add(10);//add: thêm đối tượng vào cuối danh sách
            lstTuoi.Add(50);
            lstTuoi.Add(20);
            lstTuoi.Add(30);
            lstTuoi.Add(40);
            //lstTuoi.Add("fpt");
            //3. truy xuất theo vị trí
            Console.WriteLine(lstTuoi[2]);

            //4. duyệt danh sách
            Console.WriteLine($"so luong= {lstTuoi.Count}");
            //cách 1: for tab
            Console.WriteLine("Cach 1: ");
            for (int i = 0; i < lstTuoi.Count; i++)
            {
                Console.WriteLine($"lstTuoi[{i}] = {lstTuoi[i]}");
            }

            //cách 2: fore tab
            Console.WriteLine("Cach 2: ");
            foreach (var item in lstTuoi)
            {
                Console.WriteLine(item);
            }

            ////////
            List<string> lstTen = new List<string>();
            lstTen.Add("Hoa");
            lstTen.Add("Dao");
            lstTen.Add("Mai");
            //lstTen.Add(1);
            foreach (var ten in lstTen)
            {
                Console.WriteLine(ten);
            }


        }
    }
}
