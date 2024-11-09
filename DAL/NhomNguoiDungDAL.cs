using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    
    public class NhomNguoiDungDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public NhomNguoiDungDAL() { }

        public List<QL_NhomNguoiDung> listNND()
        {
            return db.QL_NhomNguoiDungs.Select(p => p).ToList<QL_NhomNguoiDung>();
        }

        public bool addNND(QL_NhomNguoiDung p)
        {
            try
            {
                db.QL_NhomNguoiDungs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool deleteNND(string id)
        {
            try
            {
                QL_NhomNguoiDung nnd = db.QL_NhomNguoiDungs.Where(p => p.MaNhom == id).FirstOrDefault();
                db.QL_NhomNguoiDungs.DeleteOnSubmit(nnd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updateNND(QL_NhomNguoiDung n)
        {
            try
            {
                QL_NhomNguoiDung nnd = db.QL_NhomNguoiDungs.Where(p => p.MaNhom == n.MaNhom).FirstOrDefault();
                nnd.TenNhom = n.TenNhom;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
