using learn.net.Model;
using learn.net.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.net.Services
{
    public class LopHocService
    {
        public static List<LopHocViewModel> GetList()
        {

            var db = new Model1();
            var rs = db.LopHocs.Select(e => new LopHocViewModel
            {
                ID = (int)e.ID,
                TenLop = e.TenLop
            }).ToList();
            return rs;
        }
        public static String GetTenLopHoc(int ID)
        {

            var db = new Model1();
            var lophoc = db.LopHocs.Where(e => e.ID == ID).FirstOrDefault();
           
            return lophoc.TenLop;
        }
        /*   public LopHocViewModel selectedLopHoc
           {
               return 
           }*/

        public static KetQua AddLopHocs(LopHoc lh)
        {
            var db = new Model1();
            int count = db.LopHocs.Where(e => e.TenLop == lh.TenLop).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }

            else
            {
                db.LopHocs.Add(lh);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua RemoveLopHoc(LopHocViewModel lh)
        {
            var db = new Model1();
            var sinhvien = db.SinhViens.Where(e=>e.IDLopHoc == lh.ID).Count();
            var lophoc = db.LopHocs.Where(e => e.ID == lh.ID).FirstOrDefault();
            if(sinhvien > 0)
            {
                return KetQua.TrungMa;
            
            }
           
            db.LopHocs.Remove(lophoc);
            db.SaveChanges();
            return KetQua.ThanhCong;



        }
        public static KetQua UpdateLopHoc(LopHocViewModel lh)
        {
            var db = new Model1();
            var countlophoc = db.LopHocs.Where(e => e.TenLop == lh.TenLop).Count(); 
            var lophoc = db.LopHocs.Where(e => e.ID == lh.ID).FirstOrDefault();
            lophoc.TenLop = lh.TenLop;
         
             if(countlophoc != 0)
              {
                return KetQua.TrungMa; 
              }
            db.SaveChanges();
            return KetQua.ThanhCong;

        }
    }
   
}
