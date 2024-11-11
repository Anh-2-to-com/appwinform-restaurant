namespace GUI.AdminManagerment
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewHD = new System.Windows.Forms.Button();
            this.btnViewKH = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new CustomClassLibrary.CustomPlaceholderTextbox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSLKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2084, 55);
            this.panel1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(688, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "     Quản lý khách hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btnViewHD);
            this.panel2.Controls.Add(this.btnViewKH);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(132, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 548);
            this.panel2.TabIndex = 38;
            // 
            // btnViewHD
            // 
            this.btnViewHD.BackColor = System.Drawing.Color.White;
            this.btnViewHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHD.Image = ((System.Drawing.Image)(resources.GetObject("btnViewHD.Image")));
            this.btnViewHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewHD.Location = new System.Drawing.Point(799, 27);
            this.btnViewHD.Name = "btnViewHD";
            this.btnViewHD.Size = new System.Drawing.Size(181, 47);
            this.btnViewHD.TabIndex = 39;
            this.btnViewHD.Text = "Xem hóa đơn";
            this.btnViewHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewHD.UseVisualStyleBackColor = false;
            // 
            // btnViewKH
            // 
            this.btnViewKH.BackColor = System.Drawing.Color.White;
            this.btnViewKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewKH.Image = ((System.Drawing.Image)(resources.GetObject("btnViewKH.Image")));
            this.btnViewKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewKH.Location = new System.Drawing.Point(1009, 27);
            this.btnViewKH.Name = "btnViewKH";
            this.btnViewKH.Size = new System.Drawing.Size(181, 47);
            this.btnViewKH.TabIndex = 38;
            this.btnViewKH.Text = "Xem thông tin";
            this.btnViewKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewKH.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(16, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 30);
            this.panel3.TabIndex = 37;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(29, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = null;
            this.txtTimKiem.Size = new System.Drawing.Size(285, 23);
            this.txtTimKiem.TabIndex = 36;
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(0, 96);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1207, 452);
            this.dgvKH.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // txtSLKH
            // 
            this.txtSLKH.Enabled = false;
            this.txtSLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSLKH.Location = new System.Drawing.Point(364, 94);
            this.txtSLKH.Name = "txtSLKH";
            this.txtSLKH.Size = new System.Drawing.Size(211, 47);
            this.txtSLKH.TabIndex = 43;
            this.txtSLKH.Text = "button1";
            this.txtSLKH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Số lượng khách hàng";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 809);
            this.ControlBox = false;
            this.Controls.Add(this.txtSLKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewKH;
        private System.Windows.Forms.Panel panel3;
        private CustomClassLibrary.CustomPlaceholderTextbox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtSLKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewHD;
    }
}