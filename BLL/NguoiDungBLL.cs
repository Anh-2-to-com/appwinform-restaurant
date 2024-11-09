using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class NguoiDungBLL
    {
        public NguoiDungBLL() { }

        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();
        NguoiDungNNnguoiDungDAL nguoiDungNNnguoiDungDAL = new NguoiDungNNnguoiDungDAL();
        public LoginResult Check_User(string pUser, string pPass)
        {
            List<NGUOIDUNG> list = nguoiDungDAL.listNguoiDung();
            NGUOIDUNG nd = list.Where(p => p.EMAIL == pUser && p.MATKHAU == pPass). FirstOrDefault();
            if (nd == null)
                return LoginResult.Invalid;// User không tồn tại
            return LoginResult.Success;// Đăng nhập thành công
        }

        public List<NguoiDungDTO> listNguoiDung()
        {
            return nguoiDungDAL.listNguoiDung().Select(p => new NguoiDungDTO {ID = p.ID_ND, Email = p.EMAIL, HoatDong = p.HOATDONG}).ToList<NguoiDungDTO>();
        }

        public bool addND(NGUOIDUNG nd)
        {
            return nguoiDungDAL.addND(nd);
        }

        public bool deleteND(string id)
        {
            return nguoiDungDAL.deleteND(id);
        }

        public bool updateND(NGUOIDUNG n)
        {
            return nguoiDungDAL.updateND(n);
        }

        public string getIdLastND()
        {
            NGUOIDUNG nd = nguoiDungDAL.listNguoiDung().Last<NGUOIDUNG>();
            return nd.ID_ND;
        }

        public List<NguoiDungDTO> getNDByMaNND(string id)
        {
            List<QL_NguoiDungNhomNguoiDung> nnd = nguoiDungNNnguoiDungDAL.listNDNND().Where(p => p.MaNhomNguoiDung == id).ToList<QL_NguoiDungNhomNguoiDung>();
            return nnd.Join(nguoiDungDAL.listNguoiDung(), p => p.ID_ND, q => q.ID_ND, (p, q) => new NguoiDungDTO { ID = q.ID_ND, Email = q.EMAIL, HoatDong = q.HOATDONG }).ToList<NguoiDungDTO>();
        }
    }
    public enum LoginResult
    {
        /// <summary>
        /// Wrong username or password
        /// </summary>
        Invalid,
        /// <summary>
        /// User had been disabled
        /// </summary>
        Disabled,
        /// <summary>
        /// Loging success
        /// </summary>
        Success
    }
}


