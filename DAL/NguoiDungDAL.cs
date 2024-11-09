using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public NguoiDungDAL() { }

        public List<NGUOIDUNG> listNguoiDung()
        {
            return db.NGUOIDUNGs.Select(p => p).ToList<NGUOIDUNG>();
        }

        public bool addND(NGUOIDUNG nd)
        {
            try
            {
                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool deleteND(string id)
        {
            try
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(p => p.ID_ND == id).FirstOrDefault();  
                db.NGUOIDUNGs.DeleteOnSubmit(nd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updateND(NGUOIDUNG n)
        {
            try
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(p => p.ID_ND == n.ID_ND).FirstOrDefault();
                nd.EMAIL = n.EMAIL;
                nd.VAITRO = n.VAITRO;
                nd.HOATDONG = n.HOATDONG;
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
