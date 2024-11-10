using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        public KhachHangBLL() { }

        public List<KhachHangDTO> listKH()
        {
            return khachHangDAL.listKH().Select(p => new KhachHangDTO { ID_KH = p.ID_KH, TENKH = p.TENKH, NGAYSINH= DateTime.Parse(p.NGAYSINH.ToString()), SDT = p.SDT, DIACHI = p.DIACHI, NGAYTHAMGIA = DateTime.Parse(p.NGAYTHAMGIA.ToString())}).ToList<KhachHangDTO>();
        }

        public bool addKH(KHACHHANG kh)
        {
            return khachHangDAL.addKH(kh);
        }

        public bool deleteKH(string id)
        {
            return khachHangDAL.deleteKH(id);
        }

        public bool updateKH(KHACHHANG k)
        {
            return khachHangDAL.updateKH(k);
        }

        public int countKH()
        {
            return khachHangDAL.listKH().Count();
        }
    }
}
