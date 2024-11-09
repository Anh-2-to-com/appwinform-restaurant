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
    public partial class FormDangKyNguoiDung : Form
    {
        NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
        public FormDangKyNguoiDung()
        {
            InitializeComponent();
            this.btnCancel.Click += BtnCancel_Click;
            this.btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;

            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show(lblemail.Text + " không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(lblPass.Text + " không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show(lblConfirmPass.Text + " không được để trống");
                return;
            }

            if(password.Equals(confirmPass))
            {
                string numberString = nguoiDungBLL.getIdLastND();
                string prefix = "ND";
                string newNumberString = AutoGenerateID.CreateID(numberString, prefix);
                if (newNumberString != null) 
                { 
                    NGUOIDUNG nd = new NGUOIDUNG();
                    nd.ID_ND = newNumberString;
                    nd.EMAIL = email;
                    nd.MATKHAU = password;
                    nd.VAITRO = null;
                    nd.HOATDONG = true;
                    if(nguoiDungBLL.addND(nd))
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
                MessageBox.Show("Mật khẩu không hợp lệ");
            }    
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
