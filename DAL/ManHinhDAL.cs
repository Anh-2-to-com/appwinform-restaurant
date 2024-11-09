using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManHinhDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public ManHinhDAL() { }

        public List<DM_ManHinh> listMH()
        {
            return db.DM_ManHinhs.Select(p => p).ToList<DM_ManHinh>();
        }

        public bool addMH(DM_ManHinh p)
        {
            try
            {
                db.DM_ManHinhs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteMH(string id)
        {
            try
            {
                DM_ManHinh nnd = db.DM_ManHinhs.Where(p => p.MaManHinh == id).FirstOrDefault();
                db.DM_ManHinhs.DeleteOnSubmit(nnd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updateMH(DM_ManHinh n)
        {
            try
            {
                DM_ManHinh nnd = db.DM_ManHinhs.Where(p => p.MaManHinh == n.MaManHinh).FirstOrDefault();
                nnd.TenManHinh = n.TenManHinh;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
