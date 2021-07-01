namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuDe")]
    public partial class ChuDe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuDe()
        {
            Phim_ChuDe = new HashSet<Phim_ChuDe>();
        }

        [Key]
        public int idChuDe { get; set; }

        [Required]
        [StringLength(100)]
        public string tenChuDe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim_ChuDe> Phim_ChuDe { get; set; }
    }
}
