using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MonAnBLL
    {
        MonAnDAL monAnDAL = new MonAnDAL();
        public MonAnBLL() { }

        public List<MONAN> listMonAn()
        {
            return monAnDAL.listMonAn().OrderByDescending(p => int.Parse(p.ID_MONAN)).ToList<MONAN>();
        }

        public bool addMonAn(MONAN monan)
        {
            return monAnDAL.addMonAn(monan);
        }

        public bool deleteMonAn(string id)
        {
            return monAnDAL.deleteMonAn(id);
        }

        public bool updateMonAn(MONAN m)
        {
            return monAnDAL.updateMonAn(m);
        }

        public string getIdLastMonAn()
        {
            MONAN nd = monAnDAL.listMonAn().OrderBy(p => int.Parse(p.ID_MONAN)).Last<MONAN>();
            return nd.ID_MONAN;
        }

        public MONAN getMonAnById(string id)
        {
            return monAnDAL.listMonAn().Where(p => p.ID_MONAN == id).FirstOrDefault();
        }

        public int countMonAn()
        {
            return monAnDAL.listMonAn().Count();
        }

        public List<MONAN> searchMonAn(string textSearch)
        {
            List<MONAN> danhSachMonAn = monAnDAL.listMonAn();

            var ketQuaTimKiem = danhSachMonAn
                .Where(nv => nv.TENMON.IndexOf(textSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return ketQuaTimKiem;
        }
    }
}
