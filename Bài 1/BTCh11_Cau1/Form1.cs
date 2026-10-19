using BTCh11_Cau1.Models;
using Microsoft.VisualBasic.Logging;
using Serilog;
namespace BTCh11_Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly QL_ChiTieuContext db = new QL_ChiTieuContext();

        private int maDangChon = 0;

        private void LoadData()
        {
            dgvChiTieu.DataSource = db.ChiTieus
                                    .OrderByDescending(x => x.NgayChi)
                                    .ToList();

            TinhTongChi();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboLoaiChi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvChiTieu.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect;

            dgvChiTieu.MultiSelect = false;

            LoadData();


        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Nội dung không được rỗng");
                return false;
            }

            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền phải > 0");
                return false;
            }

            if (dtNgayChi.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Không được lớn hơn hôm nay");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            ChiTieu ct = new ChiTieu()
            {
                NgayChi = DateOnly.FromDateTime(dtNgayChi.Value),
                NoiDung = txtNoiDung.Text,
                LoaiChi = cboLoaiChi.Text,
                SoTien = nudSoTien.Value,
                GhiChu = txtGhiChu.Text
            };

            db.ChiTieus.Add(ct);
            db.SaveChanges();
            Serilog.Log.Information(
        "Them chi tieu MaCT={MaCT}",
        ct.MaCt);
            LoadData();
            ClearInput();
        }

        private void dgvChiTieu_SelectionChanged(
    object sender, EventArgs e)
        {
            if (dgvChiTieu.CurrentRow == null)
                return;

            DataGridViewRow row =
                dgvChiTieu.CurrentRow;

            maDangChon =
                Convert.ToInt32(row.Cells["MaCT"].Value);

            dtNgayChi.Value =
    ((DateOnly)row.Cells["NgayChi"].Value)
    .ToDateTime(TimeOnly.MinValue);
            txtNoiDung.Text =
                row.Cells["NoiDung"].Value?.ToString();

            cboLoaiChi.Text =
                row.Cells["LoaiChi"].Value?.ToString();

            nudSoTien.Value =
                Convert.ToDecimal(row.Cells["SoTien"].Value);

            txtGhiChu.Text =
                row.Cells["GhiChu"].Value?.ToString();
        }

        /*private void dgvChiTieu_CellClick(object sender,
DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row =
                dgvChiTieu.Rows[e.RowIndex];

            maDangChon = Convert.ToInt32(
                row.Cells["MaCT"].Value);

            dtNgayChi.Value =
                Convert.ToDateTime(row.Cells["NgayChi"].Value);

            txtNoiDung.Text =
                row.Cells["NoiDung"].Value.ToString();

            cboLoaiChi.Text =
                row.Cells["LoaiChi"].Value.ToString();

            nudSoTien.Value =
                Convert.ToDecimal(row.Cells["SoTien"].Value);

            txtGhiChu.Text =
                row.Cells["GhiChu"].Value?.ToString();
        }*/

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (maDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi");
                return;
            }

            var ct = db.ChiTieus.Find(maDangChon);

            if (ct == null) return;

            ct.NgayChi =
                DateOnly.FromDateTime(dtNgayChi.Value);

            ct.NoiDung = txtNoiDung.Text;
            ct.LoaiChi = cboLoaiChi.Text;
            ct.SoTien = nudSoTien.Value;
            ct.GhiChu = txtGhiChu.Text;
            Serilog.Log.Information(
        "Sua chi tieu MaCT={MaCT}",
        ct.MaCt);
            db.SaveChanges();

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (maDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn bản ghi");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (rs == DialogResult.No)
                return;

            var ct = db.ChiTieus.Find(maDangChon);

            if (ct != null)
            {
                db.ChiTieus.Remove(ct);
                db.SaveChanges();

                Serilog.Log.Information(
        "Xoa chi tieu MaCT={MaCT}",
        ct.MaCt);
                LoadData();
            }
        }

        private void ClearInput()
        {
            maDangChon = 0;

            txtNoiDung.Clear();
            txtGhiChu.Clear();

            nudSoTien.Value = 0;

            cboLoaiChi.SelectedIndex = -1;

            dtNgayChi.Value = DateTime.Now;
        }

        private void btnLamMoi_Click(object sender,
EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ds = db.ChiTieus.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtTimNoiDung.Text))
            {
                ds = ds.Where(x =>
                x.NoiDung.Contains(txtTimNoiDung.Text));
            }

            if (cboTimLoaiChi.SelectedIndex >= 0)
            {
                ds = ds.Where(x =>
                x.LoaiChi == cboTimLoaiChi.Text);
            }

            DateOnly tu =
                DateOnly.FromDateTime(dtTuNgay.Value);

            DateOnly den =
                DateOnly.FromDateTime(dtDenNgay.Value);

            ds = ds.Where(x =>
                x.NgayChi >= tu &&
                x.NgayChi <= den);

            dgvChiTieu.DataSource = ds.ToList();

            TinhTongChi();
        }

        private void TinhTongChi()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvChiTieu.Rows)
            {
                if (row.Cells["SoTien"].Value != null)
                {
                    tong += Convert.ToDecimal(
                        row.Cells["SoTien"].Value);
                }
            }

            lblTongChi.Text =
              $"Tổng chi: {tong:N0} đ";
        }
    
    }

}
