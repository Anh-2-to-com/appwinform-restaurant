using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public HoaDonBLL() { }

        public List<HOADON> listHD()
        {
            return hoaDonDAL.listHD();
        }

        public bool addHD(HOADON hd)
        {
            return hoaDonDAL.addHD(hd);
        }

        public bool deleteHD(string id)
        {
            return hoaDonDAL.deleteHD(id);
        }

        public bool updateHD(HOADON hd)
        {
            return hoaDonDAL.updateHD(hd);
        }

        public List<HoaDonDTO> getListHDByIdKH(string id)
        {
            return hoaDonDAL.listHD().Where(p => p.ID_KH == id).Select(h => new HoaDonDTO { ID_HOADON = h.ID_HOADON, ID_KH = h.ID_KH, ID_BAN=h.ID_BAN,TONGTIEN = h.TONGTIEN, TRANGTHAI = h.TRANGTHAI}).ToList<HoaDonDTO>();
        }
    }
}
