using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHDDAL
    {
        public ChiTietHDDAL() { }

        public List<CTHD> listCTHD()
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                return db.CTHDs.ToList();
            }
        }

        public bool addCTHD(CTHD cthd)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    db.CTHDs.InsertOnSubmit(cthd);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool deleteCTHD(string idHD, string idMA)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    CTHD cthd = db.CTHDs.Where(p => p.ID_HOADON == idHD && p.ID_MONAN == idMA).FirstOrDefault();
                    db.CTHDs.DeleteOnSubmit(cthd);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool updateCTHD(CTHD cthd)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    CTHD cthdUpdate = db.CTHDs.Where(p => p.ID_HOADON == cthd.ID_HOADON && p.ID_MONAN == cthd.ID_MONAN).FirstOrDefault();
                    cthdUpdate.SOLUONG = cthd.SOLUONG;
                    cthdUpdate.DONGIA = cthd.DONGIA;
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
