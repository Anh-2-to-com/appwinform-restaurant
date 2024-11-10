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
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
            txtSLKH.Text = $"{khachHangBLL.countKH()} khách hàng";
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
    }
}
