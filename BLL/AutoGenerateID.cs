using DAL;
using DocumentFormat.OpenXml.Spreadsheet;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class AutoGenerateID
    {
        public static string CreateID(string numberString, string prefix)
        {
            string numberPart = numberString.Substring(prefix.Length);
            if (int.TryParse(numberPart, out int number))
            {
                number += 1;
                string newNumberString = $"{prefix}{number:D3}";
                return newNumberString;
            }
            else
            {
                return null;
            }
        }
    }
}
