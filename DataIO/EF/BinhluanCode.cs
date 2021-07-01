using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIO.EF
{
    public class BinhluanCode
    {
        WebPhim db = null;
        public BinhluanCode()
        {
            db = new WebPhim();
        }


        public IEnumerable<BinhLuan> ViewBinhLuan(int idphim)
        {
            return db.BinhLuans.Where(x => x.idPhim == idphim).ToList();
        }
    }
}
