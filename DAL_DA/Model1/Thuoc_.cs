namespace DAL_DA.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thuoc_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc_()
        {
            ToaThuocs = new HashSet<ToaThuoc>();
        }

        [Key]
        [StringLength(50)]
        public string MaThuoc { get; set; }

        [StringLength(100)]
        public string TenThuoc { get; set; }

        public decimal? GiaThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToaThuoc> ToaThuocs { get; set; }
    }
}
