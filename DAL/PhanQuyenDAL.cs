using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public PhanQuyenDAL() { }

        public List<QL_PhanQuyen> listPQ()
        {
            return db.QL_PhanQuyens.Select(p => p).ToList<QL_PhanQuyen>();
        }

        public bool addPQ(QL_PhanQuyen p)
        {
            try
            {
                db.QL_PhanQuyens.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deletePQ(string pMaNhom, string pMaMH)
        {
            try
            {
                QL_PhanQuyen nnd = db.QL_PhanQuyens.Where(p => p.MaNhomNguoiDung == pMaNhom && p.MaManHinh == pMaMH).FirstOrDefault();
                db.QL_PhanQuyens.DeleteOnSubmit(nnd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updatePQ(QL_PhanQuyen n)
        {
            try
            {
                QL_PhanQuyen nnd = db.QL_PhanQuyens.Where(p => p.MaNhomNguoiDung == n.MaNhomNguoiDung && p.MaManHinh == n.MaManHinh).FirstOrDefault();
                nnd.CoQuyen = n.CoQuyen;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
