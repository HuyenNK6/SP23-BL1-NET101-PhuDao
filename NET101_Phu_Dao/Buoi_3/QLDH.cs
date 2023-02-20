using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3
{
    internal class QLDH
    {
        List<DongHo> lstDH = new List<DongHo>();
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                DongHo dh= new DongHo();
                //2. nhập thông tin
                Console.WriteLine("Nhap id = ");
                dh.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap name = ");
                dh.Name= Console.ReadLine();
                Console.WriteLine("Nhap gia = ");
                dh.Price = Convert.ToDouble(Console.ReadLine());    
                //3. thêm đối tượng vào ds
                lstDH.Add(dh);
                //4. hỏi tiếp tục
                Console.WriteLine("Ban co muon tiep tuc nhap ko (co/ko)?");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));//==
        }
        public void XuatDS()
        {
            foreach (var item in lstDH)
            {
                item.InThongTin();
            }
        }
        //tìm kiếm => giá trị cần tìm
        // nhập giá trị cần tìm => duyệt danh sách
        // so sánh, kiểm tra (tìm kiếm) thông tin
        // đúng => in ra thông tin của đối tượng
        public void TimKiemTheoID()
        {
            Console.WriteLine("Nhap id can tim= ");
            int id= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lstDH.Count; i++)
            {
                if (lstDH[i].Id == id)
                {
                    Console.WriteLine("Da tim thay: ");
                    lstDH[i].InThongTin();
                    return; //tìm thấy và thoát luôn
                }
            }
            Console.WriteLine("Khong tim thay");
        }
    }
}
