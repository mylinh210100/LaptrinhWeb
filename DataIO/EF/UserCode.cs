using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIO.EF
{
    public class UserCode
    {
        WebPhim db = null;
        public UserCode()
        {
            db = new WebPhim();
        }

        public int Dangnhap(string userName, string pass)
        {
            var rs = db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == userName);
            if (rs == null)
            {
                return 0;
            }
            else
            {
                if (rs.PassWord == pass)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }

        public string Insert(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
            return taiKhoan.TenTaiKhoan;
        }

        public TaiKhoan GetByName(string userName)
        {
            return db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == userName);
        }
    }
}
