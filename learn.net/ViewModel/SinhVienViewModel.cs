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

        
     /*   public static KetQua DeleteSinhVien(String maSV)
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
        }*/
      

    }
}
