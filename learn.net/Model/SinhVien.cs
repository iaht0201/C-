namespace learn.net.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaSinhVien { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        public int? IDLopHoc { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
