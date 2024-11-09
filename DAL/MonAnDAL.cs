using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MonAnDAL
    {
        public MonAnDAL() { }

        public List<MONAN> listMonAn()
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                return db.MONANs.Select(p => p).ToList<MONAN>();
            }    
        }

        public bool addMonAn(MONAN monan)
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    db.MONANs.InsertOnSubmit(monan);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }    
        }

        public bool deleteMonAn(string id)
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    MONAN m = db.MONANs.Where(p => p.ID_MONAN == id).FirstOrDefault();  
                    db.MONANs.DeleteOnSubmit(m);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }    
        }

        public bool updateMonAn(MONAN m)
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext() )
            {
                try
                {
                    MONAN ma = db.MONANs.Where(p => p.ID_MONAN == m.ID_MONAN).FirstOrDefault();
                    ma.TENMON = m.TENMON;
                    ma.DONGIA = m.DONGIA;
                    ma.LOAI = m.LOAI;
                    ma.TRANGTHAI = m.TRANGTHAI;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }    
        }
    }
}
