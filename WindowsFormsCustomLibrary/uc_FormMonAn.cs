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

namespace WindowsFormsCustomLibrary
{
    public partial class uc_FormMonAn : UserControl
    {
        MonAnBLL monAnBLL = new MonAnBLL();
        public event EventHandler RequestClose;
        public MONAN initialMonAn { get; set; }
        public bool isCheckEditing = true;
        public uc_FormMonAn()
        {
            InitializeComponent();
            this.btnHinhAnh.Click += BtnHinhAnh_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.Load += FormThemNhanVien_Load;
            this.btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (isCheckEditing)
            {
                string numberString = monAnBLL.getIdLastMonAn();
                string prefix = "";
                string newNumberString = AutoGenerateID.CreateID(numberString, prefix);
                if (newNumberString != null)
                {
                    MONAN m = new MONAN();
                    m.ID_MONAN = newNumberString;
                    m.TENMON = txtTenMA.Text;
                    m.DONGIA = decimal.Parse(txtDonGia.Text);
                    m.LOAI = cboLoaiMon.SelectedValue.ToString();
                    m.TRANGTHAI = "Dang kinh doanh";
                    if (monAnBLL.addMonAn(m))
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
                MONAN m = new MONAN();
                m.ID_MONAN = initialMonAn.ID_MONAN;
                m.TENMON = txtTenMA.Text;
                m.DONGIA = decimal.Parse(txtDonGia.Text);
                m.LOAI = cboLoaiMon.SelectedValue.ToString();
                m.TRANGTHAI = "Dang kinh doanh";
                if (monAnBLL.updateMonAn(m))
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
            loadCboLoaiMA();
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

        public void loadCboLoaiMA()
        {
            List<string> listLoaiMA = new List<string>()
            {
                "Aries","Taurus","Gemini","Cancer","Leo","Virgo",
                "Libra","Scorpio","Sagittarius","Capricorn","Aquarius", "Pisces"
            };

            cboLoaiMon.DataSource = listLoaiMA;
        }

        public void loadSuaMonAn()
        {
            txtTenMA.Text = initialMonAn.TENMON;
            txtDonGia.Text = initialMonAn.DONGIA.ToString();
            pictureBox1.ImageLocation = $"E:/Nam_4/HK1/PTPM_AI/DoAnPTPM_AI/Icons/Food/{initialMonAn.LOAI}/{initialMonAn.ID_MONAN}.jpg";
            isCheckEditing = false;
        }
    }
}
