using System;

namespace QLPhieuNhap_GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxPhieuNhap = new System.Windows.Forms.GroupBox();
            this.button_LuuPhieu = new System.Windows.Forms.Button();
            this.button_TaoPhieu = new System.Windows.Forms.Button();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.cboMaPN_ChiTiet = new System.Windows.Forms.ComboBox();
            this.button_In = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.cboMaSanPham = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.groupBoxPhieuNhap.SuspendLayout();
            this.groupBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPhieuNhap
            // 
            this.groupBoxPhieuNhap.BackColor = System.Drawing.Color.White;
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.button_LuuPhieu);
            this.groupBoxPhieuNhap.Controls.Add(this.button_TaoPhieu);
            this.groupBoxPhieuNhap.Controls.Add(this.cboNhaCungCap);
            this.groupBoxPhieuNhap.Controls.Add(this.dtpNgayNhap);
            this.groupBoxPhieuNhap.Controls.Add(this.txtThanhTien);
            this.groupBoxPhieuNhap.Controls.Add(this.label4);
            this.groupBoxPhieuNhap.Controls.Add(this.label3);
            this.groupBoxPhieuNhap.Controls.Add(this.label2);
            this.groupBoxPhieuNhap.Controls.Add(this.label1);
            this.groupBoxPhieuNhap.Location = new System.Drawing.Point(39, 49);
            this.groupBoxPhieuNhap.Name = "groupBoxPhieuNhap";
            this.groupBoxPhieuNhap.Size = new System.Drawing.Size(889, 224);
            this.groupBoxPhieuNhap.TabIndex = 0;
            this.groupBoxPhieuNhap.TabStop = false;
            this.groupBoxPhieuNhap.Text = "Phiếu nhập";
            // 
            // button_LuuPhieu
            // 
            this.button_LuuPhieu.BackColor = System.Drawing.Color.Silver;
            this.button_LuuPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LuuPhieu.Location = new System.Drawing.Point(215, 150);
            this.button_LuuPhieu.Name = "button_LuuPhieu";
            this.button_LuuPhieu.Size = new System.Drawing.Size(151, 46);
            this.button_LuuPhieu.TabIndex = 9;
            this.button_LuuPhieu.Text = "Lưu phiếu nhập";
            this.button_LuuPhieu.UseVisualStyleBackColor = false;
            this.button_LuuPhieu.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // button_TaoPhieu
            // 
            this.button_TaoPhieu.BackColor = System.Drawing.Color.Silver;
            this.button_TaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaoPhieu.Location = new System.Drawing.Point(30, 150);
            this.button_TaoPhieu.Name = "button_TaoPhieu";
            this.button_TaoPhieu.Size = new System.Drawing.Size(151, 46);
            this.button_TaoPhieu.TabIndex = 8;
            this.button_TaoPhieu.Text = "Tạo phiếu nhập";
            this.button_TaoPhieu.UseVisualStyleBackColor = false;
            this.button_TaoPhieu.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(669, 40);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(190, 24);
            this.cboNhaCungCap.TabIndex = 7;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayNhap.Location = new System.Drawing.Point(176, 98);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(190, 22);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Location = new System.Drawing.Point(669, 96);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(190, 22);
            this.txtThanhTien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // groupBoxChiTiet
            // 
            this.groupBoxChiTiet.BackColor = System.Drawing.Color.White;
            this.groupBoxChiTiet.Controls.Add(this.label9);
            this.groupBoxChiTiet.Controls.Add(this.dgvChiTiet);
            this.groupBoxChiTiet.Controls.Add(this.cboMaPN_ChiTiet);
            this.groupBoxChiTiet.Controls.Add(this.button_In);
            this.groupBoxChiTiet.Controls.Add(this.btnThemSanPham);
            this.groupBoxChiTiet.Controls.Add(this.cboMaSanPham);
            this.groupBoxChiTiet.Controls.Add(this.txtSoLuong);
            this.groupBoxChiTiet.Controls.Add(this.label5);
            this.groupBoxChiTiet.Controls.Add(this.label7);
            this.groupBoxChiTiet.Controls.Add(this.txtDonGia);
            this.groupBoxChiTiet.Controls.Add(this.label8);
            this.groupBoxChiTiet.Location = new System.Drawing.Point(39, 279);
            this.groupBoxChiTiet.Name = "groupBoxChiTiet";
            this.groupBoxChiTiet.Size = new System.Drawing.Size(889, 386);
            this.groupBoxChiTiet.TabIndex = 1;
            this.groupBoxChiTiet.TabStop = false;
            this.groupBoxChiTiet.Text = "Chi tiết phiếu nhập";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvChiTiet.Location = new System.Drawing.Point(284, 160);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(575, 198);
            this.dgvChiTiet.TabIndex = 11;
            this.dgvChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSua,
            this.menuXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // menuSua
            // 
            this.menuSua.Name = "menuSua";
            this.menuSua.Size = new System.Drawing.Size(210, 24);
            this.menuSua.Text = "Sửa";
            this.menuSua.Click += new System.EventHandler(this.menuSua_Click);
            // 
            // menuXoa
            // 
            this.menuXoa.Name = "menuXoa";
            this.menuXoa.Size = new System.Drawing.Size(210, 24);
            this.menuXoa.Text = "Xóa";
            this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
            // 
            // cboMaPN_ChiTiet
            // 
            this.cboMaPN_ChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboMaPN_ChiTiet.FormattingEnabled = true;
            this.cboMaPN_ChiTiet.Location = new System.Drawing.Point(176, 40);
            this.cboMaPN_ChiTiet.Name = "cboMaPN_ChiTiet";
            this.cboMaPN_ChiTiet.Size = new System.Drawing.Size(190, 24);
            this.cboMaPN_ChiTiet.TabIndex = 10;
            // 
            // button_In
            // 
            this.button_In.BackColor = System.Drawing.Color.Silver;
            this.button_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_In.Location = new System.Drawing.Point(30, 275);
            this.button_In.Name = "button_In";
            this.button_In.Size = new System.Drawing.Size(227, 83);
            this.button_In.TabIndex = 9;
            this.button_In.Text = "In phiếu nhập";
            this.button_In.UseVisualStyleBackColor = false;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.Silver;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanPham.Location = new System.Drawing.Point(30, 160);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(227, 83);
            this.btnThemSanPham.TabIndex = 8;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboMaSanPham.FormattingEnabled = true;
            this.cboMaSanPham.Location = new System.Drawing.Point(669, 40);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new System.Drawing.Size(190, 24);
            this.cboMaSanPham.TabIndex = 7;
            this.cboMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cboMaSanPham_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(669, 96);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(190, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(176, 99);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 22);
            this.txtDonGia.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phiếu nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Số Lượng";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(176, 38);
            this.txtMaPhieuNhap.Multiline = true;
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(190, 22);
            this.txtMaPhieuNhap.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(974, 707);
            this.Controls.Add(this.groupBoxChiTiet);
            this.Controls.Add(this.groupBoxPhieuNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPhieuNhap.ResumeLayout(false);
            this.groupBoxPhieuNhap.PerformLayout();
            this.groupBoxChiTiet.ResumeLayout(false);
            this.groupBoxChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhieuNhap;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Button button_LuuPhieu;
        private System.Windows.Forms.Button button_TaoPhieu;
        private System.Windows.Forms.GroupBox groupBoxChiTiet;
        private System.Windows.Forms.Button button_In;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaPN_ChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSua;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
    }
}

