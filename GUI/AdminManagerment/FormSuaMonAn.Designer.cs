﻿namespace GUI.AdminManagerment
{
    partial class FormSuaMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaMonAn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNgungKD = new System.Windows.Forms.Button();
            this.uc_FormMonAn1 = new WindowsFormsCustomLibrary.uc_FormMonAn();
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
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(402, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "     Sửa thông tin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNgungKD
            // 
            this.btnNgungKD.Image = ((System.Drawing.Image)(resources.GetObject("btnNgungKD.Image")));
            this.btnNgungKD.Location = new System.Drawing.Point(690, 68);
            this.btnNgungKD.Name = "btnNgungKD";
            this.btnNgungKD.Size = new System.Drawing.Size(226, 49);
            this.btnNgungKD.TabIndex = 25;
            this.btnNgungKD.Text = "Ngừng kinh doanh";
            this.btnNgungKD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNgungKD.UseVisualStyleBackColor = true;
            // 
            // uc_FormMonAn1
            // 
            this.uc_FormMonAn1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_FormMonAn1.initialMonAn = null;
            this.uc_FormMonAn1.Location = new System.Drawing.Point(24, 84);
            this.uc_FormMonAn1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_FormMonAn1.Name = "uc_FormMonAn1";
            this.uc_FormMonAn1.Size = new System.Drawing.Size(906, 451);
            this.uc_FormMonAn1.TabIndex = 26;
            // 
            // FormSuaMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 535);
            this.ControlBox = false;
            this.Controls.Add(this.btnNgungKD);
            this.Controls.Add(this.uc_FormMonAn1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSuaMonAn";
            this.Text = "FormSuaMonAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNgungKD;
        private WindowsFormsCustomLibrary.uc_FormMonAn uc_FormMonAn1;
    }
}