using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapLamSingleTon {
	internal class Quanlynhanvien {
		Dictionary<string, NhanVien> danhsachnhanvien;
		Dictionary<string, NhanVien> danhsachnhanvienbixoa;

		public Quanlynhanvien() {
			this.danhsachnhanvien = new Dictionary<string, NhanVien>();
			this.danhsachnhanvienbixoa = new Dictionary<string, NhanVien>();
			NapFileTatCa();
		}

		public Quanlynhanvien(Dictionary<string, NhanVien> danhsachnhanvien, Dictionary<string, NhanVien> danhsachnhanvienbixoa) {
			this.danhsachnhanvien = danhsachnhanvien;
			this.danhsachnhanvienbixoa = danhsachnhanvienbixoa;
		}

		public Dictionary<string, NhanVien> Danhsachnhanvien {
			get { return this.danhsachnhanvien;}
			set { this.danhsachnhanvien = value; }
		}

		public Dictionary<string, NhanVien> Danhsachnhanvienbixoa {
			get { return this.danhsachnhanvienbixoa; }
			set { this.danhsachnhanvienbixoa = value; }
		}

		private bool DaTonTaiTrongDS(string ma) {
			foreach(NhanVien nv in this.danhsachnhanvien.Values) {
				if(nv.Maso == ma) {
					return true;
				}
			}
			return false;	
		}

		private bool DaTonTaiTrongDSXoa(string ma) {
			foreach(NhanVien nv in this.danhsachnhanvienbixoa.Values) {
				if(nv.Maso == ma) {
					return true;
				}
			}
			return false;
		}

		public bool KiemTraDSXoaCoTonTai() {
			if(this.danhsachnhanvienbixoa.Count > 0) {
				return true;
			}
			return false;
		}

		public NhanVien TimTheoMa(Dictionary<string, NhanVien> danhsach, string ma) {
			if(danhsach[ma] != null) {
				return danhsach[ma];
			}
			return null;
		}

		public Dictionary<string, NhanVien> LocDanhSachTheoGioiTinh(string gioitinh) {
			Dictionary<string, NhanVien> danhsachlocgioitinh = new Dictionary<string, NhanVien>();
			foreach(NhanVien nv in this.danhsachnhanvien.Values) {
				if(nv.Gioitinh == gioitinh) {
					danhsachlocgioitinh.Add(nv.Maso, nv);
				}
			}
			return danhsachlocgioitinh;
		}

		public Dictionary<string, NhanVien> LocDanhSachTheoLoaiNhanVien(string loainhanvien) {
			Dictionary<string, NhanVien> danhsachlocnhanvien = new Dictionary<string, NhanVien>();
			foreach(NhanVien nv in this.danhsachnhanvien.Values) {
				if(nv.Loainhanvien == loainhanvien) {
					danhsachlocnhanvien.Add(nv.Maso, nv);
				}
			}
			return danhsachlocnhanvien;
		}

		private void NapFileTatCa() {
			LuuVaNapFile.NapFile(this.danhsachnhanvien, LuuVaNapFile.tenfile_danhsachnhanvien);
			LuuVaNapFile.NapFile(this.danhsachnhanvienbixoa, LuuVaNapFile.tenfile_danhsachnhanvienbixoa);
		}

		private void LuuFileTatCa() {
			LuuVaNapFile.LuuFile(this.danhsachnhanvien, LuuVaNapFile.tenfile_danhsachnhanvien);
			LuuVaNapFile.LuuFile(this.danhsachnhanvienbixoa, LuuVaNapFile.tenfile_danhsachnhanvienbixoa);
		}

		public int DemTheoGioiTinh(string gioitinh) {
			int dem = 0;
			foreach(NhanVien nv in this.danhsachnhanvien.Values) {
				if(nv.Gioitinh == gioitinh) {
					dem++;
				}
			}
			return dem;
		}

		public int DemTheoLoaiNhanVien(string loai) {
			int dem = 0;
			foreach(NhanVien nv in this.danhsachnhanvien.Values) {
				if(nv.Loainhanvien == loai) {
					dem++;
				}
			}
			return dem;
		}

		private string Layten(string hoten) {
			string[] cactu = hoten.Trim().Split(' ');
			return cactu[cactu.Length - 1];
		}

		public int Laysoluongnhanvienbixoa() {
			return this.danhsachnhanvienbixoa.Count;
		}

		public bool Them(NhanVien nhanvienmoi) {
			if (DaTonTaiTrongDS(nhanvienmoi.Maso)) {
				return false;
			}
			if (DaTonTaiTrongDSXoa(nhanvienmoi.Maso)) {
				return false;
			}
			this.danhsachnhanvien.Add(nhanvienmoi.Maso, nhanvienmoi);
			LuuFileTatCa();
			return true;
		}

		public bool Xoa(string mamuonxoa) {
			if (!DaTonTaiTrongDS(mamuonxoa)) {
				return false;
			}
			this.danhsachnhanvienbixoa.Add(mamuonxoa, this.danhsachnhanvien[mamuonxoa]);
			this.danhsachnhanvien.Remove(mamuonxoa);
			LuuFileTatCa();
			return true;
		}

		public bool Sua(NhanVien nhanviencothongtinmoi) {
			if(!DaTonTaiTrongDS(nhanviencothongtinmoi.Maso)) {
				return false;
			}
			this.danhsachnhanvien[nhanviencothongtinmoi.Maso] = nhanviencothongtinmoi;
			LuuFileTatCa();
			return true;	
		}

		public Dictionary<string, NhanVien> Timkiem(string macantim) {
			if (!DaTonTaiTrongDS(macantim)) {
				return null;
			}
			Dictionary<string, NhanVien> danhsachcantim = new();
			danhsachcantim.Add(macantim, this.danhsachnhanvien[macantim]);
			return danhsachcantim;			
		}

		public bool Khoiphuc(string mamuonkhoiphuc) {
			if (DaTonTaiTrongDS(mamuonkhoiphuc)) {
				return false;
			}
			if(!DaTonTaiTrongDSXoa(mamuonkhoiphuc)) {
				return false;
			}
			this.danhsachnhanvien.Add(mamuonkhoiphuc, this.danhsachnhanvienbixoa[mamuonkhoiphuc]);
			this.danhsachnhanvienbixoa.Remove(mamuonkhoiphuc);
			LuuFileTatCa();
			return true;
		}

		public bool Sapxep(string sapxeptheo, string kieusapxep) {
			List<NhanVien> danhsach = this.danhsachnhanvien.Values.ToList();
			if (sapxeptheo == "Họ tên") {
				danhsach.Sort(
					(a, b) => string.Compare(Layten(a.Hoten), Layten(b.Hoten))
				);
			}
			else if (sapxeptheo == "Mã số") {
				danhsach.Sort(
					(a, b) => string.Compare(a.Maso, b.Maso)
				);
			}
			else if (sapxeptheo == "Ngày sinh") {
				danhsach.Sort(
					(a, b) => a.Ngaysinh.CompareTo(b.Ngaysinh)
				);
			}
			else {
				danhsach.Sort(
					(a, b) => a.Luong.CompareTo(b.Luong)
				);
			}
			if (kieusapxep == "Ngược") {
				danhsach.Reverse();
			}
			this.danhsachnhanvien = danhsach.ToDictionary(nv => nv.Maso, nv => nv);
			LuuFileTatCa();
			return true;
		}
	}
}
