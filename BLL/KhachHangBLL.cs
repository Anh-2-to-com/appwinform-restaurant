﻿using DAL;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();
        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();
        public KhachHangBLL() { }

        public List<KhachHangDTO> listKH()
        {
            return khachHangDAL.listKH().Select(p => new KhachHangDTO { ID_KH = p.ID_KH, TENKH = p.TENKH, NGAYSINH= DateTime.Parse(p.NGAYSINH.ToString()), SDT = p.SDT, DIACHI = p.DIACHI, NGAYTHAMGIA = DateTime.Parse(p.NGAYTHAMGIA.ToString())}).ToList<KhachHangDTO>();
        }

        public bool addKH(KHACHHANG kh)
        {
            return khachHangDAL.addKH(kh);
        }

        public bool deleteKH(string id)
        {
            return khachHangDAL.deleteKH(id);
        }

        public bool updateKH(KHACHHANG k)
        {
            return khachHangDAL.updateKH(k);
        }

        public int countKH()
        {
            return khachHangDAL.listKH().Count();
        }

        public List<KhachHangDTO> searchKhachHang(string textSearch)
        {
            List<KhachHangDTO> danhSachKH = khachHangDAL.listKH().Select(p => new KhachHangDTO { ID_KH = p.ID_KH, TENKH = p.TENKH, NGAYSINH = DateTime.Parse(p.NGAYSINH.ToString()), SDT = p.SDT, DIACHI = p.DIACHI, NGAYTHAMGIA = DateTime.Parse(p.NGAYTHAMGIA.ToString()) }).ToList<KhachHangDTO>();

            var ketQuaTimKiem = danhSachKH
                .Where(nv => nv.TENKH.IndexOf(textSearch, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return ketQuaTimKiem;
        }

        public KhachHangNguoiDungDTO detailKH(string id)
        {
            List<KHACHHANG> listKH = khachHangDAL.listKH();
            List<NGUOIDUNG> listND = nguoiDungDAL.listNguoiDung();
            return listKH.Join(listND, p => p.ID_ND, q => q.ID_ND, (p, q) => new KhachHangNguoiDungDTO { KhachHang = p, NguoiDung = q }).Where(k => k.KhachHang.ID_KH == id).FirstOrDefault();
        }

        public string getTenKHByID(string id) 
        { 
            return khachHangDAL.listKH().Where(p => p.ID_KH == id).Select(p => p.TENKH).FirstOrDefault();
        }
    }
}
