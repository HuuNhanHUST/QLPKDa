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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ToaThuocs = new HashSet<ToaThuoc>();
        }

        [Key]
        [StringLength(50)]
        public string MaHoaDon { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        [StringLength(50)]
        public string MaDichVu { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual DichVu DichVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToaThuoc> ToaThuocs { get; set; }
    }
}
