using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIO.EF
{
    
    public class Phimcode
    {
        private WebPhim db = null;
        public Phimcode()
        {
            db = new WebPhim();
        }

        public List<Phim> ListPhim()
        {
            return db.Phims.OrderByDescending(x=>x.LuotXem).ToList();
        }

        public Phim VideoPhim(int id)
        {
            var model = db.Phims.SingleOrDefault(x => x.idPhim == id);
            model.LuotXem += 1;
            db.SaveChanges();
            return model;
        }

        public IEnumerable<Film_Topic> FilmbyTopic(int idtopic)
        {
            var list = from a in db.Phims
                       join b in db.Phim_ChuDe on a.idPhim equals b.idPhim
                       join c in db.ChuDes on b.idChuDe equals c.idChuDe
                       where c.idChuDe == idtopic
                       select new Film_Topic()
                       {
                           idPhim = a.idPhim,
                           namefilm = a.TenPhim,
                           mota = a.MoTa,
                           anh = a.Anh,
                           link = a.Link,
                           view = a.LuotXem,
                           chude = c.idChuDe
                           
                       };
            return list.OrderByDescending(x=>x.view).ToList();  
                       
        }

    }
}
