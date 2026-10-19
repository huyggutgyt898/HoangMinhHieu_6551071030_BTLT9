namespace QL_DaNgoai
{
    partial class FormChuyenDi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblTenChuyen = new System.Windows.Forms.Label();
            this.txtTenChuyen = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblNganSach = new System.Windows.Forms.Label();
            this.numNganSach = new System.Windows.Forms.NumericUpDown();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.chkDaHoanThanh = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkChuaHoanThanh = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnXemThoiTiet = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelWeatherAdvice = new System.Windows.Forms.Panel();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.lblWeatherInfo = new System.Windows.Forms.Label();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNganSach)).BeginInit();
            this.panelWeatherAdvice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kế hoạch dã ngoại cuối tuần";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(700, 18);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(54, 13);
            this.lblLang.TabIndex = 1;
            this.lblLang.Text = "Ngôn ngữ";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(765, 15);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(120, 21);
            this.cboLanguage.TabIndex = 2;
            // 
            // lblTenChuyen
            // 
            this.lblTenChuyen.AutoSize = true;
            this.lblTenChuyen.Location = new System.Drawing.Point(20, 55);
            this.lblTenChuyen.Name = "lblTenChuyen";
            this.lblTenChuyen.Size = new System.Drawing.Size(63, 13);
            this.lblTenChuyen.TabIndex = 3;
            this.lblTenChuyen.Text = "Tên chuyến";
            // 
            // txtTenChuyen
            // 
            this.txtTenChuyen.Location = new System.Drawing.Point(110, 52);
            this.txtTenChuyen.Name = "txtTenChuyen";
            this.txtTenChuyen.Size = new System.Drawing.Size(350, 20);
            this.txtTenChuyen.TabIndex = 4;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(20, 85);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(49, 13);
            this.lblDiaDiem.TabIndex = 5;
            this.lblDiaDiem.Text = "Địa điểm";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(110, 82);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(350, 20);
            this.txtDiaDiem.TabIndex = 6;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(20, 115);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(44, 13);
            this.lblNgayDi.TabIndex = 7;
            this.lblNgayDi.Text = "Ngày đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDi.Location = new System.Drawing.Point(110, 112);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(150, 20);
            this.dtpNgayDi.TabIndex = 8;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(20, 145);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(49, 13);
            this.lblSoNguoi.TabIndex = 9;
            this.lblSoNguoi.Text = "Số người";
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(110, 142);
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(150, 20);
            this.numSoNguoi.TabIndex = 10;
            this.numSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNganSach
            // 
            this.lblNganSach.AutoSize = true;
            this.lblNganSach.Location = new System.Drawing.Point(20, 175);
            this.lblNganSach.Name = "lblNganSach";
            this.lblNganSach.Size = new System.Drawing.Size(59, 13);
            this.lblNganSach.TabIndex = 11;
            this.lblNganSach.Text = "Ngân sách";
            // 
            // numNganSach
            // 
            this.numNganSach.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numNganSach.Location = new System.Drawing.Point(110, 172);
            this.numNganSach.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            this.numNganSach.Name = "numNganSach";
            this.numNganSach.Size = new System.Drawing.Size(150, 20);
            this.numNganSach.TabIndex = 12;
            // 
            // lblPhuongTien
            // 
            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Location = new System.Drawing.Point(20, 205);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(64, 13);
            this.lblPhuongTien.TabIndex = 13;
            this.lblPhuongTien.Text = "Phương tiện";
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Location = new System.Drawing.Point(110, 202);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(150, 21);
            this.cboPhuongTien.TabIndex = 14;
            // 
            // chkDaHoanThanh
            // 
            this.chkDaHoanThanh.AutoSize = true;
            this.chkDaHoanThanh.Location = new System.Drawing.Point(110, 232);
            this.chkDaHoanThanh.Name = "chkDaHoanThanh";
            this.chkDaHoanThanh.Size = new System.Drawing.Size(95, 17);
            this.chkDaHoanThanh.TabIndex = 15;
            this.chkDaHoanThanh.Text = "Đã hoàn thành";
            this.chkDaHoanThanh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(290, 265);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 315);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // chkChuaHoanThanh
            // 
            this.chkChuaHoanThanh.AutoSize = true;
            this.chkChuaHoanThanh.Location = new System.Drawing.Point(230, 317);
            this.chkChuaHoanThanh.Name = "chkChuaHoanThanh";
            this.chkChuaHoanThanh.Size = new System.Drawing.Size(183, 17);
            this.chkChuaHoanThanh.TabIndex = 21;
            this.chkChuaHoanThanh.Text = "Chỉ hiện chuyến chưa hoàn thành";
            this.chkChuaHoanThanh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 313);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnXemThoiTiet
            // 
            this.btnXemThoiTiet.Location = new System.Drawing.Point(500, 50);
            this.btnXemThoiTiet.Name = "btnXemThoiTiet";
            this.btnXemThoiTiet.Size = new System.Drawing.Size(110, 30);
            this.btnXemThoiTiet.TabIndex = 23;
            this.btnXemThoiTiet.Text = "Xem thời tiết";
            this.btnXemThoiTiet.UseVisualStyleBackColor = true;
            this.btnXemThoiTiet.Click += new System.EventHandler(this.btnXemThoiTiet_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(620, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 30);
            this.progressBar1.TabIndex = 24;
            // 
            // panelWeatherAdvice
            // 
            this.panelWeatherAdvice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelWeatherAdvice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWeatherAdvice.Controls.Add(this.lblAdvice);
            this.panelWeatherAdvice.Controls.Add(this.lblWeatherInfo);
            this.panelWeatherAdvice.Location = new System.Drawing.Point(500, 90);
            this.panelWeatherAdvice.Name = "panelWeatherAdvice";
            this.panelWeatherAdvice.Size = new System.Drawing.Size(390, 170);
            this.panelWeatherAdvice.TabIndex = 25;
            // 
            // lblAdvice
            // 
            this.lblAdvice.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdvice.Location = new System.Drawing.Point(15, 105);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(360, 50);
            this.lblAdvice.TabIndex = 1;
            // 
            // lblWeatherInfo
            // 
            this.lblWeatherInfo.Location = new System.Drawing.Point(15, 15);
            this.lblWeatherInfo.Name = "lblWeatherInfo";
            this.lblWeatherInfo.Size = new System.Drawing.Size(360, 80);
            this.lblWeatherInfo.TabIndex = 0;
            this.lblWeatherInfo.Text = "Chọn một chuyến đi để xem dự báo thời tiết...";
            // 
            // dgvChuyenDi
            // 
            this.dgvChuyenDi.AllowUserToAddRows = false;
            this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Location = new System.Drawing.Point(20, 350);
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.ReadOnly = true;
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(870, 230);
            this.dgvChuyenDi.TabIndex = 26;
            this.dgvChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDi_CellClick);
            // 
            // FormChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.panelWeatherAdvice);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnXemThoiTiet);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkChuaHoanThanh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkDaHoanThanh);
            this.Controls.Add(this.cboPhuongTien);
            this.Controls.Add(this.lblPhuongTien);
            this.Controls.Add(this.numNganSach);
            this.Controls.Add(this.lblNganSach);
            this.Controls.Add(this.numSoNguoi);
            this.Controls.Add(this.lblSoNguoi);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.txtTenChuyen);
            this.Controls.Add(this.lblTenChuyen);
            this.Controls.Add(this.cboLanguage);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormChuyenDi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế hoạch dã ngoại cuối tuần";
            this.Load += new System.EventHandler(this.FormChuyenDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNganSach)).EndInit();
            this.panelWeatherAdvice.ResumeLayout(false);
            this.panelWeatherAdvice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label lblTenChuyen;
        private System.Windows.Forms.TextBox txtTenChuyen;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lblNganSach;
        private System.Windows.Forms.NumericUpDown numNganSach;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.CheckBox chkDaHoanThanh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkChuaHoanThanh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnXemThoiTiet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panelWeatherAdvice;
        private System.Windows.Forms.Label lblWeatherInfo;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
    }
}