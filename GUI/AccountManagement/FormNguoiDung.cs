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
    public partial class FormNguoiDung : Form
    {
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        NhomNguoiDungBLL nhomNguoiDungBLL = new NhomNguoiDungBLL();
        NguoiDungNNnguoiDungBLL nguoiDungNNnguoiDungBLL = new NguoiDungNNnguoiDungBLL();
        public FormNguoiDung()
        {
            InitializeComponent();
            this.Load += FormNguoiDung_Load;
            this.dgvND.CellFormatting += DgvND_CellFormatting;
            this.dgvND.SelectionChanged += DgvND_SelectionChanged;
            this.dgvNDNND.CellFormatting += DgvNDNND_CellFormatting;
            this.btnThemND.Click += BtnThemND_Click;
            this.btnXoaND.Click += BtnXoaND_Click;
            this.btnSuaND.Click += BtnSuaND_Click;
            this.cboNND.SelectedIndexChanged += CboNND_SelectedIndexChanged;
            this.btnThemNDNND.Click += BtnThemNDNND_Click;
            this.btnXoaNDNND.Click += BtnXoaNDNND_Click;
        }

        private void BtnXoaNDNND_Click(object sender, EventArgs e)
        {
            string MaND = dgvNDNND.CurrentRow.Cells[0].Value.ToString();
            string MaNND = cboNND.SelectedValue.ToString();

            if(string.IsNullOrEmpty(MaND) )
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa");
                return;
            }    
            if(nguoiDungNNnguoiDungBLL.deleteNDNND(MaNND, MaND))
            {
                loadNDByMaNND(MaNND);
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void DgvNDNND_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNDNND.Columns[e.ColumnIndex].Name == "HoatDong" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "Hoạt động" : "Ngừng hoạt động";
                e.FormattingApplied = true;
            }
        }

        private void BtnThemNDNND_Click(object sender, EventArgs e)
        {
            string MaND = txtMaND.Text;
            string MaNND = cboNND.SelectedValue.ToString();
            if(string.IsNullOrEmpty(MaND))
            {
                MessageBox.Show("Vui lòng chọn người dùng để thêm vào nhóm");
                return;
            }
            QL_NguoiDungNhomNguoiDung n = new QL_NguoiDungNhomNguoiDung();
            n.ID_ND = MaND;
            n.MaNhomNguoiDung = MaNND;
            n.GhiChu = null;
            if(nguoiDungNNnguoiDungBLL.addNDNND(n))
            {
                loadNDByMaNND(MaNND);
                MessageBox.Show("Thao tác thành công");
            }    
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }    
        }

        private void CboNND_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboNND.SelectedValue.ToString();
            loadNDByMaNND(id);
        }

        private void BtnSuaND_Click(object sender, EventArgs e)
        {
            NGUOIDUNG nd = new NGUOIDUNG();
            nd.ID_ND = txtMaND.Text;
            nd.EMAIL = txtEmail.Text;
            nd.VAITRO = null;
            nd.HOATDONG = radioHD.Checked ? true : false;
            if (nguoiDungBLL.updateND(nd))
            {
                loadND();
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void BtnXoaND_Click(object sender, EventArgs e)
        {
            string id = txtMaND.Text;
            if(nguoiDungBLL.deleteND(id))
            {
                loadND();
                MessageBox.Show("Thao tác thành công");
            }    
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }    
        }

        private void BtnThemND_Click(object sender, EventArgs e)
        {
            FormDangKyNguoiDung frm = new FormDangKyNguoiDung();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            loadND();
        }

        private void DgvND_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvND.SelectedRows.Count > 0)
            {
                txtMaND.Text = dgvND.CurrentRow.Cells[0].Value.ToString();
                txtEmail.Text = dgvND.CurrentRow.Cells[1].Value.ToString();
                bool isActive = bool.Parse(dgvND.CurrentRow.Cells[2].Value.ToString());
                if(isActive)
                {
                    radioHD.Checked = true;
                }    
                else { radioNHD.Checked = true; }
            }
        }

        private void DgvND_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvND.Columns[e.ColumnIndex].Name == "HoatDong" && e.Value != null)
            {
                bool isActive = (bool)e.Value;
                e.Value = isActive ? "Hoạt động" : "Ngừng hoạt động";
                e.FormattingApplied = true;
            }
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            loadND();
            loadComboboxNND();
        }

        public void loadND()
        {
            dgvND.DataSource = nguoiDungBLL.listNguoiDung();
            dgvND.Columns["ID"].HeaderText = "Mã người dùng";
            dgvND.Columns["Email"].HeaderText = "Email đăng nhập";
            dgvND.Columns["HoatDong"].HeaderText = "Hoạt động";
            dgvND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadComboboxNND()
        {
            cboNND.DataSource = nhomNguoiDungBLL.listNND();
            cboNND.DisplayMember = "TenNhom";
            cboNND.ValueMember = "MaNhom";
        }

        public void loadNDByMaNND(string id)
        {
            dgvNDNND.DataSource = nguoiDungBLL.getNDByMaNND(id);
            dgvNDNND.Columns["ID"].HeaderText = "Mã người dùng";
            dgvNDNND.Columns["Email"].HeaderText = "Email đăng nhập";
            dgvNDNND.Columns["HoatDong"].HeaderText = "Hoạt động";
            dgvNDNND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
