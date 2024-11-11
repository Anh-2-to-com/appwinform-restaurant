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
    public partial class FormKhachHang : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public FormKhachHang()
        {
            InitializeComponent();
            this.Load += FormKhachHang_Load;
            this.txtTimKiem.KeyUp += TxtTimKiem_KeyUp;
            this.btnViewKH.Click += BtnViewKH_Click;
            this.btnViewHD.Click += BtnViewHD_Click;
        }

        private void BtnViewHD_Click(object sender, EventArgs e)
        {
            FormViewHoaDonKH frm = new FormViewHoaDonKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.idKH = dgvKH.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void BtnViewKH_Click(object sender, EventArgs e)
        {
            FormDetailKhachHang frm = new FormDetailKhachHang();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.idKH = dgvKH.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void TxtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            loadSearchKH(txtTimKiem.Text);
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
            txtSLKH.Text = $"{khachHangBLL.countKH()} khách hàng";
            txtTimKiem.PlaceholderText = "Tìm kiếm khách hàng";
        }

        public void loadKH()
        {
            dgvKH.DataSource = khachHangBLL.listKH();
            dgvKH.Columns["ID_KH"].HeaderText = "Mã khách hàng";
            dgvKH.Columns["TENKH"].HeaderText = "Tên khách hàng";
            dgvKH.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvKH.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKH.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvKH.Columns["NGAYTHAMGIA"].HeaderText = "Ngày tham gia";
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadSearchKH(string txtSearch)
        {
            dgvKH.DataSource = khachHangBLL.searchKhachHang(txtSearch);
            dgvKH.Columns["ID_KH"].HeaderText = "Mã khách hàng";
            dgvKH.Columns["TENKH"].HeaderText = "Tên khách hàng";
            dgvKH.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvKH.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvKH.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvKH.Columns["NGAYTHAMGIA"].HeaderText = "Ngày tham gia";
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
