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
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string MaToa { get; set; }

        [StringLength(1000)]
        public string LieuLuon { get; set; }

        [Required]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBenhNhan { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual Thuoc_ Thuoc_ { get; set; }
    }
}
