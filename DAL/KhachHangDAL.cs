using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        public KhachHangDAL() { }

        public List<KHACHHANG> listKH()
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                return db.KHACHHANGs.Select(p => p).ToList<KHACHHANG>();
            }    
        }

        public bool addKH(KHACHHANG kh)
        {
            using(DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    db.KHACHHANGs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }    
        }

        public bool deleteKH(string id)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    KHACHHANG kh = db.KHACHHANGs.Where(p => p.ID_KH == id).FirstOrDefault();
                    db.KHACHHANGs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool updateKH(KHACHHANG k)
        {
            using (DB_QLNhaHangDataContext db = new DB_QLNhaHangDataContext())
            {
                try
                {
                    KHACHHANG kh = db.KHACHHANGs.Where(p => p.ID_KH == k.ID_KH).FirstOrDefault();
                    kh.TENKH = k.TENKH;
                    kh.NGAYTHAMGIA = k.NGAYTHAMGIA;
                    kh.DOANHSO = k.DOANHSO;
                    kh.DIEMTICHLUY = k.DIEMTICHLUY;
                    kh.ID_ND = k.ID_ND;
                    kh.HINHANH = k.HINHANH;
                    kh.NGAYSINH = k.NGAYSINH;
                    kh.SDT = k.SDT;
                    kh.DIACHI = k.DIACHI;
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
