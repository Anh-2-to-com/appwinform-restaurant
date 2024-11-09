using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungNNnguoiDungDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public NguoiDungNNnguoiDungDAL() { }

        public List<QL_NguoiDungNhomNguoiDung> listNDNND()
        {
            return db.QL_NguoiDungNhomNguoiDungs.Select(p => p).ToList<QL_NguoiDungNhomNguoiDung>();
        }

        public bool addNDNND(QL_NguoiDungNhomNguoiDung p)
        {
            try
            {
                db.QL_NguoiDungNhomNguoiDungs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteNDNND(string pMaNhom, string pMaND)
        {
            try
            {
                QL_NguoiDungNhomNguoiDung nnd = db.QL_NguoiDungNhomNguoiDungs.Where(p => p.MaNhomNguoiDung == pMaNhom && p.ID_ND == pMaND).FirstOrDefault();
                db.QL_NguoiDungNhomNguoiDungs.DeleteOnSubmit(nnd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updateNDNND(QL_NguoiDungNhomNguoiDung n)
        {
            try
            {
                QL_NguoiDungNhomNguoiDung nnd = db.QL_NguoiDungNhomNguoiDungs.Where(p => p.MaNhomNguoiDung == n.MaNhomNguoiDung && p.ID_ND == n.ID_ND).FirstOrDefault();
                nnd.MaNhomNguoiDung = n.MaNhomNguoiDung;
                nnd.GhiChu = n.GhiChu;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
