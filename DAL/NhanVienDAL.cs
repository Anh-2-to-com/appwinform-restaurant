using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext();
        public NhanVienDAL() { }

        public List<NHANVIEN> listND()
        {
            using (DB_QLNhaHangDataContext context = new DB_QLNhaHangDataContext())
            {
                return context.NHANVIENs.Select(p => p).ToList<NHANVIEN>();
            }
        }

        public bool addND(NHANVIEN n)
        {
            try
            {
                db.NHANVIENs.InsertOnSubmit(n);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool deleteND(string id)
        {
            try
            {
                NHANVIEN nd = db.NHANVIENs.Where(p => p.ID_NV == id).FirstOrDefault();
                db.NHANVIENs.DeleteOnSubmit(nd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool updateND(NHANVIEN n)
        {
            try
            {
                NHANVIEN nd = db.NHANVIENs.Where(p => p.ID_NV == n.ID_NV).FirstOrDefault();
                nd.TENNV = n.TENNV;
                nd.NGAYVAOLAM = n.NGAYVAOLAM;
                nd.SDT = n.SDT;
                nd.CHUCVU = n.CHUCVU;
                nd.ID_ND = n.ID_ND;
                nd.ID_NQL = n.ID_NQL;
                nd.TINHTRANG = n.TINHTRANG;
                nd.HINHANH = n.HINHANH;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }

}
