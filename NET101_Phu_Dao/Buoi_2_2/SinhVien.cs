using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_2
{
    internal class SinhVien
    {
        //1. thuộc tính
        private string ma;
        private string ten;
        private double diem;
        private int tuoi;
        private bool trangThai;
        //true- có NY, false- chưa có ny

        //2. constructor: hàm tạo đối tượng
        //2.1 ctor ko tham số
        //ctor tab
        public SinhVien()
        {
        }
        //2.2 ctor có tham số
        //bôi đen toàn bộ thuộc tính
        //click chuột phải => Quick Action....
        //Generate Constructor....
        public SinhVien(string ma, string ten, double diem, int tuoi, bool trangThai)
        {
            this.ma = ma;
            this.ten = ten;
            this.diem = diem;
            this.tuoi = tuoi;
            this.trangThai = trangThai;
        }
        //3. Property
        //bôi đen toàn bộ thuộc tính
        //click chuột phải => Quick Action....
        //Encapsulate field....
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Diem { get => diem; set => diem = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        //4. In thông tin 
        public void InThongTin()
        {
            Console.WriteLine($"SinhVien: " +
                $"{ma}| " +
                $"{ten}| " +
                $"{diem}| " +
                $"{tuoi}| " +
                $"{(trangThai == true ? "Co NY": "E")}");
        }
    }
}
