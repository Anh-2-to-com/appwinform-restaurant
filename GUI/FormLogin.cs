using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CenterToScreen();
            uc_Login1.GetChange_DN += Uc_Login1_GetChange_DN;
            uc_Login1.RequestClose += Uc_Login1_RequestClose;
        }

        private void Uc_Login1_RequestClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uc_Login1_GetChange_DN(object sender, EventArgs e)
        {
            if(uc_Login1.TT == true)
            {
                if(Program.formMain == null || Program.formMain.IsDisposed)
                {
                    Program.formMain = new FormMain();
                }
                this.Visible = false;
                Program.formMain.TenDangNhap = uc_Login1.TenDangNhap;
                Program.formMain.Show();
            }    
        }
    }
}
