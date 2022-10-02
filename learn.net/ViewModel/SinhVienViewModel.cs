using learn.net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.net.ViewModel
{
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
    }
}
