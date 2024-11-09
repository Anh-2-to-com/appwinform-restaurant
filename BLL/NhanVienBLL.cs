using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Collections;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();
        public NhanVienBLL() { }

        public List<NhanVienDTO> listND()
        {
            return nhanVienDAL.listND().Select(p => new NhanVienDTO { ID_NV = p.ID_NV, TENNV = p.TENNV, NGAYVAOLAM = p.NGAYVAOLAM, SDT = p.SDT, CHUCVU = p.CHUCVU, TINHTRANG = p.TINHTRANG }).ToList<NhanVienDTO>();
        }

        public bool addND(NHANVIEN n)
        {
            return nhanVienDAL.addND(n);
        }

        public bool deleteND(string id)
        {
            return nhanVienDAL.deleteND(id);
        }

        public bool updateND(NHANVIEN n)
        {
            return nhanVienDAL.updateND(n);
        }

        public List<NHANVIEN> getListNVQuanLy()
        {
            return nhanVienDAL.listND().Where(p => p.CHUCVU == "Quan ly").ToList<NHANVIEN>();
        }

        public string getIdLastNV()
        {
            NHANVIEN nd = nhanVienDAL.listND().Last<NHANVIEN>();
            return nd.ID_NV;
        }

        public NHANVIEN getNVById(string id)
        {
            return nhanVienDAL.listND().Where(p => p.ID_NV == id).FirstOrDefault();
        }

        public List<NhanVienDTO> searchNhanVien(string textSearch)
        {
            List<NhanVienDTO> danhSachNhanVien = nhanVienDAL.listND().Select(p => new NhanVienDTO { ID_NV = p.ID_NV, TENNV = p.TENNV, NGAYVAOLAM = p.NGAYVAOLAM, SDT = p.SDT, CHUCVU = p.CHUCVU, TINHTRANG = p.TINHTRANG }).ToList<NhanVienDTO>();

            var ketQuaTimKiem = danhSachNhanVien
                .Where(nv => nv.TENNV.IndexOf(textSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return ketQuaTimKiem;
        }
    }
}
