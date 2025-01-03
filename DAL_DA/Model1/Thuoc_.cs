namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thuoc_
    {
        [Key]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        [StringLength(100)]
        public string TenThuoc { get; set; }

        public decimal? Gia { get; set; }

        [Required]
        [StringLength(50)]
        public string MaToa { get; set; }

        public virtual ToaThuoc ToaThuoc { get; set; }
    }
}
