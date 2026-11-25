namespace TapLamSingleTon
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
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txt_hoten = new TextBox();
			txt_maso = new TextBox();
			txt_luong = new TextBox();
			txt_diachi = new TextBox();
			dtp_ngaysinh = new DateTimePicker();
			groupBox1 = new GroupBox();
			rdbtn_nu = new RadioButton();
			rdbtn_nam = new RadioButton();
			groupBox2 = new GroupBox();
			rdbtn_kinhdoanh = new RadioButton();
			rdbtn_sanxuat = new RadioButton();
			rdbtn_vanphong = new RadioButton();
			groupBox3 = new GroupBox();
			btn_sapxep = new Button();
			btn_thoat = new Button();
			btn_them = new Button();
			btn_xoa = new Button();
			btn_thongke = new Button();
			btn_sua = new Button();
			btn_timkiem = new Button();
			btn_loc = new Button();
			btn_xemdanhsach = new Button();
			btn_xemdanhsachdaxoa = new Button();
			btn_khoiphuc = new Button();
			groupBox4 = new GroupBox();
			groupBox5 = new GroupBox();
			rdbtn_loctheoloainhanvien = new RadioButton();
			rdbtn_loctheogioitinh = new RadioButton();
			dgv_danhsachnhanvien = new DataGridView();
			chart_thongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
			groupBox6 = new GroupBox();
			rdbtn_thongketheoloainhanvien = new RadioButton();
			rdbtn_thongketheogioitinh = new RadioButton();
			groupBox7 = new GroupBox();
			rdbtn_sapxepluong = new RadioButton();
			rdbtn_sapxepngaysinh = new RadioButton();
			rdbtn_sapxepmaso = new RadioButton();
			rdbtn_sapxephoten = new RadioButton();
			groupBox8 = new GroupBox();
			rdbtn_sapxepnguoc = new RadioButton();
			rdbtn_sapxepxuoi = new RadioButton();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgv_danhsachnhanvien).BeginInit();
			((System.ComponentModel.ISupportInitialize)chart_thongke).BeginInit();
			groupBox6.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox8.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.Location = new Point(575, 22);
			label1.Name = "label1";
			label1.Size = new Size(274, 37);
			label1.TabIndex = 0;
			label1.Text = "QUẢN LÝ NHÂN VIÊN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(41, 99);
			label2.Name = "label2";
			label2.Size = new Size(54, 20);
			label2.TabIndex = 1;
			label2.Text = "Họ tên";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 151);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 2;
			label3.Text = "Mã số";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(40, 204);
			label4.Name = "label4";
			label4.Size = new Size(74, 20);
			label4.TabIndex = 3;
			label4.Text = "Ngày sinh";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(40, 260);
			label5.Name = "label5";
			label5.Size = new Size(51, 20);
			label5.TabIndex = 4;
			label5.Text = "Lương";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(41, 313);
			label6.Name = "label6";
			label6.Size = new Size(55, 20);
			label6.TabIndex = 5;
			label6.Text = "Địa chỉ";
			// 
			// txt_hoten
			// 
			txt_hoten.Location = new Point(148, 92);
			txt_hoten.Name = "txt_hoten";
			txt_hoten.Size = new Size(250, 27);
			txt_hoten.TabIndex = 6;
			// 
			// txt_maso
			// 
			txt_maso.Location = new Point(148, 144);
			txt_maso.Name = "txt_maso";
			txt_maso.Size = new Size(250, 27);
			txt_maso.TabIndex = 7;
			// 
			// txt_luong
			// 
			txt_luong.Location = new Point(148, 253);
			txt_luong.Name = "txt_luong";
			txt_luong.Size = new Size(250, 27);
			txt_luong.TabIndex = 9;
			// 
			// txt_diachi
			// 
			txt_diachi.Location = new Point(148, 306);
			txt_diachi.Name = "txt_diachi";
			txt_diachi.Size = new Size(250, 27);
			txt_diachi.TabIndex = 10;
			// 
			// dtp_ngaysinh
			// 
			dtp_ngaysinh.Location = new Point(148, 199);
			dtp_ngaysinh.Name = "dtp_ngaysinh";
			dtp_ngaysinh.Size = new Size(250, 27);
			dtp_ngaysinh.TabIndex = 11;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rdbtn_nu);
			groupBox1.Controls.Add(rdbtn_nam);
			groupBox1.Location = new Point(423, 92);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(147, 79);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "Giới tính";
			// 
			// rdbtn_nu
			// 
			rdbtn_nu.AutoSize = true;
			rdbtn_nu.Location = new Point(84, 38);
			rdbtn_nu.Name = "rdbtn_nu";
			rdbtn_nu.Size = new Size(50, 24);
			rdbtn_nu.TabIndex = 1;
			rdbtn_nu.TabStop = true;
			rdbtn_nu.Text = "Nữ";
			rdbtn_nu.UseVisualStyleBackColor = true;
			// 
			// rdbtn_nam
			// 
			rdbtn_nam.AutoSize = true;
			rdbtn_nam.Location = new Point(15, 38);
			rdbtn_nam.Name = "rdbtn_nam";
			rdbtn_nam.Size = new Size(62, 24);
			rdbtn_nam.TabIndex = 0;
			rdbtn_nam.TabStop = true;
			rdbtn_nam.Text = "Nam";
			rdbtn_nam.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(rdbtn_kinhdoanh);
			groupBox2.Controls.Add(rdbtn_sanxuat);
			groupBox2.Controls.Add(rdbtn_vanphong);
			groupBox2.Location = new Point(423, 199);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(147, 134);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Loại nhân viên";
			// 
			// rdbtn_kinhdoanh
			// 
			rdbtn_kinhdoanh.AutoSize = true;
			rdbtn_kinhdoanh.Location = new Point(15, 93);
			rdbtn_kinhdoanh.Name = "rdbtn_kinhdoanh";
			rdbtn_kinhdoanh.Size = new Size(105, 24);
			rdbtn_kinhdoanh.TabIndex = 2;
			rdbtn_kinhdoanh.TabStop = true;
			rdbtn_kinhdoanh.Text = "Kinh doanh";
			rdbtn_kinhdoanh.UseVisualStyleBackColor = true;
			// 
			// rdbtn_sanxuat
			// 
			rdbtn_sanxuat.AutoSize = true;
			rdbtn_sanxuat.Location = new Point(15, 63);
			rdbtn_sanxuat.Name = "rdbtn_sanxuat";
			rdbtn_sanxuat.Size = new Size(86, 24);
			rdbtn_sanxuat.TabIndex = 1;
			rdbtn_sanxuat.TabStop = true;
			rdbtn_sanxuat.Text = "Sản xuất";
			rdbtn_sanxuat.UseVisualStyleBackColor = true;
			// 
			// rdbtn_vanphong
			// 
			rdbtn_vanphong.AutoSize = true;
			rdbtn_vanphong.Location = new Point(15, 33);
			rdbtn_vanphong.Name = "rdbtn_vanphong";
			rdbtn_vanphong.Size = new Size(101, 24);
			rdbtn_vanphong.TabIndex = 0;
			rdbtn_vanphong.TabStop = true;
			rdbtn_vanphong.Text = "Văn phòng";
			rdbtn_vanphong.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btn_sapxep);
			groupBox3.Controls.Add(btn_thoat);
			groupBox3.Controls.Add(btn_them);
			groupBox3.Controls.Add(btn_xoa);
			groupBox3.Controls.Add(btn_thongke);
			groupBox3.Controls.Add(btn_sua);
			groupBox3.Controls.Add(btn_timkiem);
			groupBox3.Controls.Add(btn_loc);
			groupBox3.Location = new Point(1190, 92);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(138, 450);
			groupBox3.TabIndex = 14;
			groupBox3.TabStop = false;
			groupBox3.Text = "Các nút tính năng ";
			// 
			// btn_sapxep
			// 
			btn_sapxep.Location = new Point(23, 187);
			btn_sapxep.Name = "btn_sapxep";
			btn_sapxep.Size = new Size(94, 35);
			btn_sapxep.TabIndex = 6;
			btn_sapxep.Text = "Sắp xếp";
			btn_sapxep.UseVisualStyleBackColor = true;
			btn_sapxep.Click += btn_sapxep_Click;
			// 
			// btn_thoat
			// 
			btn_thoat.Location = new Point(23, 394);
			btn_thoat.Name = "btn_thoat";
			btn_thoat.Size = new Size(94, 35);
			btn_thoat.TabIndex = 5;
			btn_thoat.Text = "Thoát";
			btn_thoat.UseVisualStyleBackColor = true;
			btn_thoat.Click += btn_thoat_Click;
			// 
			// btn_them
			// 
			btn_them.Location = new Point(23, 38);
			btn_them.Name = "btn_them";
			btn_them.Size = new Size(94, 33);
			btn_them.TabIndex = 0;
			btn_them.Text = "Thêm";
			btn_them.UseVisualStyleBackColor = true;
			btn_them.Click += btn_them_Click;
			// 
			// btn_xoa
			// 
			btn_xoa.Location = new Point(23, 88);
			btn_xoa.Name = "btn_xoa";
			btn_xoa.Size = new Size(94, 33);
			btn_xoa.TabIndex = 1;
			btn_xoa.Text = "Xóa";
			btn_xoa.UseVisualStyleBackColor = true;
			btn_xoa.Click += btn_xoa_Click;
			// 
			// btn_thongke
			// 
			btn_thongke.Location = new Point(23, 342);
			btn_thongke.Name = "btn_thongke";
			btn_thongke.Size = new Size(94, 35);
			btn_thongke.TabIndex = 5;
			btn_thongke.Text = "Thống kê ";
			btn_thongke.UseVisualStyleBackColor = true;
			btn_thongke.Click += btn_thongke_Click;
			// 
			// btn_sua
			// 
			btn_sua.Location = new Point(23, 138);
			btn_sua.Name = "btn_sua";
			btn_sua.Size = new Size(94, 35);
			btn_sua.TabIndex = 2;
			btn_sua.Text = "Sửa";
			btn_sua.UseVisualStyleBackColor = true;
			btn_sua.Click += btn_sua_Click;
			// 
			// btn_timkiem
			// 
			btn_timkiem.Location = new Point(23, 241);
			btn_timkiem.Name = "btn_timkiem";
			btn_timkiem.Size = new Size(94, 33);
			btn_timkiem.TabIndex = 3;
			btn_timkiem.Text = "Tìm kiếm";
			btn_timkiem.UseVisualStyleBackColor = true;
			btn_timkiem.Click += btn_timkiem_Click;
			// 
			// btn_loc
			// 
			btn_loc.Location = new Point(23, 292);
			btn_loc.Name = "btn_loc";
			btn_loc.Size = new Size(94, 33);
			btn_loc.TabIndex = 4;
			btn_loc.Text = "Lọc";
			btn_loc.UseVisualStyleBackColor = true;
			btn_loc.Click += btn_loc_Click;
			// 
			// btn_xemdanhsach
			// 
			btn_xemdanhsach.Location = new Point(597, 297);
			btn_xemdanhsach.Name = "btn_xemdanhsach";
			btn_xemdanhsach.Size = new Size(241, 36);
			btn_xemdanhsach.TabIndex = 6;
			btn_xemdanhsach.Text = "Xem danh sách";
			btn_xemdanhsach.UseVisualStyleBackColor = true;
			btn_xemdanhsach.Click += btn_xemdanhsach_Click;
			// 
			// btn_xemdanhsachdaxoa
			// 
			btn_xemdanhsachdaxoa.Location = new Point(21, 29);
			btn_xemdanhsachdaxoa.Name = "btn_xemdanhsachdaxoa";
			btn_xemdanhsachdaxoa.Size = new Size(205, 33);
			btn_xemdanhsachdaxoa.TabIndex = 15;
			btn_xemdanhsachdaxoa.Text = "Xem danh sách đã xóa";
			btn_xemdanhsachdaxoa.UseVisualStyleBackColor = true;
			btn_xemdanhsachdaxoa.Click += btn_xemdanhsachdaxoa_Click;
			// 
			// btn_khoiphuc
			// 
			btn_khoiphuc.Location = new Point(21, 68);
			btn_khoiphuc.Name = "btn_khoiphuc";
			btn_khoiphuc.Size = new Size(205, 29);
			btn_khoiphuc.TabIndex = 16;
			btn_khoiphuc.Text = "Khôi phục";
			btn_khoiphuc.UseVisualStyleBackColor = true;
			btn_khoiphuc.Click += btn_khoiphuc_Click;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(btn_xemdanhsachdaxoa);
			groupBox4.Controls.Add(btn_khoiphuc);
			groupBox4.Location = new Point(597, 92);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(241, 112);
			groupBox4.TabIndex = 17;
			groupBox4.TabStop = false;
			groupBox4.Text = "Khôi phục";
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(rdbtn_loctheoloainhanvien);
			groupBox5.Controls.Add(rdbtn_loctheogioitinh);
			groupBox5.Location = new Point(597, 221);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(241, 59);
			groupBox5.TabIndex = 18;
			groupBox5.TabStop = false;
			groupBox5.Text = "Lọc theo";
			// 
			// rdbtn_loctheoloainhanvien
			// 
			rdbtn_loctheoloainhanvien.AutoSize = true;
			rdbtn_loctheoloainhanvien.Location = new Point(110, 26);
			rdbtn_loctheoloainhanvien.Name = "rdbtn_loctheoloainhanvien";
			rdbtn_loctheoloainhanvien.Size = new Size(125, 24);
			rdbtn_loctheoloainhanvien.TabIndex = 2;
			rdbtn_loctheoloainhanvien.TabStop = true;
			rdbtn_loctheoloainhanvien.Text = "Loại nhân viên";
			rdbtn_loctheoloainhanvien.UseVisualStyleBackColor = true;
			// 
			// rdbtn_loctheogioitinh
			// 
			rdbtn_loctheogioitinh.AutoSize = true;
			rdbtn_loctheogioitinh.Location = new Point(18, 26);
			rdbtn_loctheogioitinh.Name = "rdbtn_loctheogioitinh";
			rdbtn_loctheogioitinh.Size = new Size(86, 24);
			rdbtn_loctheogioitinh.TabIndex = 1;
			rdbtn_loctheogioitinh.TabStop = true;
			rdbtn_loctheogioitinh.Text = "Giới tính";
			rdbtn_loctheogioitinh.UseVisualStyleBackColor = true;
			// 
			// dgv_danhsachnhanvien
			// 
			dgv_danhsachnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_danhsachnhanvien.Location = new Point(41, 352);
			dgv_danhsachnhanvien.Name = "dgv_danhsachnhanvien";
			dgv_danhsachnhanvien.RowHeadersWidth = 51;
			dgv_danhsachnhanvien.Size = new Size(1114, 408);
			dgv_danhsachnhanvien.TabIndex = 19;
			dgv_danhsachnhanvien.CellContentClick += dgv_danhsachnhanvien_CellContentClick;
			// 
			// chart_thongke
			// 
			chart_thongke.BackColor = SystemColors.Control;
			chart_thongke.BorderlineColor = SystemColors.Control;
			chartArea1.Name = "ChartArea1";
			chart_thongke.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chart_thongke.Legends.Add(legend1);
			chart_thongke.Location = new Point(41, 352);
			chart_thongke.Name = "chart_thongke";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chart_thongke.Series.Add(series1);
			chart_thongke.Size = new Size(1114, 408);
			chart_thongke.TabIndex = 20;
			chart_thongke.Text = "chart1";
			chart_thongke.Visible = false;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(rdbtn_thongketheoloainhanvien);
			groupBox6.Controls.Add(rdbtn_thongketheogioitinh);
			groupBox6.Location = new Point(863, 99);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(157, 105);
			groupBox6.TabIndex = 14;
			groupBox6.TabStop = false;
			groupBox6.Text = "Thống kê theo";
			// 
			// rdbtn_thongketheoloainhanvien
			// 
			rdbtn_thongketheoloainhanvien.AutoSize = true;
			rdbtn_thongketheoloainhanvien.Location = new Point(16, 66);
			rdbtn_thongketheoloainhanvien.Name = "rdbtn_thongketheoloainhanvien";
			rdbtn_thongketheoloainhanvien.Size = new Size(125, 24);
			rdbtn_thongketheoloainhanvien.TabIndex = 4;
			rdbtn_thongketheoloainhanvien.TabStop = true;
			rdbtn_thongketheoloainhanvien.Text = "Loại nhân viên";
			rdbtn_thongketheoloainhanvien.UseVisualStyleBackColor = true;
			// 
			// rdbtn_thongketheogioitinh
			// 
			rdbtn_thongketheogioitinh.AutoSize = true;
			rdbtn_thongketheogioitinh.Location = new Point(16, 31);
			rdbtn_thongketheogioitinh.Name = "rdbtn_thongketheogioitinh";
			rdbtn_thongketheogioitinh.Size = new Size(86, 24);
			rdbtn_thongketheogioitinh.TabIndex = 3;
			rdbtn_thongketheogioitinh.TabStop = true;
			rdbtn_thongketheogioitinh.Text = "Giới tính";
			rdbtn_thongketheogioitinh.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(rdbtn_sapxepluong);
			groupBox7.Controls.Add(rdbtn_sapxepngaysinh);
			groupBox7.Controls.Add(rdbtn_sapxepmaso);
			groupBox7.Controls.Add(rdbtn_sapxephoten);
			groupBox7.Location = new Point(863, 228);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(301, 105);
			groupBox7.TabIndex = 15;
			groupBox7.TabStop = false;
			groupBox7.Text = "Sắp xếp theo ";
			// 
			// rdbtn_sapxepluong
			// 
			rdbtn_sapxepluong.AutoSize = true;
			rdbtn_sapxepluong.Location = new Point(173, 64);
			rdbtn_sapxepluong.Name = "rdbtn_sapxepluong";
			rdbtn_sapxepluong.Size = new Size(72, 24);
			rdbtn_sapxepluong.TabIndex = 6;
			rdbtn_sapxepluong.TabStop = true;
			rdbtn_sapxepluong.Text = "Lương";
			rdbtn_sapxepluong.UseVisualStyleBackColor = true;
			// 
			// rdbtn_sapxepngaysinh
			// 
			rdbtn_sapxepngaysinh.AutoSize = true;
			rdbtn_sapxepngaysinh.Location = new Point(173, 32);
			rdbtn_sapxepngaysinh.Name = "rdbtn_sapxepngaysinh";
			rdbtn_sapxepngaysinh.Size = new Size(99, 24);
			rdbtn_sapxepngaysinh.TabIndex = 5;
			rdbtn_sapxepngaysinh.TabStop = true;
			rdbtn_sapxepngaysinh.Text = "Ngày sinh ";
			rdbtn_sapxepngaysinh.UseVisualStyleBackColor = true;
			// 
			// rdbtn_sapxepmaso
			// 
			rdbtn_sapxepmaso.AutoSize = true;
			rdbtn_sapxepmaso.Location = new Point(16, 66);
			rdbtn_sapxepmaso.Name = "rdbtn_sapxepmaso";
			rdbtn_sapxepmaso.Size = new Size(70, 24);
			rdbtn_sapxepmaso.TabIndex = 4;
			rdbtn_sapxepmaso.TabStop = true;
			rdbtn_sapxepmaso.Text = "Mã số";
			rdbtn_sapxepmaso.UseVisualStyleBackColor = true;
			// 
			// rdbtn_sapxephoten
			// 
			rdbtn_sapxephoten.AutoSize = true;
			rdbtn_sapxephoten.Location = new Point(16, 31);
			rdbtn_sapxephoten.Name = "rdbtn_sapxephoten";
			rdbtn_sapxephoten.Size = new Size(75, 24);
			rdbtn_sapxephoten.TabIndex = 3;
			rdbtn_sapxephoten.TabStop = true;
			rdbtn_sapxephoten.Text = "Họ tên";
			rdbtn_sapxephoten.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(rdbtn_sapxepnguoc);
			groupBox8.Controls.Add(rdbtn_sapxepxuoi);
			groupBox8.Location = new Point(1036, 99);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(128, 105);
			groupBox8.TabIndex = 15;
			groupBox8.TabStop = false;
			groupBox8.Text = "Quy tắc xếp";
			// 
			// rdbtn_sapxepnguoc
			// 
			rdbtn_sapxepnguoc.AutoSize = true;
			rdbtn_sapxepnguoc.Location = new Point(16, 66);
			rdbtn_sapxepnguoc.Name = "rdbtn_sapxepnguoc";
			rdbtn_sapxepnguoc.Size = new Size(75, 24);
			rdbtn_sapxepnguoc.TabIndex = 4;
			rdbtn_sapxepnguoc.TabStop = true;
			rdbtn_sapxepnguoc.Text = "Ngược";
			rdbtn_sapxepnguoc.UseVisualStyleBackColor = true;
			// 
			// rdbtn_sapxepxuoi
			// 
			rdbtn_sapxepxuoi.AutoSize = true;
			rdbtn_sapxepxuoi.Location = new Point(16, 31);
			rdbtn_sapxepxuoi.Name = "rdbtn_sapxepxuoi";
			rdbtn_sapxepxuoi.Size = new Size(60, 24);
			rdbtn_sapxepxuoi.TabIndex = 3;
			rdbtn_sapxepxuoi.TabStop = true;
			rdbtn_sapxepxuoi.Text = "Xuôi";
			rdbtn_sapxepxuoi.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1367, 782);
			Controls.Add(groupBox8);
			Controls.Add(groupBox7);
			Controls.Add(groupBox6);
			Controls.Add(chart_thongke);
			Controls.Add(dgv_danhsachnhanvien);
			Controls.Add(groupBox5);
			Controls.Add(btn_xemdanhsach);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(dtp_ngaysinh);
			Controls.Add(txt_diachi);
			Controls.Add(txt_luong);
			Controls.Add(txt_maso);
			Controls.Add(txt_hoten);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Name = "Form1";
			Text = "Quản lý nhân viên ";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgv_danhsachnhanvien).EndInit();
			((System.ComponentModel.ISupportInitialize)chart_thongke).EndInit();
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txt_hoten;
		private TextBox txt_maso;
		private TextBox txt_luong;
		private TextBox txt_diachi;
		private DateTimePicker dtp_ngaysinh;
		private GroupBox groupBox1;
		private RadioButton rdbtn_nu;
		private RadioButton rdbtn_nam;
		private GroupBox groupBox2;
		private RadioButton rdbtn_kinhdoanh;
		private RadioButton rdbtn_sanxuat;
		private RadioButton rdbtn_vanphong;
		private GroupBox groupBox3;
		private Button btn_thoat;
		private Button btn_them;
		private Button btn_xoa;
		private Button btn_loc;
		private Button btn_sua;
		private Button btn_timkiem;
		private Button btn_xemdanhsach;
		private Button btn_xemdanhsachdaxoa;
		private Button btn_khoiphuc;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		private RadioButton rdbtn_loctheoloainhanvien;
		private RadioButton rdbtn_loctheogioitinh;
		private DataGridView dgv_danhsachnhanvien;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart_thongke;
		private GroupBox groupBox6;
		private Button btn_thongke;
		private RadioButton rdbtn_thongketheoloainhanvien;
		private RadioButton rdbtn_thongketheogioitinh;
		private Button btn_sapxep;
		private GroupBox groupBox7;
		private RadioButton rdbtn_sapxepmaso;
		private RadioButton rdbtn_sapxephoten;
		private RadioButton rdbtn_sapxepluong;
		private RadioButton rdbtn_sapxepngaysinh;
		private GroupBox groupBox8;
		private RadioButton rdbtn_sapxepnguoc;
		private RadioButton rdbtn_sapxepxuoi;
	}
}
