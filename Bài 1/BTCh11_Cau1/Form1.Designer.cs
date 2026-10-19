namespace BTCh11_Cau1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            nudSoTien = new NumericUpDown();
            cboLoaiChi = new ComboBox();
            txtNoiDung = new TextBox();
            dtNgayChi = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtDenNgay = new DateTimePicker();
            dtTuNgay = new DateTimePicker();
            cboTimLoaiChi = new ComboBox();
            txtTimNoiDung = new TextBox();
            btnTim = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            dgvChiTieu = new DataGridView();
            lblTongChi = new Label();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(nudSoTien);
            groupBox1.Controls.Add(cboLoaiChi);
            groupBox1.Controls.Add(txtNoiDung);
            groupBox1.Controls.Add(dtNgayChi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khoản chi";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(79, 145);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(417, 27);
            txtGhiChu.TabIndex = 12;
            // 
            // nudSoTien
            // 
            nudSoTien.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoTien.Location = new Point(358, 31);
            nudSoTien.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new Size(138, 27);
            nudSoTien.TabIndex = 11;
            // 
            // cboLoaiChi
            // 
            cboLoaiChi.FormattingEnabled = true;
            cboLoaiChi.Items.AddRange(new object[] { "Ăn uống", "Đi lại", "Học tập", "Giải trí", "Khác" });
            cboLoaiChi.Location = new Point(79, 108);
            cboLoaiChi.Name = "cboLoaiChi";
            cboLoaiChi.Size = new Size(215, 28);
            cboLoaiChi.TabIndex = 10;
            cboLoaiChi.SelectedIndexChanged += cboLoaiChi_SelectedIndexChanged;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(79, 71);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(215, 27);
            txtNoiDung.TabIndex = 9;
            // 
            // dtNgayChi
            // 
            dtNgayChi.CustomFormat = "dd/mm/yyyy";
            dtNgayChi.Format = DateTimePickerFormat.Custom;
            dtNgayChi.Location = new Point(79, 33);
            dtNgayChi.Name = "dtNgayChi";
            dtNgayChi.Size = new Size(215, 27);
            dtNgayChi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 33);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Số tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Ghi chú";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 108);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Loại chi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nội dung";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày chi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtDenNgay);
            groupBox2.Controls.Add(dtTuNgay);
            groupBox2.Controls.Add(cboTimLoaiChi);
            groupBox2.Controls.Add(txtTimNoiDung);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(520, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(436, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // dtDenNgay
            // 
            dtDenNgay.CustomFormat = "dd/mm/yyyy";
            dtDenNgay.Format = DateTimePickerFormat.Custom;
            dtDenNgay.Location = new Point(82, 145);
            dtDenNgay.Name = "dtDenNgay";
            dtDenNgay.Size = new Size(201, 27);
            dtDenNgay.TabIndex = 11;
            // 
            // dtTuNgay
            // 
            dtTuNgay.CustomFormat = "dd/mm/yyyy";
            dtTuNgay.Format = DateTimePickerFormat.Custom;
            dtTuNgay.Location = new Point(84, 109);
            dtTuNgay.Name = "dtTuNgay";
            dtTuNgay.Size = new Size(203, 27);
            dtTuNgay.TabIndex = 10;
            // 
            // cboTimLoaiChi
            // 
            cboTimLoaiChi.FormattingEnabled = true;
            cboTimLoaiChi.Items.AddRange(new object[] { "Ăn uống", "Đi lại", "Học tập", "Giải trí", "Khác" });
            cboTimLoaiChi.Location = new Point(82, 71);
            cboTimLoaiChi.Name = "cboTimLoaiChi";
            cboTimLoaiChi.Size = new Size(203, 28);
            cboTimLoaiChi.TabIndex = 9;
            // 
            // txtTimNoiDung
            // 
            txtTimNoiDung.Location = new Point(82, 33);
            txtTimNoiDung.Name = "txtTimNoiDung";
            txtTimNoiDung.Size = new Size(338, 27);
            txtTimNoiDung.TabIndex = 8;
            txtTimNoiDung.TextChanged += textBox1_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(326, 148);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 148);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 3;
            label9.Text = "Đến ngày";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 108);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 2;
            label8.Text = "Từ ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 71);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 1;
            label7.Text = "Loại chi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 33);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 0;
            label6.Text = "Tìm kiếm";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 237);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(144, 237);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(370, 237);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvChiTieu
            // 
            dgvChiTieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTieu.Location = new Point(2, 272);
            dgvChiTieu.Name = "dgvChiTieu";
            dgvChiTieu.RowHeadersWidth = 51;
            dgvChiTieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTieu.Size = new Size(965, 207);
            dgvChiTieu.TabIndex = 6;
            dgvChiTieu.SelectionChanged += dgvChiTieu_SelectionChanged;
            // 
            // lblTongChi
            // 
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new Font("Segoe UI", 13F);
            lblTongChi.ForeColor = Color.Red;
            lblTongChi.Location = new Point(749, 482);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(141, 30);
            lblTongChi.TabIndex = 12;
            lblTongChi.Text = "Tổng chi: ... đ";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(254, 237);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 514);
            Controls.Add(lblTongChi);
            Controls.Add(dgvChiTieu);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sổ chi tiêu cá nhân";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btnTim;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnThem;
        private Button btnSua;
        private Button btnLamMoi;
        private DataGridView dgvChiTieu;
        private TextBox txtGhiChu;
        private NumericUpDown nudSoTien;
        private ComboBox cboLoaiChi;
        private TextBox txtNoiDung;
        private DateTimePicker dtNgayChi;
        private TextBox txtTimNoiDung;
        private DateTimePicker dtDenNgay;
        private DateTimePicker dtTuNgay;
        private ComboBox cboTimLoaiChi;
        private Label lblTongChi;
        private Button btnXoa;
    }
}
