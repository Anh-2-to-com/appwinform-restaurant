using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO() { }

        public string ID_KH { get; set; }
        public string TENKH { get; set; }
        public DateTime NGAYTHAMGIA { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }

    }
}
