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

namespace GUI.UserManagement
{
    public partial class FormPhanQuyen : Form
    {
        NhomNguoiDungBLL nhomNguoiDungBLL = new NhomNguoiDungBLL();
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();
        public FormPhanQuyen()
        {
            InitializeComponent();
            this.Load += FormPhanQuyen_Load;
            this.dgvNND.SelectionChanged += DgvNND_SelectionChanged;
            this.btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNND = dgvNND.CurrentRow.Cells[0].Value.ToString();
                for (int i = 0; i < dgvPQ.RowCount; i++)
                {
                    QL_PhanQuyen qL_PhanQuyen = new QL_PhanQuyen();
                    qL_PhanQuyen.MaNhomNguoiDung = MaNND;
                    qL_PhanQuyen.MaManHinh = dgvPQ.Rows[i].Cells[0].Value.ToString();
                    qL_PhanQuyen.CoQuyen = bool.Parse(dgvPQ.Rows[i].Cells[2].Value.ToString());
                    phanQuyenBLL.updatePQ(qL_PhanQuyen);
                }
                loadPQ(MaNND);
                MessageBox.Show("Thao tác thành công");
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại");
            }
        }

        private void DgvNND_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvNND.SelectedRows.Count > 0)
            {
                string id = dgvNND.CurrentRow.Cells[0].Value.ToString();
                loadPQ(id);
            }    
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            loadNND();
        }

        public void loadNND()
        {
            dgvNND.DataSource = nhomNguoiDungBLL.listNND();
            dgvNND.Columns["MaNhom"].HeaderText = "Mã nhóm";
            dgvNND.Columns["TenNhom"].HeaderText = "Tên nhóm";
            dgvNND.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvNND.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void loadPQ(string id)
        {
            dgvPQ.DataSource = phanQuyenBLL.getListPQByMaNND(id);
            dgvPQ.Columns["MaMH"].HeaderText = "Mã màn hình";
            dgvPQ.Columns["TenMH"].HeaderText = "Tên tên màn hình";

            // Xóa cột "CoQuyen" nếu nó đã tồn tại
            if (dgvPQ.Columns.Contains("CoQuyen"))
            {
                dgvPQ.Columns.Remove("CoQuyen");
            }

            // Thêm lại cột checkbox mới
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "CoQuyen";
            checkBoxColumn.HeaderText = "Có quyền";
            checkBoxColumn.DataPropertyName = "CoQuyen"; // Gán dữ liệu cho cột
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;

            dgvPQ.Columns.Add(checkBoxColumn);
            dgvPQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


    }
}
