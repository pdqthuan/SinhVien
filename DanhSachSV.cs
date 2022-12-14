using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class DanhSachSV
    {
        public static List<LopSinhVien> listSV { get; set; } = new List<LopSinhVien>();

        //thêm SV vào list
        public void ThemSV()
        {
            do
            {
                LopSinhVien sv = new LopSinhVien();
                sv.ThemSV();
                listSV.Add(sv);
                try
                {
                    Console.WriteLine("Neu nhap them SV an phim so 1 -- neu muon thoat nhan so 0 ");
                    int exit = Convert.ToInt32(Console.ReadLine());
                    if (exit == 0)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("<<<LOI!>>> " + ex.Message);
                }                
                
            } while (true);           

        }
               
        //in DS sinh viên
        public void Show()
        {
            foreach (var item in listSV)
            {
                item.Show();
            }
        }

        public void TimTheoIDSV()
        {
            Console.WriteLine("nhap ID sinh vien can tim");
            int soIdCanTim = Convert.ToInt32(Console.ReadLine());
            foreach (var item in listSV)
            {
                if (item.ID == soIdCanTim)
                {
                    Console.WriteLine("Cap nhat thong tin: ten + gioi tinh + tuoi + toan + ly + hoa");
                    item.Ten = Convert.ToString(Console.ReadLine());
                    item.GioiTinh = Convert.ToString(Console.ReadLine());
                    item.Tuoi = Convert.ToInt32(Console.ReadLine());
                    item.Toan = Convert.ToInt32(Console.ReadLine());
                    item.Ly = Convert.ToInt32(Console.ReadLine());
                    item.Hoa = Convert.ToInt32(Console.ReadLine());
                    item.diemTB();
                    item.hocLuc();
                    break;
                }                 
                Console.WriteLine("ID sinh vien vua nhap khong ton tai!");
                
            }
        }
        public void XoaSV()
        {
            Console.WriteLine("nhap ID sinh vien can xoa!");
            int idXoa = Convert.ToInt32(Console.ReadLine());
            foreach (var item in listSV)
                if (item.ID == idXoa)
            {
                   listSV.Remove(item);
                   return;
            }
            Console.WriteLine("ID khong ton tai!");                
        }
        
        public void TimSVTheoTen()
        {
            Console.WriteLine("nhap Ten sinh vien can tim kiem");
            string tenSV = Convert.ToString(Console.ReadLine());
            foreach (var item in listSV)
                if (item.Ten == tenSV)
            {
                    item.Show();
                    return;
            }
            Console.WriteLine("khong ton tai");                
        }
        public void SapXepDiemGPA()
        {
            listSV.Sort(delegate (LopSinhVien sv1, LopSinhVien sv2) { return sv1.diemTB().CompareTo(sv2.diemTB()); }); 
        }

        public void SapXepTen()
        {
            listSV.Sort(delegate (LopSinhVien sv1, LopSinhVien sv2) { return sv1.Ten.CompareTo(sv2.Ten); });
        }

        public void SapXepID()
        {
            listSV.Sort(delegate (LopSinhVien sv1, LopSinhVien sv2) { return sv1.ID.CompareTo(sv2.ID); });
        }
    }
}
