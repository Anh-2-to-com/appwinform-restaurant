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
using DTO;

namespace GUI.UserManagement
{
    public partial class FormManHinh : Form
    {
        ManHinhBLL manHinhBLL = new ManHinhBLL();
        NhomNguoiDungBLL nhomNguoiDungBLL = new NhomNguoiDungBLL();
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public FormManHinh()
        {
            InitializeComponent();
            this.Load += FormManHinh_Load;
            this.btnThem.Click += BtnThem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
            this.dgvMH.SelectionChanged += DgvMH_SelectionChanged;
        }

        private void DgvMH_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMH.SelectedRows.Count > 0)
            {
                txtMaMH.Text = dgvMH.CurrentRow.Cells[0].Value.ToString();
                txtTenMH.Text = dgvMH.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DM_ManHinh mh = new DM_ManHinh();
            mh.MaManHinh = txtMaMH.Text;
            mh.TenManHinh = txtTenMH.Text;
            if (manHinhBLL.updateMH(mh))
            {
                LoadMH();
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            List<QL_NhomNguoiDung> list = nhomNguoiDungBLL.listNND();
            string maMH = txtMaMH.Text;
            foreach (var item in list)
            {
                phanQuyenBLL.deletePQ(item.MaNhom, maMH);
            }
            if (manHinhBLL.deleteMH(maMH))
            {
                LoadMH();
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            List<QL_NhomNguoiDung> list = nhomNguoiDungBLL.listNND();
            DM_ManHinh mh = new DM_ManHinh();
            mh.MaManHinh = txtMaMH.Text;
            mh.TenManHinh = txtTenMH.Text;
            if(manHinhBLL.addMH(mh))
            {
                LoadMH();
                foreach(var item in list)
                {
                    QL_PhanQuyen p = new QL_PhanQuyen();
                    p.MaManHinh = txtMaMH.Text;
                    p.MaNhomNguoiDung = item.MaNhom;
                    p.CoQuyen = false;
                    phanQuyenBLL.addPQ(p);
                }    
                MessageBox.Show("Thao tác thành công");
            }    
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }    
        }

        private void FormManHinh_Load(object sender, EventArgs e)
        {
            LoadMH();
        }

        public void LoadMH()
        {
            dgvMH.DataSource = manHinhBLL.listMH();
            dgvMH.Columns["MaManHinh"].HeaderText = "Mã màn hình";
            dgvMH.Columns["TenManHinh"].HeaderText = "Tên màn hình";
            dgvMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
