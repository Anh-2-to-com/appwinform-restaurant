using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHDBLL
    {
        ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();
        MonAnBLL monAnBLL = new MonAnBLL();
        public ChiTietHDBLL() { }
        public List<ChiTietHDDTO> listCTHD()
        {
            return chiTietHDDAL.listCTHD().Join(monAnBLL.listMonAn(), p => p.ID_MONAN, q => q.ID_MONAN, (p, q) => new ChiTietHDDTO { TenMonAn = q.TENMON, SoLuong = p.SOLUONG, DonGia = p.DONGIA}).ToList<ChiTietHDDTO>();
        }

        public bool addCTHD(CTHD cthd)
        {
            return chiTietHDDAL.addCTHD(cthd);
        }

        public bool deleteCTHD(string idHD, string idMA)
        {
            return chiTietHDDAL.deleteCTHD(idHD, idMA);
        }

        public bool updateCTHD(CTHD cthd)
        {
            return chiTietHDDAL.updateCTHD(cthd);
        }
    }
}
