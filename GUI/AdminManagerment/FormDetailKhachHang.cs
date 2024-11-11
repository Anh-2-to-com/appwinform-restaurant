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
    public partial class FormDetailKhachHang : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public string idKH { get; set; }
        public FormDetailKhachHang()
        {
            InitializeComponent();
            this.Load += FormDetailKhachHang_Load;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetailKhachHang_Load(object sender, EventArgs e)
        {
            dateTimeNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimeNgaySinh.CustomFormat = "dd-MM-yyyy";
            dateTimeNTG.Format = DateTimePickerFormat.Custom;
            dateTimeNTG.CustomFormat = "dd-MM-yyyy";
            txtTenKH.Enabled = false;
            dateTimeNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            dateTimeNTG.Enabled = false;
            txtEmail.Enabled = false;
            txtVaitro.Enabled = false;
            txtTrangthai.Enabled = false;
            loadDetailKH();
        }

        public void loadDetailKH()
        {
            KhachHangNguoiDungDTO khnd = khachHangBLL.detailKH(idKH);
            pictureBox1.ImageLocation = "E:/Nam_4/HK1/PTPM_AI/DoAnPTPM_AI/Icons/anhbatocom.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            txtTenKH.Text = khnd.KhachHang.TENKH;
            dateTimeNgaySinh.Value = khnd.KhachHang.NGAYSINH.Value;
            txtSDT.Text = khnd.KhachHang.SDT;
            txtDiaChi.Text = khnd.KhachHang.DIACHI;
            dateTimeNTG.Value = khnd.KhachHang.NGAYTHAMGIA;
            txtEmail.Text = khnd.NguoiDung.EMAIL;
            txtVaitro.Text = khnd.NguoiDung.VAITRO;
            txtTrangthai.Text = bool.Parse(khnd.NguoiDung.HOATDONG.ToString()) ? "Hoạt động" : "Ngừng hoạt động";
        }
    }
}
