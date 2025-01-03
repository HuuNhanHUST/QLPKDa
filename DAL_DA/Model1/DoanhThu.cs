namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        [Key]
        [StringLength(50)]
        public string MaDoanhThu { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDichVu { get; set; }

        public DateTime? NgayHoaDon { get; set; }

        public decimal? Gia { get; set; }

        public virtual DichVu DichVu { get; set; }
    }
}
