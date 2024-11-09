using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL phanQuyenDAL = new PhanQuyenDAL();
        ManHinhDAL manHinhDAL = new ManHinhDAL();
        public PhanQuyenBLL() { }

        public List<QL_PhanQuyen> listPQ()
        {
            return phanQuyenDAL.listPQ();
        }

        public bool addPQ(QL_PhanQuyen p)
        {
            return phanQuyenDAL.addPQ(p);
        }

        public bool deletePQ(string pMaNhom, string pMaMH)
        {
            return phanQuyenDAL.deletePQ(pMaNhom, pMaMH);   
        }

        public bool updatePQ(QL_PhanQuyen n)
        {
            return phanQuyenDAL.updatePQ(n);
        }

        public List<PhanQuyenDTO> getListPQByMaNND(string id)
        {
            List<QL_PhanQuyen> list = phanQuyenDAL.listPQ().Where(p => p.MaNhomNguoiDung == id).ToList<QL_PhanQuyen>();
            return list.Join(manHinhDAL.listMH(), p => p.MaManHinh, q => q.MaManHinh, (p, q) => new PhanQuyenDTO { MaMH = q.MaManHinh, TenMH = q.TenManHinh, CoQuyen = p.CoQuyen}).ToList<PhanQuyenDTO>();
        }
    }
}
