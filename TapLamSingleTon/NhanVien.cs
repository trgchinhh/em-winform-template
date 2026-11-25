using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapLamSingleTon {
	internal class NhanVien {
		private string hoten;
		private string maso;
		private DateTime ngaysinh;
		private string gioitinh;
		private string loainhanvien;
		private string diachi;
		private double luong;

		public NhanVien() {
			this.hoten = null;
			this.maso = null;
			this.ngaysinh = DateTime.Now;
			this.gioitinh = null;
			this.loainhanvien = null;
			this.diachi = null;
			this.luong = 0f;
		}

		public NhanVien(string hoten, string maso, DateTime ngaysinh, string gioitinh, string loainhanvien, string diachi, double luong) {
			this.hoten = hoten;
			this.maso = maso;
			this.ngaysinh = ngaysinh;
			this.gioitinh = gioitinh;
			this.loainhanvien = loainhanvien;
			this.diachi = diachi;
			this.luong = luong;
		}

		public string Hoten {
			get { return this.hoten; }	
			set { this.hoten = value; }
		}

		public string Maso {
			get { return this.maso; }
			set { this.maso = value; }
		}

		public DateTime Ngaysinh {
			get { return this.ngaysinh; }
			set { this.ngaysinh = value; }
		}

		public string Gioitinh {
			get { return this.gioitinh; }
			set { this.gioitinh = value; }
		}

		public string Loainhanvien {
			get { return this.loainhanvien; }
			set { this.loainhanvien = value; }
		}

		public string Diachi {
			get { return this.diachi; }
			set { this.diachi = value; }
		}

		public double Luong {
			get { return this.luong; }
			set { this.luong = value; }
		}
	}
}
