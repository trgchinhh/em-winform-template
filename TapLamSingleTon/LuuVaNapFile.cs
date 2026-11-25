using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TapLamSingleTon {
	internal class LuuVaNapFile {
		public static string tenfile_danhsachnhanvien = "Danhsachnhanvien.txt";
		public static string tenfile_danhsachnhanvienbixoa = "Danhsachnhanvienbixoa.txt";

		public static void LuuFile(Dictionary<string, NhanVien> danhsachnhanvien, string tenfile) {
			if (!File.Exists(tenfile)) {
				File.Create(tenfile).Close(); 
			}
			string tatcanoidung = "";
			foreach(NhanVien nv in danhsachnhanvien.Values) {
				tatcanoidung += nv.Hoten + ";"
							  + nv.Maso + ";"
							  + nv.Ngaysinh + ";"
							  + nv.Gioitinh + ";"
							  + nv.Loainhanvien + ";"
							  + nv.Diachi + ";"
							  + nv.Luong + "\n";
			}
			File.WriteAllText(tenfile, tatcanoidung);
		}

		public static void NapFile(Dictionary<string, NhanVien> danhsachnhanvien, string tenfile) {
			if (!File.Exists(tenfile)) {
				File.Create(tenfile).Close();
				return;
			}
			string[] tatcanoidung = File.ReadAllLines(tenfile);
			foreach(string dong in tatcanoidung) {
				string[] noidung = dong.Split(';');
				NhanVien nv = new NhanVien(
					noidung[0],
					noidung[1],
					DateTime.Parse(noidung[2]),
					noidung[3],
					noidung[4],
					noidung[5],
					double.Parse(noidung[6])
				);
				danhsachnhanvien.Add(nv.Maso, nv);
			}
		}
	}
}
