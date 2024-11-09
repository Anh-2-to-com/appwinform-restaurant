using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO;
using BLL;

namespace GUI.AdminManagerment
{
    public partial class FormNhanSu : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public FormNhanSu()
        {
            InitializeComponent();
            this.Load += FormNhanSu_Load;
            this.btnAddNV.Click += BtnAddNV_Click;
            this.btnUpdateNV.Click += BtnUpdateNV_Click;
            this.txtTimKiem.KeyUp += TxtTimKiem_KeyUp;
        }

        private void TxtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            loadSearchNV(txtTimKiem.Text);
        }

        private void BtnUpdateNV_Click(object sender, EventArgs e)
        {
            FormSuaThongTinNV frm = new FormSuaThongTinNV();
            frm.idNV = dgvNV.CurrentRow.Cells[0].Value.ToString();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadNV();
        }

        private void BtnAddNV_Click(object sender, EventArgs e)
        {
            FormThemNhanVien frm = new FormThemNhanVien();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadNV();
        }

        private void FormNhanSu_Load(object sender, EventArgs e)
        {
            txtTimKiem.PlaceholderText = "Tìm kiếm nhân viên";
            loadNV();
        }


        public void loadNV()
        {
            List<NhanVienDTO> list = nhanVienBLL.listND();
            dgvNV.DataSource = list;
            dgvNV.Columns["ID_NV"].HeaderText = "Mã nhân viên";
            dgvNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvNV.Columns["NGAYVAOLAM"].HeaderText = "Ngày vào làm";
            dgvNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNV.Columns["CHUCVU"].HeaderText = "Chức vụ";
            dgvNV.Columns["TINHTRANG"].HeaderText = "Tình trạng";
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void loadSearchNV(string txtSearch)
        {
            List<NhanVienDTO> list = nhanVienBLL.searchNhanVien(txtSearch);
            dgvNV.DataSource = list;
            dgvNV.Columns["ID_NV"].HeaderText = "Mã nhân viên";
            dgvNV.Columns["TENNV"].HeaderText = "Tên nhân viên";
            dgvNV.Columns["NGAYVAOLAM"].HeaderText = "Ngày vào làm";
            dgvNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNV.Columns["CHUCVU"].HeaderText = "Chức vụ";
            dgvNV.Columns["TINHTRANG"].HeaderText = "Tình trạng";
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }   
}
