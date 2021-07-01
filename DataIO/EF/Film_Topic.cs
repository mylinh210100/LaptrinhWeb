using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataIO.EF
{
    public class Film_Topic
    {
        public int idPhim { get; set; }

        public string namefilm { get; set; }
        public string mota { get; set; }
        public string anh { get; set; }
        public string link { get; set; }

        public int view { get; set; }
        public int chude { get; set; }

    }
}