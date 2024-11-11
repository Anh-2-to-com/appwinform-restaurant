using BLL;
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
    public partial class FormViewHoaDonKH : Form
    {
        public string idKH { get; set; }
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL(); 
        public FormViewHoaDonKH()
        {
            InitializeComponent();
            this.Load += FormViewHoaDonKH_Load;
            this.btnClose.Click += BtnClose_Click;
            this.btnDetailHD.Click += BtnDetailHD_Click;
        }

        private void BtnDetailHD_Click(object sender, EventArgs e)
        {
            FormDetailHoaDon frm = new FormDetailHoaDon();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.idKH = idKH;
            frm.idHD = dgvHD.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormViewHoaDonKH_Load(object sender, EventArgs e)
        {
            txtTenKH.Text = khachHangBLL.getTenKHByID(idKH);
            loadHD();
        }

        public void loadHD()
        {
            dgvHD.DataSource = hoaDonBLL.getListHDByIdKH(idKH);
            dgvHD.Columns["ID_HOADON"].HeaderText = "Mã hóa đơn";
            dgvHD.Columns["ID_KH"].HeaderText = "Mã khách hàng";
            dgvHD.Columns["ID_BAN"].HeaderText = "Mã bàn";
            dgvHD.Columns["TONGTIEN"].HeaderText = "Tổng tiền";
            dgvHD.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
