using KeHoachDaNgoai.Models;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DaNgoai
{
    public partial class FormChuyenDi : Form
    {
        private static readonly HttpClient httpClient = new HttpClient(new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
        })
        {
            Timeout = TimeSpan.FromSeconds(8)
        };
        private UserSettings userSettings;
        private CultureInfo currentCulture;
        private int? selectedMaChuyen = null;

        public FormChuyenDi()
        {
            InitializeComponent();
            userSettings = UserSettings.Load();
            currentCulture = new CultureInfo(userSettings.Language);
        }

        private void FormChuyenDi_Load(object sender, EventArgs e)
        {
            if (cboLanguage != null)
            {
                cboLanguage.Items.Clear();
                cboLanguage.Items.Add(new ComboBoxItem("Tiếng Việt", "vi-VN"));
                cboLanguage.Items.Add(new ComboBoxItem("English", "en-US"));
                cboLanguage.SelectedIndex = userSettings.Language == "en-US" ? 1 : 0;
                cboLanguage.SelectedIndexChanged += CboLanguage_SelectedIndexChanged;
            }

            if (cboPhuongTien != null)
            {
                cboPhuongTien.Items.Clear();
                cboPhuongTien.Items.AddRange(new string[] { "Ô tô", "Xe máy", "Xe khách", "Tàu hỏa", "Máy bay" });
                if (cboPhuongTien.Items.Count > 0) cboPhuongTien.SelectedIndex = 0;
            }

            ApplyLanguage();
            LoadData();
        }

        private void CboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLanguage?.SelectedItem is ComboBoxItem item)
            {
                userSettings.Language = item.Value;
                userSettings.Save();
                currentCulture = new CultureInfo(userSettings.Language);
                ApplyLanguage();
                LoadData();
            }
        }

        private void ApplyLanguage()
        {
            if (userSettings.Language == "en-US")
            {
                this.Text = "Weekend Trip Planner";
                if (lblTitle != null) lblTitle.Text = "Weekend Trip Planner";
                if (lblTenChuyen != null) lblTenChuyen.Text = "Trip Name";
                if (lblDiaDiem != null) lblDiaDiem.Text = "Location";
                if (lblNgayDi != null) lblNgayDi.Text = "Departure Date";
                if (lblSoNguoi != null) lblSoNguoi.Text = "People";
                if (lblNganSach != null) lblNganSach.Text = "Budget";
                if (lblPhuongTien != null) lblPhuongTien.Text = "Vehicle";
                if (chkDaHoanThanh != null) chkDaHoanThanh.Text = "Completed";
                if (btnAdd != null) btnAdd.Text = "Add";
                if (btnUpdate != null) btnUpdate.Text = "Update";
                if (btnDelete != null) btnDelete.Text = "Delete";
                if (btnRefresh != null) btnRefresh.Text = "Refresh";
                if (btnSearch != null) btnSearch.Text = "Search";
                if (chkChuaHoanThanh != null) chkChuaHoanThanh.Text = "Show incomplete only";
                if (lblLang != null) lblLang.Text = "Language";
                if (btnXemThoiTiet != null) btnXemThoiTiet.Text = "Check Weather";

                if (dgvChuyenDi != null && dgvChuyenDi.Columns.Count >= 8)
                {
                    dgvChuyenDi.Columns["MaChuyen"].HeaderText = "ID";
                    dgvChuyenDi.Columns["TenChuyen"].HeaderText = "Trip Name";
                    dgvChuyenDi.Columns["DiaDiem"].HeaderText = "Location";
                    dgvChuyenDi.Columns["NgayDi"].HeaderText = "Departure Date";
                    dgvChuyenDi.Columns["SoNguoi"].HeaderText = "People";
                    dgvChuyenDi.Columns["NganSach"].HeaderText = "Budget";
                    dgvChuyenDi.Columns["PhuongTien"].HeaderText = "Vehicle";
                    dgvChuyenDi.Columns["DaHoanThanh"].HeaderText = "Completed";
                }
            }
            else
            {
                this.Text = "Kế hoạch dã ngoại cuối tuần";
                if (lblTitle != null) lblTitle.Text = "Kế hoạch dã ngoại cuối tuần";
                if (lblTenChuyen != null) lblTenChuyen.Text = "Tên chuyến";
                if (lblDiaDiem != null) lblDiaDiem.Text = "Địa điểm";
                if (lblNgayDi != null) lblNgayDi.Text = "Ngày đi";
                if (lblSoNguoi != null) lblSoNguoi.Text = "Số người";
                if (lblNganSach != null) lblNganSach.Text = "Ngân sách";
                if (lblPhuongTien != null) lblPhuongTien.Text = "Phương tiện";
                if (chkDaHoanThanh != null) chkDaHoanThanh.Text = "Đã hoàn thành";
                if (btnAdd != null) btnAdd.Text = "Thêm";
                if (btnUpdate != null) btnUpdate.Text = "Sửa";
                if (btnDelete != null) btnDelete.Text = "Xóa";
                if (btnRefresh != null) btnRefresh.Text = "Làm mới";
                if (btnSearch != null) btnSearch.Text = "Tìm";
                if (chkChuaHoanThanh != null) chkChuaHoanThanh.Text = "Chỉ hiện chuyến chưa hoàn thành";
                if (lblLang != null) lblLang.Text = "Ngôn ngữ";
                if (btnXemThoiTiet != null) btnXemThoiTiet.Text = "Xem thời tiết";

                if (dgvChuyenDi != null && dgvChuyenDi.Columns.Count >= 8)
                {
                    dgvChuyenDi.Columns["MaChuyen"].HeaderText = "Mã";
                    dgvChuyenDi.Columns["TenChuyen"].HeaderText = "Tên chuyến";
                    dgvChuyenDi.Columns["DiaDiem"].HeaderText = "Địa điểm";
                    dgvChuyenDi.Columns["NgayDi"].HeaderText = "Ngày đi";
                    dgvChuyenDi.Columns["SoNguoi"].HeaderText = "Số người";
                    dgvChuyenDi.Columns["NganSach"].HeaderText = "Ngân sách";
                    dgvChuyenDi.Columns["PhuongTien"].HeaderText = "Phương tiện";
                    dgvChuyenDi.Columns["DaHoanThanh"].HeaderText = "Hoàn thành";
                }
            }
        }

        private void LoadData()
        {
            if (dgvChuyenDi == null) return;
            try
            {
                using (var db = new QL_DaNgoaiContext())
                {
                    var query = db.ChuyenDis.AsQueryable();

                    if (chkChuaHoanThanh != null && chkChuaHoanThanh.Checked)
                    {
                        query = query.Where(x => x.DaHoanThanh == false);
                    }

                    string keyword = txtSearch != null ? txtSearch.Text.Trim() : "";
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query = query.Where(x => x.TenChuyen.Contains(keyword) || x.DiaDiem.Contains(keyword));
                    }

                    var list = query.Select(x => new
                    {
                        x.MaChuyen,
                        x.TenChuyen,
                        x.DiaDiem,
                        x.NgayDi,
                        x.SoNguoi,
                        x.NganSach,
                        x.PhuongTien,
                        x.DaHoanThanh
                    }).ToList();

                    dgvChuyenDi.DataSource = list;

                    if (dgvChuyenDi.Columns["NganSach"] != null)
                    {
                        dgvChuyenDi.Columns["NganSach"].DefaultCellStyle.Format = "N0";
                        dgvChuyenDi.Columns["NganSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (dgvChuyenDi.Columns["NgayDi"] != null)
                    {
                        dgvChuyenDi.Columns["NgayDi"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvChuyenDi != null)
            {
                DataGridViewRow row = dgvChuyenDi.Rows[e.RowIndex];
                selectedMaChuyen = Convert.ToInt32(row.Cells["MaChuyen"].Value);
                if (txtTenChuyen != null) txtTenChuyen.Text = row.Cells["TenChuyen"].Value?.ToString();
                if (txtDiaDiem != null) txtDiaDiem.Text = row.Cells["DiaDiem"].Value?.ToString();

                if (dtpNgayDi != null && row.Cells["NgayDi"].Value != null)
                {
                    if (row.Cells["NgayDi"].Value is DateOnly dateOnlyVal)
                    {
                        dtpNgayDi.Value = dateOnlyVal.ToDateTime(TimeOnly.MinValue);
                    }
                    else
                    {
                        dtpNgayDi.Value = Convert.ToDateTime(row.Cells["NgayDi"].Value);
                    }
                }

                if (numSoNguoi != null) numSoNguoi.Value = Convert.ToInt32(row.Cells["SoNguoi"].Value);
                if (numNganSach != null) numNganSach.Value = Convert.ToDecimal(row.Cells["NganSach"].Value);
                if (cboPhuongTien != null) cboPhuongTien.Text = row.Cells["PhuongTien"].Value?.ToString();
                if (chkDaHoanThanh != null) chkDaHoanThanh.Checked = Convert.ToBoolean(row.Cells["DaHoanThanh"].Value);

                if (txtDiaDiem != null && dtpNgayDi != null)
                {
                    _ = FetchWeatherAsync(txtDiaDiem.Text.Trim(), dtpNgayDi.Value);
                }
            }
        }

        private bool ValidateInput(bool isNew)
        {
            if (txtTenChuyen == null || txtDiaDiem == null) return true;
            if (string.IsNullOrWhiteSpace(txtTenChuyen.Text) || string.IsNullOrWhiteSpace(txtDiaDiem.Text))
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Please enter trip name and location!" : "Vui lòng nhập tên chuyến và địa điểm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (isNew && dtpNgayDi != null && dtpNgayDi.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Departure date cannot be in the past!" : "Ngày đi không được nhỏ hơn hôm nay khi thêm mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numSoNguoi != null && numSoNguoi.Value < 1)
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Number of people must be at least 1!" : "Số người phải lớn hơn hoặc bằng 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numNganSach != null && numNganSach.Value < 0)
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Budget must be >= 0!" : "Ngân sách phải lớn hơn hoặc bằng 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;
            try
            {
                using (var db = new QL_DaNgoaiContext())
                {
                    var item = new ChuyenDi
                    {
                        TenChuyen = txtTenChuyen.Text.Trim(),
                        DiaDiem = txtDiaDiem.Text.Trim(),
                        NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date),
                        SoNguoi = (int)numSoNguoi.Value,
                        NganSach = numNganSach.Value,
                        PhuongTien = cboPhuongTien.Text,
                        DaHoanThanh = chkDaHoanThanh.Checked
                    };
                    db.ChuyenDis.Add(item);
                    db.SaveChanges();
                }
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMaChuyen == null)
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Please select a trip to update!" : "Vui lòng chọn chuyến đi cần sửa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput(false)) return;
            try
            {
                using (var db = new QL_DaNgoaiContext())
                {
                    var item = db.ChuyenDis.Find(selectedMaChuyen);
                    if (item != null)
                    {
                        item.TenChuyen = txtTenChuyen.Text.Trim();
                        item.DiaDiem = txtDiaDiem.Text.Trim();
                        item.NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date);
                        item.SoNguoi = (int)numSoNguoi.Value;
                        item.NganSach = numNganSach.Value;
                        item.PhuongTien = cboPhuongTien.Text;
                        item.DaHoanThanh = chkDaHoanThanh.Checked;
                        db.SaveChanges();
                    }
                }
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMaChuyen == null)
            {
                MessageBox.Show(userSettings.Language == "en-US" ? "Please select a trip to delete!" : "Vui lòng chọn chuyến đi cần xóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmMsg = userSettings.Language == "en-US" ? "Are you sure you want to delete this trip?" : "Bạn có chắc chắn muốn xóa chuyến đi này không?";
            if (MessageBox.Show(confirmMsg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QL_DaNgoaiContext())
                    {
                        var item = db.ChuyenDis.Find(selectedMaChuyen);
                        if (item != null)
                        {
                            db.ChuyenDis.Remove(item);
                            db.SaveChanges();
                        }
                    }
                    LoadData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void ClearForm()
        {
            selectedMaChuyen = null;
            if (txtTenChuyen != null) txtTenChuyen.Clear();
            if (txtDiaDiem != null) txtDiaDiem.Clear();
            if (dtpNgayDi != null) dtpNgayDi.Value = DateTime.Now;
            if (numSoNguoi != null) numSoNguoi.Value = 1;
            if (numNganSach != null) numNganSach.Value = 0;
            if (cboPhuongTien != null && cboPhuongTien.Items.Count > 0) cboPhuongTien.SelectedIndex = 0;
            if (chkDaHoanThanh != null) chkDaHoanThanh.Checked = false;
            if (txtSearch != null) txtSearch.Clear();
            if (lblWeatherInfo != null) lblWeatherInfo.Text = "Chọn một chuyến đi để xem dự báo thời tiết...";
            if (panelWeatherAdvice != null) panelWeatherAdvice.BackColor = Color.WhiteSmoke;
            if (lblAdvice != null) lblAdvice.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnXemThoiTiet_Click(object sender, EventArgs e)
        {
            if (txtDiaDiem != null && dtpNgayDi != null)
            {
                await FetchWeatherAsync(txtDiaDiem.Text.Trim(), dtpNgayDi.Value);
            }
        }

        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private async Task FetchWeatherAsync(string diaDiem, DateTime ngayDi)
        {
            if (string.IsNullOrWhiteSpace(diaDiem)) return;

            if (progressBar1 != null)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 30;
            }
            if (btnXemThoiTiet != null) btnXemThoiTiet.Enabled = false;

            try
            {
                // Thử tìm địa điểm theo tên gốc trước
                JsonElement? firstLoc = await SearchLocationAsync(diaDiem);

                // Nếu không thấy, thử tìm theo tên không dấu
                if (!firstLoc.HasValue)
                {
                    string noAccents = RemoveDiacritics(diaDiem);
                    firstLoc = await SearchLocationAsync(noAccents);
                }

                if (!firstLoc.HasValue)
                {
                    MessageBox.Show(userSettings.Language == "en-US" ? "Location not found!" : "Không tìm thấy địa danh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double lat = firstLoc.Value.GetProperty("latitude").GetDouble();
                double lon = firstLoc.Value.GetProperty("longitude").GetDouble();

                string forecastUrl = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=auto&forecast_days=16";

                var forecastResponse = await httpClient.GetAsync(forecastUrl);
                if (!forecastResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Không thể lấy dữ liệu thời tiết!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string forecastJson = await forecastResponse.Content.ReadAsStringAsync();
                using var forecastDoc = JsonDocument.Parse(forecastJson);

                var daily = forecastDoc.RootElement.GetProperty("daily");
                var timeArr = daily.GetProperty("time");
                var weatherCodeArr = daily.GetProperty("weather_code");
                var tMaxArr = daily.GetProperty("temperature_2m_max");
                var tMinArr = daily.GetProperty("temperature_2m_min");
                var precipArr = daily.GetProperty("precipitation_probability_max");

                string targetDateStr = ngayDi.ToString("yyyy-MM-dd");
                int index = -1;
                for (int i = 0; i < timeArr.GetArrayLength(); i++)
                {
                    if (timeArr[i].GetString() == targetDateStr)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    if (lblWeatherInfo != null) lblWeatherInfo.Text = "Chưa có dữ liệu dự báo (vượt quá 16 ngày)!";
                    if (panelWeatherAdvice != null) panelWeatherAdvice.BackColor = Color.WhiteSmoke;
                    if (lblAdvice != null) lblAdvice.Text = "";
                    return;
                }

                int wCode = weatherCodeArr[index].GetInt32();
                double tMax = tMaxArr[index].GetDouble();
                double tMin = tMinArr[index].GetDouble();
                int precipProb = precipArr[index].GetInt32();

                string weatherDesc = GetWeatherDescription(wCode);

                if (lblWeatherInfo != null)
                {
                    lblWeatherInfo.Text = $"Dự báo ngày {ngayDi:dd/MM/yyyy} - {diaDiem}\n\nTrạng thái: {weatherDesc}\nNhiệt độ: {tMin}°C - {tMax}°C\nKhả năng mưa: {precipProb}%";
                }

                if (panelWeatherAdvice != null && lblAdvice != null)
                {
                    if (precipProb >= 60)
                    {
                        panelWeatherAdvice.BackColor = Color.Orange;
                        lblAdvice.Text = "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch";
                    }
                    else
                    {
                        panelWeatherAdvice.BackColor = Color.LightGreen;
                        lblAdvice.Text = "☀️ Thời tiết tuyệt vời cho chuyến đi!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng hoặc API thời tiết: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (progressBar1 != null) progressBar1.Style = ProgressBarStyle.Continuous;
                if (btnXemThoiTiet != null) btnXemThoiTiet.Enabled = true;
            }
        }

        private async Task<JsonElement?> SearchLocationAsync(string locationName)
        {
            try
            {
                string geoUrl = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(locationName)}&count=1&language=vi";
                var response = await httpClient.GetAsync(geoUrl);
                if (!response.IsSuccessStatusCode) return null;

                string geoJson = await response.Content.ReadAsStringAsync();
                using var geoDoc = JsonDocument.Parse(geoJson);

                if (geoDoc.RootElement.TryGetProperty("results", out var resultsElem) && resultsElem.GetArrayLength() > 0)
                {
                    return resultsElem[0].Clone();
                }
            }
            catch
            {
                // Bỏ qua lỗi trong quá trình tìm kiếm thử
            }
            return null;
        }

        private string GetWeatherDescription(int code)
        {
            if (code == 0) return userSettings.Language == "en-US" ? "Clear sky" : "Trời quang";
            if (code >= 1 && code <= 3) return userSettings.Language == "en-US" ? "Partly cloudy" : "Có mây";
            if (code == 45 || code == 48) return userSettings.Language == "en-US" ? "Foggy" : "Sương mù";
            if ((code >= 51 && code <= 67) || (code >= 80 && code <= 82)) return userSettings.Language == "en-US" ? "Rainy / Light rain" : "Mưa / Mưa rào nhẹ";
            if (code >= 95 && code <= 99) return userSettings.Language == "en-US" ? "Thunderstorm" : "Dông";
            return userSettings.Language == "en-US" ? "Normal" : "Bình thường";
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public ComboBoxItem(string text, string value) { Text = text; Value = value; }
        public override string ToString() => Text;
    }
}