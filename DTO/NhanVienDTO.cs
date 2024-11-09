using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO() { }

        public string ID_NV { get; set; }
        public string TENNV { get; set; }
        public DateTime NGAYVAOLAM { get; set; }
        public string SDT { get; set; }
        public string CHUCVU { get; set; }
        public string TINHTRANG { get; set; }
    }
}
