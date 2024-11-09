using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuItemDTO
    {
        public string Display { get; set; }
        public string Value { get; set; }

        public ChucVuItemDTO(string display, string value)
        {
            Display = display;
            Value = value;
        }
    }
}
