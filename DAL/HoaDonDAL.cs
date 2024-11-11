using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        public HoaDonDAL() { }

        public List<HOADON> listHD()
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                return db.HOADONs.Select(p => p).ToList<HOADON>();
            }    
        }

        public bool addHD(HOADON hd)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    db.HOADONs.InsertOnSubmit(hd);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteHD(string id)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    HOADON h = db.HOADONs.Where(p => p.ID_HOADON == id).FirstOrDefault();
                    db.HOADONs.InsertOnSubmit(h);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool updateHD(HOADON hd)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    HOADON h = db.HOADONs.Where(p => p.ID_HOADON == hd.ID_HOADON).FirstOrDefault();
                    h.ID_KH = hd.ID_KH;
                    h.ID_BAN = hd.ID_BAN;
                    h.NGAYHD = hd.NGAYHD;
                    h.TONGTIEN = hd.TONGTIEN;
                    h.TRANGTHAI = hd.TRANGTHAI;
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
