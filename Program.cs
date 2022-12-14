using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class Program
    {
        public void Main(string[] args)
        {
            DanhSachSV sv = new DanhSachSV();    
            while (true)
            {
                Console.WriteLine("\n\t\tCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
                Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
                Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
                Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
                Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
                Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
                Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1: 
                        Console.WriteLine("\n1. Them sinh vien.");
                        sv.ThemSV();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;
                    case 2:
                        Console.WriteLine("\n2.Cap nhat thong tin sinh vien boi ID.");
                        sv.TimTheoIDSV();
                        Console.WriteLine("\nDa cap nhat sinh vien thanh cong");
                        break;
                    case 3:
                        Console.WriteLine("\n3.ID sinh vien can xoa");
                        sv.XoaSV();
                        Console.WriteLine("\nDa xoa sinh vien");
                        break;
                    case 4:
                        Console.WriteLine("\n4.Tim sinh vien theo ten!");
                        sv.TimSVTheoTen();
                        Console.WriteLine("\nDa xong");
                        break;
                    case 5:
                        Console.WriteLine("\n5.Sap xep sinh vien theo diem TB GPA!");
                        sv.SapXepDiemGPA();
                        sv.Show();
                        Console.WriteLine("\nDa xong");
                        break;
                    case 6:
                        Console.WriteLine("\n6.Sap xep sinh vien theo Ten!");
                        sv.SapXepTen();
                        sv.Show();
                        Console.WriteLine("\nDa xong");
                        break;
                    case 7:
                        Console.WriteLine("\n7.Sap xep sinh vien theo ID!");
                        sv.SapXepID();
                        sv.Show();
                        Console.WriteLine("\nDa xong");
                        break;
                    case 8:
                        sv.Show();
                        break;
                    case 0:
                        Console.WriteLine("\nDa thoat chuong trinh!");
                        return;

                }
                
            }                    
                    
        }
    }
}
