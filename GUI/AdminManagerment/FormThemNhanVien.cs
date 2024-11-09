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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.AdminManagerment
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
            uc_FormNhanVien2.RequestClose += Uc_FormNhanVien2_RequestClose;
        }

        private void Uc_FormNhanVien2_RequestClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
