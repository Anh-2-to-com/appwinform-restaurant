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
    public partial class FormDetailHoaDon : Form
    {
        public string idKH { get; set; }
        public string idHD { get; set; }
        ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
        public FormDetailHoaDon()
        {
            InitializeComponent();
            this.Load += FormDetailHoaDon_Load;
            this.btnClose.Click += BtnClose_Click;
            this.btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormViewHoaDonKH frm = new FormViewHoaDonKH();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.idKH = idKH;
            frm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetailHoaDon_Load(object sender, EventArgs e)
        {
            loadCTHD();
        }

        public void loadCTHD()
        {
            dgvCTHD.DataSource = chiTietHDBLL.listCTHD();
            dgvCTHD.Columns["TenMonAn"].HeaderText = "Tên món ăn";
            dgvCTHD.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvCTHD.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
