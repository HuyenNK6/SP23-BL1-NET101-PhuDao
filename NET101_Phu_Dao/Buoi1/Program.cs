using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //ctrl D: copy code
            Console.WriteLine("NHẬP THÔNG TIN NYC");
            //họ tên: string
            Console.WriteLine("Nhập họ và tên: ");
            string hoTen = Console.ReadLine();
            //năm sinh: int
            Console.WriteLine("Nhập năm sinh: ");
            //ép kiểu từ string về số int
            int namSinh = Convert.ToInt32(Console.ReadLine());
            //chieu cao: double
            Console.WriteLine("Nhập chiều cao: ");
            //ép kiểu từ string về số double
            double chieuCao = Convert.ToDouble(Console.ReadLine());
            //địa chỉ: string
            Console.WriteLine("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();
            //giới tính: bool
            Console.WriteLine("Nhập giới tính: ");
            bool gioiTinh = Convert.ToBoolean(Console.ReadLine());
            //trạng thái: int- 1 còn yêu 2 hết yêu
            Console.WriteLine("Còn yêu hay hết yêu (1/2)");
            int trangThai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("XUẤT THÔNG TIN NYC");
            Console.WriteLine($"Tên NYC: {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}");
            Console.WriteLine($"Tuổi: {2023 - namSinh}");
            Console.WriteLine($"Chiều cao: {chieuCao}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            Console.WriteLine($"Giới tính: {(gioiTinh == true ? "Nam" : "Nu")} ");
            Console.WriteLine($"Trạng thái: {(trangThai == 1 ? "Con yeu" : "Het yeu")}");

            //<biểu thức điều kiện> ? <kết quả đúng> : <kết quả sai>
        }
    }
}
