namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(50)]
        public string MaHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        [StringLength(50)]
        public string MaToa { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        [StringLength(50)]
        public string MaDichVu { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual ToaThuoc ToaThuoc { get; set; }
    }
}
