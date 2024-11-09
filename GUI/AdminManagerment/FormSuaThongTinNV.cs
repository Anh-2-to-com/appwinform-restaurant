using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AdminManagerment
{
    public partial class FormSuaThongTinNV : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public string idNV {  get; set; }
        public FormSuaThongTinNV()
        {
            InitializeComponent();
            this.Load += FormSuaThongTinNV_Load;
            this.uc_FormNhanVien1.RequestClose += Uc_FormNhanVien1_RequestClose;
            this.btnNghiViec.Click += BtnNghiViec_Click;
        }

        private void BtnNghiViec_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = nhanVienBLL.getNVById(idNV);
            nv.TINHTRANG = "Đã nghỉ việc";
            if(nhanVienBLL.updateND(nv))
            {
                MessageBox.Show("Thao tác thành công");
            }    
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }    
        }

        private void Uc_FormNhanVien1_RequestClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuaThongTinNV_Load(object sender, EventArgs e)
        {
            NHANVIEN nv = nhanVienBLL.getNVById(idNV);
            uc_FormNhanVien1.initialNhanVien = nv;
            uc_FormNhanVien1.loadSuaNhanVien();
        }
    }
}
