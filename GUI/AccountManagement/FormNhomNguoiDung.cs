using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.UserManagement
{
    public partial class FormNhomNguoiDung : Form
    {
        NhomNguoiDungBLL nhomNguoiDungBLL = new NhomNguoiDungBLL();
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        ManHinhBLL manHinhBLL = new ManHinhBLL();
        public FormNhomNguoiDung()
        {
            InitializeComponent();
            this.Load += FormNhomNguoiDung_Load;
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
            this.dgvNND.SelectionChanged += DgvNND_SelectionChanged;
        }

        private void DgvNND_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNND.SelectedRows.Count > 0)
            {
                txtMaNhom.Text = dgvNND.CurrentRow.Cells[0].Value.ToString();
                txtTenNhom.Text = dgvNND.CurrentRow.Cells[1].Value.ToString();
                txtGhiChu.Text = dgvNND.CurrentRow.Cells[2].Value.ToString();
            }    
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            QL_NhomNguoiDung nnd = new QL_NhomNguoiDung();
            nnd.MaNhom = txtMaNhom.Text;
            nnd.TenNhom = txtTenNhom.Text;
            nnd.GhiChu = txtGhiChu.Text;
            if (nhomNguoiDungBLL.updateNND(nnd))
            {
                LoadNND();
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            List<DM_ManHinh> listMH = manHinhBLL.listMH();
            string MaNhom = txtMaNhom.Text;

            foreach (var item in listMH)
            {
                QL_PhanQuyen pq = new QL_PhanQuyen();
                pq.MaNhomNguoiDung = txtMaNhom.Text;
                pq.MaManHinh = item.MaManHinh;
                pq.CoQuyen = false;
                phanQuyenBLL.deletePQ(MaNhom, item.MaManHinh);
            }

            if (nhomNguoiDungBLL.deleteNND(MaNhom))
            {
                LoadNND();
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            List<DM_ManHinh> listMH = manHinhBLL.listMH();
            QL_NhomNguoiDung nnd = new QL_NhomNguoiDung();
            nnd.MaNhom = txtMaNhom.Text;
            nnd.TenNhom = txtTenNhom.Text;
            nnd.GhiChu = txtGhiChu.Text;
            if(nhomNguoiDungBLL.addNND(nnd))
            {
                LoadNND();
                MessageBox.Show("Thao tác thành công");
                foreach(var item in listMH)
                {
                    QL_PhanQuyen pq = new QL_PhanQuyen();
                    pq.MaNhomNguoiDung = txtMaNhom.Text;
                    pq.MaManHinh = item.MaManHinh;
                    pq.CoQuyen = false;
                    phanQuyenBLL.addPQ(pq);
                }    
            }    
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }    
        }

        private void FormNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadNND();
        }

        public void LoadNND()
        {
            dgvNND.DataSource = nhomNguoiDungBLL.listNND();
            dgvNND.Columns["MaNhom"].HeaderText = "Mã nhóm";
            dgvNND.Columns["TenNhom"].HeaderText = "Tên nhóm";
            dgvNND.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvNND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
