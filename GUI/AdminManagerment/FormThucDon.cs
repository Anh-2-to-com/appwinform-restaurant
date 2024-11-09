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
    public partial class FormThucDon : Form
    {
        MonAnBLL monAnBLL = new MonAnBLL();
        public FormThucDon()
        {
            InitializeComponent();
            this.Load += FormThucDon_Load;
            this.dgvMonAn.CellFormatting += DgvMonAn_CellFormatting;
            this.btnAddMA.Click += BtnAddMA_Click;
            this.btnUpdateMA.Click += BtnUpdateMA_Click;
            this.txtTimKiem.KeyUp += TxtTimKiem_KeyUp;
        }

        private void TxtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            loadSearchMA(txtTimKiem.Text);
        }

        private void BtnUpdateMA_Click(object sender, EventArgs e)
        {
            FormSuaMonAn frm = new FormSuaMonAn();
            frm.idMonAn = dgvMonAn.CurrentRow.Cells[0].Value.ToString();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadMonAn();
        }

        private void BtnAddMA_Click(object sender, EventArgs e)
        {
            FormThemMonAn frm = new FormThemMonAn();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadMonAn();
        }

        private void DgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMonAn.Columns[e.ColumnIndex].Name == "DONGIA" && e.Value != null)
            {
                // Định dạng thành chuỗi với dấu phẩy ngăn cách và thêm "đ" vào cuối
                e.Value = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            loadMonAn();
            txtSLMon.Text = $"{monAnBLL.countMonAn()} món";
            txtTimKiem.PlaceholderText = "Tìm kiếm món ăn";
        }

        public void loadMonAn()
        {
            List<MONAN> list = monAnBLL.listMonAn();
            dgvMonAn.DataSource = list;
            dgvMonAn.Columns["ID_MONAN"].HeaderText = "Mã món ăn";
            dgvMonAn.Columns["TENMON"].HeaderText = "Tên món ăn";
            dgvMonAn.Columns["DONGIA"].HeaderText = "Đơn giá";
            dgvMonAn.Columns["LOAI"].HeaderText = "Loại món";
            dgvMonAn.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void loadSearchMA(string txtSearch)
        {
            dgvMonAn.DataSource = monAnBLL.searchMonAn(txtSearch);
            dgvMonAn.Columns["ID_MONAN"].HeaderText = "Mã món ăn";
            dgvMonAn.Columns["TENMON"].HeaderText = "Tên món ăn";
            dgvMonAn.Columns["DONGIA"].HeaderText = "Đơn giá";
            dgvMonAn.Columns["LOAI"].HeaderText = "Loại món";
            dgvMonAn.Columns["TRANGTHAI"].HeaderText = "Trạng thái";
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
