using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SinhVien
{
    public class LopSinhVien
    {        
        public int ID { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public int Toan { get; set; }
        public int Ly { get; set; }
        public int Hoa { get; set; }

        public static int globalSVid;
                
        public LopSinhVien()
        {

        }

        public LopSinhVien(int id, string ten, string gioiTinh, int tuoi, int toan, int ly, int hoa)
        {            
            this.ID = id;
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
            this.diemTB();
            this.hocLuc();
        }

        public float diemTB()
        {
            return (float)(this.Toan + this.Ly + this.Hoa) / 3;
        }

        public string hocLuc()
        {
            float diem = diemTB();
            if (diem >= 8)
            {
                return "Gioi";
            }
            else if (diem < 8 && diem >= 6.5)
            {
                return "Kha";
            }
            else if (diem < 6.5 && diem >= 5)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }      
        }
                
        public void ThemSV()
        {            
            Console.WriteLine("Dien thong tin sinh vien: ten + gioi tinh + tuoi + toan + ly + hoa");
            Ten = Convert.ToString(Console.ReadLine());
            GioiTinh = Convert.ToString(Console.ReadLine());
            Tuoi = Convert.ToInt32(Console.ReadLine());
            Toan = Convert.ToInt32(Console.ReadLine());
            Ly = Convert.ToInt32(Console.ReadLine());
            Hoa = Convert.ToInt32(Console.ReadLine());
            this.diemTB();
            this.hocLuc();
            ID = Interlocked.Increment(ref globalSVid);
        } 
        
        public void Show()
        {
            Console.WriteLine($"Thong tin:\nID: {ID} -- ten: {Ten} -- gioi tinh: {GioiTinh}"+ 
                $"-- tuoi: {Tuoi} -- toan: {Toan} -- ly: {Ly} -- Hoa: {Hoa} -- diem TB: {diemTB()}"+ 
                $" -- hoc luc: {hocLuc()}");
        }

        
    }
}
