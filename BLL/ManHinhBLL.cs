using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ManHinhBLL
    {
        ManHinhDAL manHinhDAL = new ManHinhDAL();
        public ManHinhBLL() { }

        public List<DM_ManHinh> listMH()
        {
            return manHinhDAL.listMH();
        }

        public bool addMH(DM_ManHinh p)
        {
            return manHinhDAL.addMH(p);
        }

        public bool deleteMH(string id)
        {
            return manHinhDAL.deleteMH(id);
        }

        public bool updateMH(DM_ManHinh n)
        {
            return manHinhDAL.updateMH(n);
        }
    }
}
