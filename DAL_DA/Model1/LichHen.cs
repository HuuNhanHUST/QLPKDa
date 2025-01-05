namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichHen")]
    public partial class LichHen
    {
        [Key]
        [StringLength(50)]
        public string MaLichHen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHenTT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHenGN { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        [StringLength(50)]
        public string MaDichVu { get; set; }

        [StringLength(1000)]
        public string Ghichu { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual DichVu DichVu { get; set; }
    }
}
