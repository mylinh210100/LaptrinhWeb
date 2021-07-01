namespace Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BinhLuan")]
    public partial class BinhLuan
    {
        [Key]
        public int idBinhLuan { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTaiKhoan { get; set; }

        public int idPhim { get; set; }

        [Required]
        public string NoiDung { get; set; }

        public virtual Phim Phim { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
