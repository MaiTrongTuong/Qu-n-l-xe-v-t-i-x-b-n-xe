namespace Taixevaxe
{
    partial class frmDangNhap
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
            this.rbtNhanVien = new System.Windows.Forms.RadioButton();
            this.rbtQuanLy = new System.Windows.Forms.RadioButton();
            this.rbtChuXe = new System.Windows.Forms.RadioButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtNhanVien
            // 
            this.rbtNhanVien.AutoSize = true;
            this.rbtNhanVien.Checked = true;
            this.rbtNhanVien.Location = new System.Drawing.Point(42, 36);
            this.rbtNhanVien.Name = "rbtNhanVien";
            this.rbtNhanVien.Size = new System.Drawing.Size(75, 17);
            this.rbtNhanVien.TabIndex = 0;
            this.rbtNhanVien.TabStop = true;
            this.rbtNhanVien.Text = "Nhân Viên";
            this.rbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // rbtQuanLy
            // 
            this.rbtQuanLy.AutoSize = true;
            this.rbtQuanLy.Location = new System.Drawing.Point(161, 36);
            this.rbtQuanLy.Name = "rbtQuanLy";
            this.rbtQuanLy.Size = new System.Drawing.Size(65, 17);
            this.rbtQuanLy.TabIndex = 1;
            this.rbtQuanLy.Text = "Quản Lý";
            this.rbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbtChuXe
            // 
            this.rbtChuXe.AutoSize = true;
            this.rbtChuXe.Location = new System.Drawing.Point(270, 36);
            this.rbtChuXe.Name = "rbtChuXe";
            this.rbtChuXe.Size = new System.Drawing.Size(60, 17);
            this.rbtChuXe.TabIndex = 2;
            this.rbtChuXe.Text = "Chủ Xe";
            this.rbtChuXe.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(177, 187);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.rbtChuXe);
            this.Controls.Add(this.rbtQuanLy);
            this.Controls.Add(this.rbtNhanVien);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNhanVien;
        private System.Windows.Forms.RadioButton rbtQuanLy;
        private System.Windows.Forms.RadioButton rbtChuXe;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}