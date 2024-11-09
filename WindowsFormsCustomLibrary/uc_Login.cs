using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WindowsFormsCustomLibrary
{
    public partial class uc_Login : UserControl
    {
        NguoiDungBLL CauHinh = new NguoiDungBLL();
        public event EventHandler GetChange_DN;
        public event EventHandler RequestClose;
        public bool TT { get; set; }
        public string TenDangNhap { get; set; }

        public uc_Login()
        {
            InitializeComponent();
            this.btnLogin.Click += BtnLogin_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           RequestClose.Invoke(this, EventArgs.Empty);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + txtUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống" + txtPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
           
            ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            
        }

        public void ProcessLogin()
        {
            TT = false;
            LoginResult result;
            result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " + lblPassword.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            //Thanh cong
            TT = true;
            TenDangNhap = txtUsername.Text;
            GetChange_DN.Invoke(this, EventArgs.Empty);
        }
    }
}


