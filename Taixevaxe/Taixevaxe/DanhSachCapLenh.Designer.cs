namespace Taixevaxe
{
    partial class DanhSachCapLenh
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuyenDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioVaoBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioXuatBen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiLenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoatDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "--Lựa chọn--"});
            this.comboBox3.Location = new System.Drawing.Point(8, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 28);
            this.comboBox3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.BienXe,
            this.LoaiXe,
            this.NgayLap,
            this.TuyenDuong,
            this.GioVaoBen,
            this.GioXuatBen,
            this.TrangThaiLenh,
            this.HoatDong,
            this.ThaoTac});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(932, 317);
            this.dataGridView1.TabIndex = 13;
            // 
            // Ma
            // 
            this.Ma.HeaderText = "MÃ";
            this.Ma.Name = "Ma";
            // 
            // BienXe
            // 
            this.BienXe.HeaderText = "BIỂN SỐ";
            this.BienXe.Name = "BienXe";
            // 
            // LoaiXe
            // 
            this.LoaiXe.HeaderText = "LOẠI XE";
            this.LoaiXe.Name = "LoaiXe";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "NGÀY LẬP";
            this.NgayLap.Name = "NgayLap";
            // 
            // TuyenDuong
            // 
            this.TuyenDuong.HeaderText = "TUYẾN ĐƯỜNG";
            this.TuyenDuong.Name = "TuyenDuong";
            // 
            // GioVaoBen
            // 
            this.GioVaoBen.HeaderText = "GIỜ VÀO BẾN";
            this.GioVaoBen.Name = "GioVaoBen";
            // 
            // GioXuatBen
            // 
            this.GioXuatBen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioXuatBen.HeaderText = "GIỜ XUẤT BẾN";
            this.GioXuatBen.Name = "GioXuatBen";
            // 
            // TrangThaiLenh
            // 
            this.TrangThaiLenh.HeaderText = "TRẠNG THÁI LỆNH";
            this.TrangThaiLenh.Name = "TrangThaiLenh";
            // 
            // HoatDong
            // 
            this.HoatDong.HeaderText = "HOẠT ĐỘNG";
            this.HoatDong.Name = "HoatDong";
            // 
            // ThaoTac
            // 
            this.ThaoTac.HeaderText = "THAO TÁC";
            this.ThaoTac.Name = "ThaoTac";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(128, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Khoảng ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Biển số";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 26);
            this.textBox1.TabIndex = 14;
            // 
            // DanhSachCapLenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 511);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Name = "DanhSachCapLenh";
            this.Text = "Danh sách cấp lệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuyenDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioVaoBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioXuatBen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiLenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThaoTac;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}