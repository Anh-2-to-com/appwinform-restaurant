namespace GUI
{
    partial class FormLogin
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
            this.uc_Login1 = new WindowsFormsCustomLibrary.uc_Login();
            this.SuspendLayout();
            // 
            // uc_Login1
            // 
            this.uc_Login1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Login1.Location = new System.Drawing.Point(229, 13);
            this.uc_Login1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Login1.Name = "uc_Login1";
            this.uc_Login1.Size = new System.Drawing.Size(487, 290);
            this.uc_Login1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 328);
            this.Controls.Add(this.uc_Login1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsCustomLibrary.uc_Login uc_Login1;
    }
}