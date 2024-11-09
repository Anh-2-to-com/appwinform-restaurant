using DTO;
using GUI.UserManagement;
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
using GUI.AdminManagerment;

namespace GUI
{
    public partial class FormMain : Form
    {

        public string TenDangNhap { get; set; } 
        NguoiDungNNnguoiDungBLL nguoiDungNNnguoiDungBLL = new NguoiDungNNnguoiDungBLL();
        PhanQuyenBLL phanQuyenBLL = new PhanQuyenBLL();

        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosed += FormMain_FormClosed;
            this.menuItemQLNND.Click += MenuItemQLNND_Click;
            this.menuItemQLMH.Click += MenuItemQLMH_Click;
            this.menuItemQLPQ.Click += MenuItemQLPQ_Click;
            this.menuItemND.Click += MenuItemND_Click;
            this.Load += FormMain_Load;
            this.menuItemNhanSu.Click += MenuItemNhanSu_Click;
            this.menuItemLogout.Click += MenuItemLogout_Click;
            this.menuItemThucDon.Click += MenuItemThucDon_Click;
        }

        private void MenuItemThucDon_Click(object sender, EventArgs e)
        {
            FormThucDon frm = new FormThucDon();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuItemNhanSu_Click(object sender, EventArgs e)
        {
            FormNhanSu frm = new FormNhanSu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<string> nhomND = nguoiDungNNnguoiDungBLL.getMaNNDByTenDangNhap(TenDangNhap);
            foreach (string item in nhomND)
            {
                List<PhanQuyenDTO> dsQuyen = phanQuyenBLL.getListPQByMaNND(item);
                foreach (var mh in dsQuyen)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items, mh.MaMH, bool.Parse(mh.CoQuyen.ToString()));
                }
            }
        }

        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        private void MenuItemND_Click(object sender, EventArgs e)
        {
            FormNguoiDung frm = new FormNguoiDung();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void MenuItemQLPQ_Click(object sender, EventArgs e)
        {
            FormPhanQuyen frm = new FormPhanQuyen();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void MenuItemQLMH_Click(object sender, EventArgs e)
        {
            FormManHinh frm = new FormManHinh();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void MenuItemQLNND_Click(object sender, EventArgs e)
        {
            FormNhomNguoiDung frm = new FormNhomNguoiDung();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formLogin.Show();
        }
    }
}
