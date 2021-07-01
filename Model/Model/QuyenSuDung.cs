namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyenSuDung")]
    public partial class QuyenSuDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuyenSuDung()
        {
            QuyenUsers = new HashSet<QuyenUser>();
        }

        [Key]
        public int idQuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string TenQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyenUser> QuyenUsers { get; set; }
    }
}
