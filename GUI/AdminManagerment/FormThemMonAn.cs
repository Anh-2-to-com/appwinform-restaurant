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
    public partial class FormThemMonAn : Form
    {
        public FormThemMonAn()
        {
            InitializeComponent();
            uc_FormMonAn1.RequestClose += Uc_FormMonAn1_RequestClose;
        }

        private void Uc_FormMonAn1_RequestClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
