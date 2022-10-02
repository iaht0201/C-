using learn.net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.net.ViewModel
{
    public class LopHocViewModel
    {
        public int ID { get; set; }
        public string TenLop { get; set; }
        public static List<LopHocViewModel> GetList()
        {
            var db = new Model1(); 
            var rs = db.LopHocs.Select(e => new LopHocViewModel
            {
                ID = e.ID,
                TenLop = e.TenLop
            }).ToList();
            return rs;
        }

    }
}
