using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        public PhanQuyenDTO() { }

        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public bool? CoQuyen { get; set; }
    }
}
