using learn.net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn.net.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong
    }
    public class SinhVienViewModel
    {
        public int ID { get; set; }


        public string MaSinhVien { get; set; }


        public string Ten { get; set; }


        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }


        public string QueQuan { get; set; }

        public int IDLopHoc { get; set; }

        public static List<SinhVienViewModel> GetList()
        {
            var db = new Model1();
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                GioiTinh = e.GioiTinh,
                QueQuan = e.QueQuan,
                IDLopHoc = (int)e.IDLopHoc,
            }).ToList();
            return rs;

        }
        public static List<SinhVienViewModel> GetList(int maLop)
        {
            var db = new Model1();
            var rs = db.SinhViens.Where(e => e.IDLopHoc == maLop).Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                MaSinhVien = e.MaSinhVien,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                GioiTinh = e.GioiTinh,
                QueQuan = e.QueQuan,
                IDLopHoc = (int)e.IDLopHoc,
            }).ToList();
            return rs;

        }
        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new Model1();
           int count=  db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count(); 
            if(count> 0)
            {
                return KetQua.TrungMa; 
            }
          
              else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
      /*  public static void getSinhVien (String maSV)
        {
            var db = new Model1(); 

        }*/


        public static KetQua DeleteSinhVien(String maSV)
        {
            var db = new Model1();
            var flag = false;
            var result = db.SinhViens.Where(e => e.MaSinhVien == maSV).ToList();
            foreach (var sv in result)
            {
               
                if (sv != null)
                {
                    db.SinhViens.Remove(sv);
                    flag = true; 
                }
                else
                {
                    flag = false; 

                }
              
            }
            if(flag == true  )
            {
                 db.SaveChanges();
                 return KetQua.ThanhCong; 
            }
            else
            {
                return KetQua.TrungMa;

            }
        }
        public static KetQua UpdateSinhVien(SinhVien sv)
        {
            var db = new Model1();
            var flag = false;
            var count = db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count == 0)
            {
                return KetQua.TrungMa;
            }

            else
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }

        }

    }
}
