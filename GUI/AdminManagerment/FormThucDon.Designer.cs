namespace GUI.AdminManagerment
{
    partial class FormThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThucDon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateMA = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new CustomClassLibrary.CustomPlaceholderTextbox();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.btnAddMA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLMon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btnUpdateMA);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvMonAn);
            this.panel2.Controls.Add(this.btnAddMA);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(133, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 548);
            this.panel2.TabIndex = 39;
            // 
            // btnUpdateMA
            // 
            this.btnUpdateMA.BackColor = System.Drawing.Color.White;
            this.btnUpdateMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMA.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateMA.Image")));
            this.btnUpdateMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMA.Location = new System.Drawing.Point(1016, 27);
            this.btnUpdateMA.Name = "btnUpdateMA";
            this.btnUpdateMA.Size = new System.Drawing.Size(174, 47);
            this.btnUpdateMA.TabIndex = 38;
            this.btnUpdateMA.Text = "Sửa thông tin";
            this.btnUpdateMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateMA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateMA.UseVisualStyleBackColor = false;
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
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(0, 96);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.RowTemplate.Height = 24;
            this.dgvMonAn.Size = new System.Drawing.Size(1207, 452);
            this.dgvMonAn.TabIndex = 35;
            // 
            // btnAddMA
            // 
            this.btnAddMA.BackColor = System.Drawing.Color.White;
            this.btnAddMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMA.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMA.Image")));
            this.btnAddMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMA.Location = new System.Drawing.Point(795, 27);
            this.btnAddMA.Name = "btnAddMA";
            this.btnAddMA.Size = new System.Drawing.Size(176, 47);
            this.btnAddMA.TabIndex = 34;
            this.btnAddMA.Text = "Thêm món ăn";
            this.btnAddMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh sách món ăn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2084, 55);
            this.panel1.TabIndex = 38;
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
            this.label5.Size = new System.Drawing.Size(290, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "     Quản lý thực đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Số món ăn đang kinh doanh";
            // 
            // txtSLMon
            // 
            this.txtSLMon.Enabled = false;
            this.txtSLMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSLMon.Location = new System.Drawing.Point(401, 103);
            this.txtSLMon.Name = "txtSLMon";
            this.txtSLMon.Size = new System.Drawing.Size(164, 47);
            this.txtSLMon.TabIndex = 41;
            this.txtSLMon.Text = "button1";
            this.txtSLMon.UseVisualStyleBackColor = true;
            // 
            // FormThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 809);
            this.ControlBox = false;
            this.Controls.Add(this.txtSLMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThucDon";
            this.Text = "FormThucDon";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateMA;
        private System.Windows.Forms.Panel panel3;
        private CustomClassLibrary.CustomPlaceholderTextbox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.Button btnAddMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtSLMon;
    }
}