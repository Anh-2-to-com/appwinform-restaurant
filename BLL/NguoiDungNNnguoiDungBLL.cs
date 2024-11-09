using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NguoiDungNNnguoiDungBLL
    {
        NguoiDungNNnguoiDungDAL nguoiDungNNnguoiDungDAL = new NguoiDungNNnguoiDungDAL();
        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();
        public NguoiDungNNnguoiDungBLL() { }

        public List<QL_NguoiDungNhomNguoiDung> listNDNND()
        {
            return nguoiDungNNnguoiDungDAL.listNDNND();
        }

        public bool addNDNND(QL_NguoiDungNhomNguoiDung p)
        {
            return nguoiDungNNnguoiDungDAL.addNDNND(p);
        }

        public bool deleteNDNND(string pMaNhom, string pMaND)
        {
            return nguoiDungNNnguoiDungDAL.deleteNDNND(pMaNhom, pMaND);
        }

        public bool updateNDNND(QL_NguoiDungNhomNguoiDung n)
        {
            return nguoiDungNNnguoiDungDAL.updateNDNND(n);  
        }

        public List<string> getMaNNDByTenDangNhap(string tenDangNhap)
        {
            List<string> listMaNND = new List<string>();
            NGUOIDUNG nd = nguoiDungDAL.listNguoiDung().Where(p => p.EMAIL == tenDangNhap).FirstOrDefault();
            List<QL_NguoiDungNhomNguoiDung> list = nguoiDungNNnguoiDungDAL.listNDNND().Where(p => p.ID_ND == nd.ID_ND).ToList<QL_NguoiDungNhomNguoiDung>();
            foreach (var item in list)
            {
                listMaNND.Add(item.MaNhomNguoiDung);
            }
            return listMaNND;
        }

    }
}
