using System.Windows.Forms.DataVisualization.Charting;

namespace TapLamSingleTon
{
	public partial class Form1 : Form {
		Quanlynhanvien quanlynhanvien = new Quanlynhanvien();

		public Form1() {
			InitializeComponent();
			Datradiobuttonmacdinh();
			Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
		}

		private void Datradiobuttonmacdinh() {
			rdbtn_nam.Checked = true;
			rdbtn_vanphong.Checked = true;
			rdbtn_loctheogioitinh.Checked = true;
			rdbtn_thongketheogioitinh.Checked = true;
			rdbtn_sapxephoten.Checked = true;
			rdbtn_sapxepxuoi.Checked = true;
			btn_xemdanhsachdaxoa.Text = $"Xem danh sách đã xóa ({quanlynhanvien.Laysoluongnhanvienbixoa()})";
		}

		private bool Kiemtranhapdu() {
			if (txt_hoten.Text == "" || txt_maso.Text == "" || txt_luong.Text == "" || txt_diachi.Text == "") {
				return false;
			}
			return true;
		}

		private bool Kiemtrangaysinhhople() {
			if (dtp_ngaysinh.Value.Date >= DateTime.Today) {
				return false;
			}
			return true;
		}

		private string Laygioitinh() {
			if (rdbtn_nam.Checked) {
				return "Nam";
			}
			return "Nữ";
		}

		private string Layloainhanvien() {
			if (rdbtn_kinhdoanh.Checked) {
				return "Kinh doanh";
			}
			if (rdbtn_sanxuat.Checked) {
				return "Sản xuất";
			}
			return "Văn phòng";
		}

		private string Laysapxeptheo() {
			if (rdbtn_sapxephoten.Checked) {
				return "Họ tên";
			}
			else if (rdbtn_sapxepmaso.Checked) {
				return "Mã số";
			}
			else if (rdbtn_sapxepngaysinh.Checked) {
				return "Ngày sinh";
			}
			else return "Lương";
		}

		private string Layquytacsapxep() {
			if(rdbtn_sapxepxuoi.Checked) {
				return "Xuôi";
			}
			return "Ngược";
		}

		private void Hienthidanhsach(Dictionary<string, NhanVien> danhsachnhanvien) {
			chart_thongke.Visible = false;
			dgv_danhsachnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgv_danhsachnhanvien.DataSource = danhsachnhanvien.Values.ToList();
		}

		private void btn_them_Click(object sender, EventArgs e) {
			if (!Kiemtranhapdu()) {
				MessageBox.Show(
					"Vui lòng nhập đủ thông tin",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			if (!Kiemtrangaysinhhople()) {
				MessageBox.Show(
					"Vui lòng chọn ngày sinh hợp lệ",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			NhanVien nhanvienmoi = new NhanVien(
				txt_hoten.Text,
				txt_maso.Text,
				dtp_ngaysinh.Value.Date,
				Laygioitinh(),
				Layloainhanvien(),
				txt_diachi.Text,
				double.Parse(txt_luong.Text)
			);
			if (!quanlynhanvien.Them(nhanvienmoi)) {
				MessageBox.Show(
					"Không thể thêm nhân viên (vì trùng mã)",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			else {
				Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
				MessageBox.Show(
					$"Thêm thành công nhân viên {nhanvienmoi.Hoten} - {nhanvienmoi.Maso}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e) {
			if (txt_maso.Text == "") {
				MessageBox.Show(
					"Vui lòng nhập mã nhân viên muốn xóa",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			NhanVien nhanvienmuonxoa = quanlynhanvien.TimTheoMa(
				quanlynhanvien.Danhsachnhanvien,
				txt_maso.Text
			);
			if (nhanvienmuonxoa == null) {
				MessageBox.Show(
					$"Không tìm thấy nhân viên muốn xóa có mã {txt_maso.Text}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			DialogResult luachon = MessageBox.Show(
				$"Bạn có chắc muốn xóa nhân viên {nhanvienmuonxoa.Hoten} - {nhanvienmuonxoa.Maso}",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);
			if (luachon == DialogResult.Yes) {
				quanlynhanvien.Xoa(txt_maso.Text);
				Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
				MessageBox.Show(
					$"Đã xóa nhân viên {txt_maso.Text}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			btn_xemdanhsachdaxoa.Text = $"Xem danh sách đã xóa ({quanlynhanvien.Laysoluongnhanvienbixoa()})";
		}

		private void btn_sua_Click(object sender, EventArgs e) {
			if (!Kiemtranhapdu()) {
				MessageBox.Show(
					"Vui lòng nhập đủ thông tin muốn sửa",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			if (!Kiemtrangaysinhhople()) {
				MessageBox.Show(
					"Vui lòng chọn ngày sinh hợp lệ",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			NhanVien nhanviencansua = quanlynhanvien.TimTheoMa(
				quanlynhanvien.Danhsachnhanvien,
				txt_maso.Text
			);
			if (nhanviencansua == null) {
				MessageBox.Show(
					$"Không tìm thấy nhân viên cần sửa theo mã {txt_maso.Text}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			DialogResult luachon = MessageBox.Show(
				$"Bạn có chắc muốn sửa thông tin nhân viên {nhanviencansua.Hoten}",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);
			if (luachon == DialogResult.Yes) {
				NhanVien nhanviencothongtinmoi = new NhanVien(
					txt_hoten.Text,
					txt_maso.Text,
					dtp_ngaysinh.Value.Date,
					Laygioitinh(),
					Layloainhanvien(),
					txt_diachi.Text,
					double.Parse(txt_luong.Text)
				);
				quanlynhanvien.Sua(nhanviencothongtinmoi);
				Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
				MessageBox.Show(
					$"Đã sửa thành công thông tin nhân viên {txt_hoten.Text}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
			LuuVaNapFile.LuuFile(quanlynhanvien.Danhsachnhanvien, LuuVaNapFile.tenfile_danhsachnhanvien);
		}

		private void btn_timkiem_Click(object sender, EventArgs e) {
			if (txt_maso.Text == "") {
				MessageBox.Show(
					"Vui lòng nhập mã nhân viên muốn tìm kiếm",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			NhanVien nhanviencantim = quanlynhanvien.TimTheoMa(
				quanlynhanvien.Danhsachnhanvien,
				txt_maso.Text
			);
			if (nhanviencantim == null) {
				MessageBox.Show(
					$"Không tìm thấy nhân viên nào có mã {txt_maso.Text}",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			Dictionary<string, NhanVien> danhsachtimkiem = quanlynhanvien.Timkiem(txt_maso.Text);
			Hienthidanhsach(danhsachtimkiem);
		}

		private void btn_loc_Click(object sender, EventArgs e) {
			if (rdbtn_loctheogioitinh.Checked) {
				string gioitinh = Laygioitinh();
				Dictionary<string, NhanVien> danhsachloctheogioitinh = quanlynhanvien.LocDanhSachTheoGioiTinh(gioitinh);
				Hienthidanhsach(danhsachloctheogioitinh);
			}
			if (rdbtn_loctheoloainhanvien.Checked) {
				string loainhanvien = Layloainhanvien();
				Dictionary<string, NhanVien> danhsachloctheoloainhanvien = quanlynhanvien.LocDanhSachTheoLoaiNhanVien(loainhanvien);
				Hienthidanhsach(danhsachloctheoloainhanvien);
			}
		}

		private void btn_thoat_Click(object sender, EventArgs e) {
			DialogResult luachon = MessageBox.Show(
				"Bạn có chắc muốn thoát",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);
			if (luachon == DialogResult.Yes) {
				this.Close();
			}
		}

		private void btn_xemdanhsachdaxoa_Click(object sender, EventArgs e) {
			Hienthidanhsach(quanlynhanvien.Danhsachnhanvienbixoa);
		}

		private void btn_khoiphuc_Click(object sender, EventArgs e) {
			if (!quanlynhanvien.KiemTraDSXoaCoTonTai()) {
				MessageBox.Show(
					"Danh sách xóa không tồn tại nhân viên nào để khôi phục",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			NhanVien nhanvienmuonkhoiphuc = quanlynhanvien.TimTheoMa(
				quanlynhanvien.Danhsachnhanvienbixoa,
				quanlynhanvien.Danhsachnhanvienbixoa.Keys.Last()
			);
			if (nhanvienmuonkhoiphuc == null) {
				MessageBox.Show(
					"Không tìm thấy nhân viên nào muốn khôi phục",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			DialogResult luachon = MessageBox.Show(
				$"Bạn có muốn khôi phục thông tin nhân viên: {nhanvienmuonkhoiphuc.Hoten} - {nhanvienmuonkhoiphuc.Maso}",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);
			if (luachon == DialogResult.Yes) {
				quanlynhanvien.Khoiphuc(quanlynhanvien.Danhsachnhanvienbixoa.Keys.Last());
				Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
			}
			btn_xemdanhsachdaxoa.Text = $"Xem danh sách đã xóa ({quanlynhanvien.Laysoluongnhanvienbixoa()})";
		}

		private void btn_xemdanhsach_Click(object sender, EventArgs e) {
			Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
		}

		private void dgv_danhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			int hanghientai = dgv_danhsachnhanvien.CurrentRow.Index;
			if (hanghientai < 0) {
				return;
			}
			var dulieu = dgv_danhsachnhanvien.Rows[hanghientai];
			txt_hoten.Text = dulieu.Cells[0].Value.ToString();
			txt_maso.Text = dulieu.Cells[1].Value.ToString();
			dtp_ngaysinh.Text = dulieu.Cells[2].Value.ToString();
			string gioitinh = dulieu.Cells[3].Value.ToString();
			if (gioitinh == "Nam") rdbtn_nam.Checked = true;
			else rdbtn_nu.Checked = true;
			string loainhanvien = dulieu.Cells[4].Value.ToString();
			if (loainhanvien == "Văn phòng") rdbtn_vanphong.Checked = true;
			else if (loainhanvien == "Sản xuất") rdbtn_sanxuat.Checked = true;
			else rdbtn_kinhdoanh.Checked = true;
			txt_diachi.Text = dulieu.Cells[6].Value.ToString();
			txt_luong.Text = dulieu.Cells[5].Value.ToString();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void VeBieuDoCotNgang(Dictionary<string, int> dulieu) {
			chart_thongke.Series.Clear();
			chart_thongke.Titles.Clear();
			chart_thongke.Legends.Clear();
			if (chart_thongke.ChartAreas.Count == 0) {
				chart_thongke.ChartAreas.Add(new ChartArea("area1"));
			}
			Font font10 = new Font("Segoe UI", 10);
			Font font10dam = new Font("Segoe UI", 10, FontStyle.Bold);
			ChartArea area = chart_thongke.ChartAreas[0];
			area.AxisX.MajorGrid.Enabled = false;
			area.AxisX.Interval = 1;
			area.AxisX.LabelStyle.Interval = 1;
			area.AxisX.IsLabelAutoFit = false;
			area.AxisX.IsReversed = true;
			area.AxisX.LabelStyle.Font = font10;     
			area.AxisY.LabelStyle.Font = font10;     
			area.AxisY.Minimum = 0;
			area.AxisY.Title = "Số lượng nhân viên";
			area.AxisY.TitleFont = font10;           
			area.AxisY.MajorGrid.LineColor = Color.LightGray;
			Series series = new Series("Số lượng") {
				ChartType = SeriesChartType.Bar,
				IsValueShownAsLabel = true,
				IsXValueIndexed = true,
				Font = font10dam                     
			};
			series["PointWidth"] = "0.6";
			Color[] bangmau = {
				Color.SteelBlue, Color.IndianRed, Color.SeaGreen,
				Color.Orange, Color.MediumPurple
			};
			int i = 0;
			foreach (var item in dulieu) {
				int idx = series.Points.AddXY(item.Key, item.Value);
				series.Points[idx].AxisLabel = item.Key;
				series.Points[idx].Label = item.Value.ToString();
				series.Points[idx].Font = font10dam;
				series.Points[idx].Color = bangmau[i % bangmau.Length];
				i++;
			}
			chart_thongke.Series.Add(series);
		}

		private void btn_thongke_Click(object sender, EventArgs e) {
			if (quanlynhanvien.Danhsachnhanvien.Count == 0) {
				MessageBox.Show(
					"Chưa có nhân viên nào để thống kê",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}
			chart_thongke.Visible = true;
			if (rdbtn_thongketheogioitinh.Checked) {
				string[] gioitinhchophep = { "Nam", "Nữ" };
				Dictionary<string, int> thongkegioitinh = new Dictionary<string, int>();
				foreach (string gioitinh in gioitinhchophep) {
					thongkegioitinh[gioitinh] = quanlynhanvien.DemTheoGioiTinh(gioitinh);
				}
				VeBieuDoCotNgang(thongkegioitinh);
			}
			else {
				string[] loainhanvienchophep = { "Văn phòng", "Sản xuất", "Kinh doanh" };
				Dictionary<string, int> thongkeloainhanvien = new Dictionary<string, int>();
				foreach (string loainhanvien in loainhanvienchophep) {
					thongkeloainhanvien[loainhanvien] = quanlynhanvien.DemTheoLoaiNhanVien(loainhanvien);
				}
				VeBieuDoCotNgang(thongkeloainhanvien);
			}
		}

		private void btn_sapxep_Click(object sender, EventArgs e) {
			string sapxeptheo = Laysapxeptheo();
			string quytac = Layquytacsapxep();
			quanlynhanvien.Sapxep(sapxeptheo, quytac);
			Hienthidanhsach(quanlynhanvien.Danhsachnhanvien);
		}
	}
}
