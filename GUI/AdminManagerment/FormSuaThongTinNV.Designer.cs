namespace GUI.AdminManagerment
{
    partial class FormSuaThongTinNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaThongTinNV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uc_FormNhanVien1 = new WindowsFormsCustomLibrary.uc_FormNhanVien();
            this.btnNghiViec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 47);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(323, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "     Sửa thông tin nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uc_FormNhanVien1
            // 
            this.uc_FormNhanVien1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_FormNhanVien1.initialNhanVien = null;
            this.uc_FormNhanVien1.Location = new System.Drawing.Point(23, 121);
            this.uc_FormNhanVien1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_FormNhanVien1.Name = "uc_FormNhanVien1";
            this.uc_FormNhanVien1.Size = new System.Drawing.Size(906, 451);
            this.uc_FormNhanVien1.TabIndex = 23;
            // 
            // btnNghiViec
            // 
            this.btnNghiViec.Image = ((System.Drawing.Image)(resources.GetObject("btnNghiViec.Image")));
            this.btnNghiViec.Location = new System.Drawing.Point(716, 65);
            this.btnNghiViec.Name = "btnNghiViec";
            this.btnNghiViec.Size = new System.Drawing.Size(197, 49);
            this.btnNghiViec.TabIndex = 24;
            this.btnNghiViec.Text = "Ngừng làm việc";
            this.btnNghiViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNghiViec.UseVisualStyleBackColor = true;
            // 
            // FormSuaThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 585);
            this.ControlBox = false;
            this.Controls.Add(this.btnNghiViec);
            this.Controls.Add(this.uc_FormNhanVien1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSuaThongTinNV";
            this.Text = "FormSuaThongTinNV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsCustomLibrary.uc_FormNhanVien uc_FormNhanVien1;
        private System.Windows.Forms.Button btnNghiViec;
    }
}