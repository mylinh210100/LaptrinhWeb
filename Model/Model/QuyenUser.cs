namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyenUser")]
    public partial class QuyenUser
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idQuyen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string TenTaiKhoan { get; set; }

        [StringLength(50)]
        public string note { get; set; }

        public virtual QuyenSuDung QuyenSuDung { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
