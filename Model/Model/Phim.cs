namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            BinhLuans = new HashSet<BinhLuan>();
            Phim_ChuDe = new HashSet<Phim_ChuDe>();
        }

        [Key]
        public int idPhim { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPhim { get; set; }

        public string MoTa { get; set; }

        [Required]
        [StringLength(500)]
        public string Anh { get; set; }

        [Required]
        public string Link { get; set; }

        public int LuotXem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phim_ChuDe> Phim_ChuDe { get; set; }
    }
}
