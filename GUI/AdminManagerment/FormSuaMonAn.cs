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

namespace GUI.AdminManagerment
{
    public partial class FormSuaMonAn : Form
    {
        MonAnBLL monAnBLL = new MonAnBLL();
        public string idMonAn { get; set; }
        public FormSuaMonAn()
        {
            InitializeComponent();
            this.uc_FormMonAn1.RequestClose += Uc_FormMonAn1_RequestClose;
            this.btnNgungKD.Click += BtnNgungKD_Click;
            this.Load += FormSuaMonAn_Load;
        }

        private void FormSuaMonAn_Load(object sender, EventArgs e)
        {
            uc_FormMonAn1.initialMonAn = monAnBLL.getMonAnById(idMonAn);
            uc_FormMonAn1.loadSuaMonAn();
        }

        private void BtnNgungKD_Click(object sender, EventArgs e)
        {
            MONAN m = monAnBLL.getMonAnById(idMonAn);
            m.TRANGTHAI = "Ngung kinh doanh";
            if(monAnBLL.updateMonAn(m))
            {
                MessageBox.Show("Thao tác thành công");
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void Uc_FormMonAn1_RequestClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
