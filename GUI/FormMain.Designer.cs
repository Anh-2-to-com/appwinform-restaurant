namespace GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQLNND = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQLPQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemND = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHT,
            this.quảnLýBànToolStripMenuItem,
            this.menuItemTK,
            this.menuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1141, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemHT
            // 
            this.menuItemHT.BackColor = System.Drawing.Color.Bisque;
            this.menuItemHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQLNND,
            this.menuItemQLMH,
            this.menuItemQLPQ,
            this.menuItemND});
            this.menuItemHT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemHT.Name = "menuItemHT";
            this.menuItemHT.Size = new System.Drawing.Size(110, 28);
            this.menuItemHT.Tag = "MH001";
            this.menuItemHT.Text = "Hệ thống";
            // 
            // menuItemQLNND
            // 
            this.menuItemQLNND.Name = "menuItemQLNND";
            this.menuItemQLNND.Size = new System.Drawing.Size(343, 28);
            this.menuItemQLNND.Tag = "MH001";
            this.menuItemQLNND.Text = "Quản lý nhóm người dùng";
            // 
            // menuItemQLMH
            // 
            this.menuItemQLMH.Name = "menuItemQLMH";
            this.menuItemQLMH.Size = new System.Drawing.Size(343, 28);
            this.menuItemQLMH.Tag = "MH002";
            this.menuItemQLMH.Text = "Quản lý màn hình";
            // 
            // menuItemQLPQ
            // 
            this.menuItemQLPQ.Name = "menuItemQLPQ";
            this.menuItemQLPQ.Size = new System.Drawing.Size(343, 28);
            this.menuItemQLPQ.Tag = "MH003";
            this.menuItemQLPQ.Text = "Quản lý phân quyền";
            // 
            // menuItemND
            // 
            this.menuItemND.Name = "menuItemND";
            this.menuItemND.Size = new System.Drawing.Size(343, 28);
            this.menuItemND.Tag = "MH004";
            this.menuItemND.Text = "Quản lý người dùng";
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.quảnLýBànToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNhanSu,
            this.menuItemKhachHang,
            this.menuItemThucDon,
            this.menuItemHoaDon});
            this.quảnLýBànToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.quảnLýBànToolStripMenuItem.Tag = "MH002";
            this.quảnLýBànToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // menuItemNhanSu
            // 
            this.menuItemNhanSu.Name = "menuItemNhanSu";
            this.menuItemNhanSu.Size = new System.Drawing.Size(283, 28);
            this.menuItemNhanSu.Text = "Quản lý nhân sự";
            // 
            // menuItemKhachHang
            // 
            this.menuItemKhachHang.Name = "menuItemKhachHang";
            this.menuItemKhachHang.Size = new System.Drawing.Size(283, 28);
            this.menuItemKhachHang.Text = "Quản lý khách hàng";
            // 
            // menuItemThucDon
            // 
            this.menuItemThucDon.Name = "menuItemThucDon";
            this.menuItemThucDon.Size = new System.Drawing.Size(283, 28);
            this.menuItemThucDon.Text = "Quản lý thực đơn";
            // 
            // menuItemHoaDon
            // 
            this.menuItemHoaDon.Name = "menuItemHoaDon";
            this.menuItemHoaDon.Size = new System.Drawing.Size(283, 28);
            this.menuItemHoaDon.Text = "Quản lý hóa đơn";
            // 
            // menuItemTK
            // 
            this.menuItemTK.BackColor = System.Drawing.Color.Bisque;
            this.menuItemTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemTK.Name = "menuItemTK";
            this.menuItemTK.Size = new System.Drawing.Size(117, 28);
            this.menuItemTK.Text = "Tài khoản";
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.BackColor = System.Drawing.Color.Bisque;
            this.menuItemLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemLogout.Name = "menuItemLogout";
            this.menuItemLogout.Size = new System.Drawing.Size(120, 28);
            this.menuItemLogout.Text = "Đăng xuất";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 610);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemHT;
        private System.Windows.Forms.ToolStripMenuItem menuItemQLNND;
        private System.Windows.Forms.ToolStripMenuItem menuItemQLMH;
        private System.Windows.Forms.ToolStripMenuItem menuItemQLPQ;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemND;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhanSu;
        private System.Windows.Forms.ToolStripMenuItem menuItemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuItemThucDon;
        private System.Windows.Forms.ToolStripMenuItem menuItemHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem menuItemTK;
    }
}