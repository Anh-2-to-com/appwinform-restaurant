using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO() { }  

        public string ID_HOADON { get; set; }
        public string ID_KH { get; set; }
        public string ID_BAN { get; set; }
        public decimal? TONGTIEN { get; set; }
        public string TRANGTHAI { get; set; }
    }
}
