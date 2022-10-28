using learn.net.Model;
using learn.net.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.net.Services
{
    public class SinhVienService
    {
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
            int count = db.SinhViens.Where(e => e.MaSinhVien == sv.MaSinhVien).Count();
            if (count > 0)
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
        // Ham cap nhap 
        public static KetQua UpdateSinhVien(SinhVienViewModel sv)
        {
            var db = new Model1();
            var sinhvien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhvien.Ten = sv.Ten;
            sinhvien.QueQuan = sv.QueQuan;
            sinhvien.IDLopHoc = sv.IDLopHoc;
            sinhvien.GioiTinh = sv.GioiTinh;
            sinhvien.MaSinhVien = sv.MaSinhVien;
            sinhvien.NgaySinh = sv.NgaySinh;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new Model1();
            var sinhvien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhvien);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
       
    }
}
