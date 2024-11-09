using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class NhomNguoiDungBLL
    {
        NhomNguoiDungDAL nhomNguoiDungDAL  = new NhomNguoiDungDAL();
        public NhomNguoiDungBLL() { }

        public List<QL_NhomNguoiDung> listNND()
        {
            return nhomNguoiDungDAL.listNND();
        }

        public bool addNND(QL_NhomNguoiDung p)
        {
            return nhomNguoiDungDAL.addNND(p);
        }

        public bool deleteNND(string id)
        {
            return nhomNguoiDungDAL.deleteNND(id);
        }

        public bool updateNND(QL_NhomNguoiDung n)
        {
            return nhomNguoiDungDAL.updateNND(n);
        }

     
    }
}
