using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIO.EF
{
    public class ChudePhimCode
    {
        private WebPhim db = null;

        public ChudePhimCode()
        {
            db = new WebPhim();
        }

        public IEnumerable<ChuDe> ListChude()
        {
            return db.ChuDes.ToList();
        }
    }
}
