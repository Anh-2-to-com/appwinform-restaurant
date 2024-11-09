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

namespace WindowsFormsCustomLibrary
{
    public partial class uc_FormNhanVien : UserControl
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public event EventHandler RequestClose;
        public NHANVIEN initialNhanVien { get; set; }
        public bool isCheckEditing = true;
        public uc_FormNhanVien()
        {
            InitializeComponent();
            this.btnHinhAnh.Click += BtnHinhAnh_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.Load += FormThemNhanVien_Load;
            this.btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if(isCheckEditing)
            {
                string numberString = nhanVienBLL.getIdLastNV();
                string prefix = "NV";
                string newNumberString = AutoGenerateID.CreateID(numberString, prefix);
                if (newNumberString != null)
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.ID_NV = newNumberString;
                    nv.TENNV = txtTenNV.Text;
                    nv.NGAYVAOLAM = DateTime.Parse(dateTimeNVL.Value.ToString("yyyy-MM-dd"));
                    nv.SDT = txtSDT.Text;
                    nv.CHUCVU = cboChucVu.SelectedValue.ToString();
                    nv.ID_NQL = cboNQL.SelectedValue.ToString();
                    nv.TINHTRANG = "Đang làm việc";
                    nv.HINHANH = pictureBox1.ImageLocation;
                    if (nhanVienBLL.addND(nv))
                    {
                        MessageBox.Show("Thao tác thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thao tác không thành công");
                    }
                }
                else
                {
                    Console.WriteLine("Lỗi không thể tạo ID người dùng");
                }
            }    
            else
            {
                NHANVIEN nv = new NHANVIEN();
                nv.ID_NV = initialNhanVien.ID_NV;
                nv.TENNV = txtTenNV.Text;
                nv.NGAYVAOLAM = DateTime.Parse(dateTimeNVL.Value.ToString("yyyy-MM-dd"));
                nv.SDT = txtSDT.Text;
                nv.CHUCVU = cboChucVu.SelectedValue.ToString();
                nv.ID_NQL = cboNQL.SelectedValue.ToString();
                nv.TINHTRANG = "Đang làm việc";
                nv.HINHANH = pictureBox1.ImageLocation;
                if(nhanVienBLL.updateND(nv))
                {
                    MessageBox.Show("Thao tác thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác không thành công");
                }
            }    
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            loadCboChucVu();
            loadCboNQL();
            dateTimeNVL.Format = DateTimePickerFormat.Custom;
            dateTimeNVL.CustomFormat = "dd-MM-yyyy"; // Định dạng năm-tháng-ngày
            pictureBox1.ImageLocation = "E:/Nam_4/HK1/PTPM_AI/DoAnPTPM_AI/Icons/anhbatocom.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            RequestClose.Invoke(this, EventArgs.Empty);
        }

        private void BtnHinhAnh_Click(object sender, EventArgs e)
        {
            string selectedImagePath = ChonAnh(pictureBox1);
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Chọn ảnh thành công");
            }
            else
            {
                MessageBox.Show("Không có ảnh nào được chọn.");
            }
        }

        // Phương thức mở hộp thoại để chọn ảnh và trả về đường dẫn ảnh
        public string ChonAnh(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Chỉ định bộ lọc để chỉ hiển thị các tệp ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Chọn ảnh";

                // Mở hộp thoại và kiểm tra nếu người dùng đã chọn tệp
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox (nếu có)
                    if (pictureBox != null)
                    {
                        pictureBox.ImageLocation = imagePath;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    // Trả về đường dẫn ảnh đã chọn
                    return imagePath;
                }
            }

            // Trả về null nếu người dùng không chọn ảnh
            return null;
        }

        public void loadCboChucVu()
        {
            List<ChucVuItemDTO> chucVuItems = new List<ChucVuItemDTO>
            {
                new ChucVuItemDTO("Phục vụ", "Phuc vu"),
                new ChucVuItemDTO("Tiếp tân", "Tiep tan"),
                new ChucVuItemDTO("Thu ngân", "Thu ngan"),
                new ChucVuItemDTO("Bếp", "Bep"),
                new ChucVuItemDTO("Kho", "Kho"),
                new ChucVuItemDTO("Quản lý", "Quan ly")
            };

            cboChucVu.DataSource = chucVuItems;
            cboChucVu.DisplayMember = "Display";
            cboChucVu.ValueMember = "Value";

        }

        public void loadCboNQL()
        {
            cboNQL.DataSource = nhanVienBLL.getListNVQuanLy();
            cboNQL.DisplayMember = "TENNV";
            cboNQL.ValueMember = "ID_NV";
        }

        public void loadSuaNhanVien()
        {
            txtTenNV.Text = initialNhanVien.TENNV;
            txtSDT.Text = initialNhanVien.SDT;
            dateTimeNVL.Value = initialNhanVien.NGAYVAOLAM;
            cboChucVu.SelectedValue = initialNhanVien.CHUCVU;
            if (initialNhanVien.ID_NQL != null)
            {
                cboNQL.SelectedValue = initialNhanVien.ID_NQL;
            }
            else
            {
                cboNQL.SelectedIndex = -1;
            }
            pictureBox1.ImageLocation = initialNhanVien.HINHANH;
            isCheckEditing = false;
        }
    }
}
