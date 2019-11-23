namespace QuanLyBenXe.QuanLy
{
    partial class MainQuanLy
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
            this.lblTenQuanLy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenQuanLy
            // 
            this.lblTenQuanLy.AutoSize = true;
            this.lblTenQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuanLy.Location = new System.Drawing.Point(348, 54);
            this.lblTenQuanLy.Name = "lblTenQuanLy";
            this.lblTenQuanLy.Size = new System.Drawing.Size(79, 25);
            this.lblTenQuanLy.TabIndex = 0;
            this.lblTenQuanLy.Text = "Tên nè";
            // 
            // MainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTenQuanLy);
            this.Name = "MainQuanLy";
            this.Text = "MainQuanLy";
            this.Load += new System.EventHandler(this.MainQuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenQuanLy;
    }
}