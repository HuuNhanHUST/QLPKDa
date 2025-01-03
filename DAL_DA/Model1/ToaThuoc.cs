namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToaThuoc")]
    public partial class ToaThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToaThuoc()
        {
            Thuoc_ = new HashSet<Thuoc_>();
        }

        [Key]
        [StringLength(50)]
        public string MaToa { get; set; }

        [StringLength(1000)]
        public string LieuLuon { get; set; }

        public int? SoLuong { get; set; }

        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thuoc_> Thuoc_ { get; set; }
    }
}
