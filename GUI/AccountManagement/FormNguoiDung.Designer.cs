namespace GUI.UserManagement
{
    partial class FormNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemND = new System.Windows.Forms.Button();
            this.btnSuaND = new System.Windows.Forms.Button();
            this.btnXoaND = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.dgvNDNND = new System.Windows.Forms.DataGridView();
            this.cboNND = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemNDNND = new System.Windows.Forms.Button();
            this.btnXoaNDNND = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioHD = new System.Windows.Forms.RadioButton();
            this.radioNHD = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDNND)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnThemND);
            this.groupBox1.Controls.Add(this.btnSuaND);
            this.groupBox1.Controls.Add(this.btnXoaND);
            this.groupBox1.Location = new System.Drawing.Point(380, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 196);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác người dùng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThemND
            // 
            this.btnThemND.Location = new System.Drawing.Point(19, 46);
            this.btnThemND.Name = "btnThemND";
            this.btnThemND.Size = new System.Drawing.Size(96, 45);
            this.btnThemND.TabIndex = 5;
            this.btnThemND.Text = "Thêm";
            this.btnThemND.UseVisualStyleBackColor = true;
            // 
            // btnSuaND
            // 
            this.btnSuaND.Location = new System.Drawing.Point(253, 46);
            this.btnSuaND.Name = "btnSuaND";
            this.btnSuaND.Size = new System.Drawing.Size(90, 45);
            this.btnSuaND.TabIndex = 7;
            this.btnSuaND.Text = "Sửa";
            this.btnSuaND.UseVisualStyleBackColor = true;
            // 
            // btnXoaND
            // 
            this.btnXoaND.Location = new System.Drawing.Point(131, 46);
            this.btnXoaND.Name = "btnXoaND";
            this.btnXoaND.Size = new System.Drawing.Size(101, 45);
            this.btnXoaND.TabIndex = 6;
            this.btnXoaND.Text = "Xóa";
            this.btnXoaND.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 30);
            this.txtEmail.TabIndex = 21;
            // 
            // txtMaND
            // 
            this.txtMaND.Location = new System.Drawing.Point(77, 158);
            this.txtMaND.Name = "txtMaND";
            this.txtMaND.Size = new System.Drawing.Size(273, 30);
            this.txtMaND.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã người dùng";
            // 
            // dgvND
            // 
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Location = new System.Drawing.Point(77, 401);
            this.dgvND.Margin = new System.Windows.Forms.Padding(4);
            this.dgvND.Name = "dgvND";
            this.dgvND.RowHeadersWidth = 51;
            this.dgvND.RowTemplate.Height = 24;
            this.dgvND.Size = new System.Drawing.Size(663, 338);
            this.dgvND.TabIndex = 17;
            // 
            // dgvNDNND
            // 
            this.dgvNDNND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDNND.Location = new System.Drawing.Point(790, 401);
            this.dgvNDNND.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNDNND.Name = "dgvNDNND";
            this.dgvNDNND.RowHeadersWidth = 51;
            this.dgvNDNND.RowTemplate.Height = 24;
            this.dgvNDNND.Size = new System.Drawing.Size(547, 338);
            this.dgvNDNND.TabIndex = 23;
            // 
            // cboNND
            // 
            this.cboNND.FormattingEnabled = true;
            this.cboNND.Location = new System.Drawing.Point(790, 201);
            this.cboNND.Name = "cboNND";
            this.cboNND.Size = new System.Drawing.Size(273, 32);
            this.cboNND.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhóm người dùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemNDNND);
            this.groupBox2.Controls.Add(this.btnXoaNDNND);
            this.groupBox2.Location = new System.Drawing.Point(790, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 85);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác nhóm người dùng";
            // 
            // btnThemNDNND
            // 
            this.btnThemNDNND.Location = new System.Drawing.Point(15, 29);
            this.btnThemNDNND.Name = "btnThemNDNND";
            this.btnThemNDNND.Size = new System.Drawing.Size(96, 45);
            this.btnThemNDNND.TabIndex = 9;
            this.btnThemNDNND.Text = "Thêm";
            this.btnThemNDNND.UseVisualStyleBackColor = true;
            // 
            // btnXoaNDNND
            // 
            this.btnXoaNDNND.Location = new System.Drawing.Point(163, 29);
            this.btnXoaNDNND.Name = "btnXoaNDNND";
            this.btnXoaNDNND.Size = new System.Drawing.Size(101, 45);
            this.btnXoaNDNND.TabIndex = 10;
            this.btnXoaNDNND.Text = "Xóa";
            this.btnXoaNDNND.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Trạng thái";
            // 
            // radioHD
            // 
            this.radioHD.AutoSize = true;
            this.radioHD.Location = new System.Drawing.Point(178, 320);
            this.radioHD.Name = "radioHD";
            this.radioHD.Size = new System.Drawing.Size(129, 28);
            this.radioHD.TabIndex = 27;
            this.radioHD.TabStop = true;
            this.radioHD.Text = "Hoạt động";
            this.radioHD.UseVisualStyleBackColor = true;
            // 
            // radioNHD
            // 
            this.radioNHD.AutoSize = true;
            this.radioNHD.Location = new System.Drawing.Point(178, 354);
            this.radioNHD.Name = "radioNHD";
            this.radioNHD.Size = new System.Drawing.Size(197, 28);
            this.radioNHD.TabIndex = 28;
            this.radioNHD.TabStop = true;
            this.radioNHD.Text = "Ngừng hoạt động";
            this.radioNHD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1964, 58);
            this.panel1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(657, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quản lý người dùng";
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 809);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioNHD);
            this.Controls.Add(this.radioHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNND);
            this.Controls.Add(this.dgvNDNND);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvND);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNguoiDung";
            this.Text = "FormNguoiDung";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDNND)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemND;
        private System.Windows.Forms.Button btnSuaND;
        private System.Windows.Forms.Button btnXoaND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvND;
        private System.Windows.Forms.DataGridView dgvNDNND;
        private System.Windows.Forms.ComboBox cboNND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemNDNND;
        private System.Windows.Forms.Button btnXoaNDNND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioHD;
        private System.Windows.Forms.RadioButton radioNHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}