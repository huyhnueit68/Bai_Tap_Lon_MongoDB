﻿namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QLMuonTra
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtId_Rent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListRentDevice = new System.Windows.Forms.DataGridView();
            this.Id_Rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errId_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.rdbId_Device = new System.Windows.Forms.RadioButton();
            this.rdbId_Rent = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTraTB = new System.Windows.Forms.Button();
            this.btnMuonTB = new System.Windows.Forms.Button();
            this.txtDate_Rent = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.errDay_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.mntNgayTra = new System.Windows.Forms.MonthCalendar();
            this.mntNgayMuon = new System.Windows.Forms.MonthCalendar();
            this.btnNgayTra = new System.Windows.Forms.Button();
            this.btnNgayMuon = new System.Windows.Forms.Button();
            this.rdbTra = new System.Windows.Forms.RadioButton();
            this.rdbMuon = new System.Windows.Forms.RadioButton();
            this.txtId_Device = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId_Customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate_Pay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errDay_Pay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errStatus_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRentDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Rent)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Rent)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Rent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(577, 38);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(127, 37);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtId_Rent
            // 
            this.txtId_Rent.Location = new System.Drawing.Point(114, 41);
            this.txtId_Rent.MaxLength = 20;
            this.txtId_Rent.Name = "txtId_Rent";
            this.txtId_Rent.Size = new System.Drawing.Size(131, 21);
            this.txtId_Rent.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Mượn";
            // 
            // dgvListRentDevice
            // 
            this.dgvListRentDevice.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvListRentDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRentDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Rent,
            this.Date_Rent,
            this.Date_Pay,
            this.Name_Device,
            this.Status_Device,
            this.Id_Type,
            this.Name_Customer,
            this.Id_Device,
            this.Room,
            this.Id_Customer,
            this.Id_Group});
            this.dgvListRentDevice.Location = new System.Drawing.Point(84, 309);
            this.dgvListRentDevice.Name = "dgvListRentDevice";
            this.dgvListRentDevice.RowHeadersWidth = 51;
            this.dgvListRentDevice.Size = new System.Drawing.Size(789, 157);
            this.dgvListRentDevice.TabIndex = 25;
            this.dgvListRentDevice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListRentDevice_MouseClick);
            // 
            // Id_Rent
            // 
            this.Id_Rent.DataPropertyName = "Id_Rent";
            this.Id_Rent.HeaderText = "Mã Mượn";
            this.Id_Rent.MinimumWidth = 6;
            this.Id_Rent.Name = "Id_Rent";
            this.Id_Rent.Width = 125;
            // 
            // Date_Rent
            // 
            this.Date_Rent.DataPropertyName = "Date_Rent";
            this.Date_Rent.HeaderText = "Ngày Mượn";
            this.Date_Rent.MinimumWidth = 6;
            this.Date_Rent.Name = "Date_Rent";
            this.Date_Rent.ReadOnly = true;
            this.Date_Rent.Width = 125;
            // 
            // Date_Pay
            // 
            this.Date_Pay.DataPropertyName = "Date_Pay";
            this.Date_Pay.HeaderText = "Ngày Trả";
            this.Date_Pay.MinimumWidth = 6;
            this.Date_Pay.Name = "Date_Pay";
            this.Date_Pay.Width = 125;
            // 
            // Name_Device
            // 
            this.Name_Device.DataPropertyName = "Name_Device";
            this.Name_Device.HeaderText = "Tên Thiết Bị";
            this.Name_Device.MinimumWidth = 6;
            this.Name_Device.Name = "Name_Device";
            this.Name_Device.Width = 125;
            // 
            // Status_Device
            // 
            this.Status_Device.DataPropertyName = "Status_Device";
            this.Status_Device.HeaderText = "Trang Thái";
            this.Status_Device.MinimumWidth = 6;
            this.Status_Device.Name = "Status_Device";
            this.Status_Device.Width = 125;
            // 
            // Id_Type
            // 
            this.Id_Type.DataPropertyName = "Id_Type";
            this.Id_Type.HeaderText = "Mã Loại TB";
            this.Id_Type.MinimumWidth = 6;
            this.Id_Type.Name = "Id_Type";
            this.Id_Type.Width = 125;
            // 
            // Name_Customer
            // 
            this.Name_Customer.DataPropertyName = "Name_Customer";
            this.Name_Customer.HeaderText = "Tên Khách Hàng";
            this.Name_Customer.MinimumWidth = 6;
            this.Name_Customer.Name = "Name_Customer";
            this.Name_Customer.Width = 125;
            // 
            // Id_Device
            // 
            this.Id_Device.DataPropertyName = "Id_Device";
            this.Id_Device.HeaderText = "Mã Thiết Bị";
            this.Id_Device.MinimumWidth = 6;
            this.Id_Device.Name = "Id_Device";
            this.Id_Device.Width = 125;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Phòng";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // Id_Customer
            // 
            this.Id_Customer.DataPropertyName = "Id_Customer";
            this.Id_Customer.HeaderText = "Mã khách hàng";
            this.Id_Customer.MinimumWidth = 6;
            this.Id_Customer.Name = "Id_Customer";
            this.Id_Customer.Width = 125;
            // 
            // Id_Group
            // 
            this.Id_Group.DataPropertyName = "Id_Group";
            this.Id_Group.HeaderText = "Mã Nhóm";
            this.Id_Group.MinimumWidth = 6;
            this.Id_Group.Name = "Id_Group";
            this.Id_Group.Width = 125;
            // 
            // errId_Rent
            // 
            this.errId_Rent.ContainerControl = this;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(732, 38);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 37);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.rdbId_Device);
            this.grp_TimKiem.Controls.Add(this.rdbId_Rent);
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(28, 472);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(890, 69);
            this.grp_TimKiem.TabIndex = 26;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            this.grp_TimKiem.Enter += new System.EventHandler(this.grp_TimKiem_Enter);
            // 
            // rdbId_Device
            // 
            this.rdbId_Device.AutoSize = true;
            this.rdbId_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Device.Location = new System.Drawing.Point(540, 29);
            this.rdbId_Device.Name = "rdbId_Device";
            this.rdbId_Device.Size = new System.Drawing.Size(87, 19);
            this.rdbId_Device.TabIndex = 5;
            this.rdbId_Device.TabStop = true;
            this.rdbId_Device.Text = "Mã Thiết Bị";
            this.rdbId_Device.UseVisualStyleBackColor = true;
            // 
            // rdbId_Rent
            // 
            this.rdbId_Rent.AutoSize = true;
            this.rdbId_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Rent.Location = new System.Drawing.Point(384, 30);
            this.rdbId_Rent.Name = "rdbId_Rent";
            this.rdbId_Rent.Size = new System.Drawing.Size(78, 19);
            this.rdbId_Rent.TabIndex = 4;
            this.rdbId_Rent.TabStop = true;
            this.rdbId_Rent.Text = "Mã Mượn";
            this.rdbId_Rent.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(744, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(251, 22);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // btnTraTB
            // 
            this.btnTraTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTraTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraTB.Location = new System.Drawing.Point(577, 129);
            this.btnTraTB.Name = "btnTraTB";
            this.btnTraTB.Size = new System.Drawing.Size(127, 37);
            this.btnTraTB.TabIndex = 21;
            this.btnTraTB.Text = "Trả Thiết Bị";
            this.btnTraTB.UseVisualStyleBackColor = false;
            this.btnTraTB.Click += new System.EventHandler(this.btnTraTB_Click);
            // 
            // btnMuonTB
            // 
            this.btnMuonTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMuonTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMuonTB.Location = new System.Drawing.Point(732, 129);
            this.btnMuonTB.Name = "btnMuonTB";
            this.btnMuonTB.Size = new System.Drawing.Size(127, 37);
            this.btnMuonTB.TabIndex = 19;
            this.btnMuonTB.Text = "Mượn Thiết Bị";
            this.btnMuonTB.UseVisualStyleBackColor = false;
            this.btnMuonTB.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // txtDate_Rent
            // 
            this.txtDate_Rent.Location = new System.Drawing.Point(114, 82);
            this.txtDate_Rent.MaxLength = 20;
            this.txtDate_Rent.Name = "txtDate_Rent";
            this.txtDate_Rent.Size = new System.Drawing.Size(98, 21);
            this.txtDate_Rent.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(19, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Ngày Mượn";
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(9, 9);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(658, 61);
            this.lbl_QLTaiKhoan.TabIndex = 23;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Mượn/Trả Thiết Bị";
            // 
            // errDay_Rent
            // 
            this.errDay_Rent.ContainerControl = this;
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgayTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgayMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnNgayTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnNgayMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.rdbTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.rdbMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.label6);
            this.grpThongTinTaiKhoan.Controls.Add(this.label4);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label3);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDate_Pay);
            this.grpThongTinTaiKhoan.Controls.Add(this.label2);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Rent);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnTraTB);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnMuonTB);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDate_Rent);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(28, 93);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(902, 264);
            this.grpThongTinTaiKhoan.TabIndex = 24;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            this.grpThongTinTaiKhoan.Enter += new System.EventHandler(this.grpThongTinTaiKhoan_Enter);
            // 
            // mntNgayTra
            // 
            this.mntNgayTra.Location = new System.Drawing.Point(47, 26);
            this.mntNgayTra.MaxSelectionCount = 1;
            this.mntNgayTra.Name = "mntNgayTra";
            this.mntNgayTra.TabIndex = 43;
            this.mntNgayTra.Visible = false;
            this.mntNgayTra.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayTra_DateChanged);
            this.mntNgayTra.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayTra_DateSelected);
            // 
            // mntNgayMuon
            // 
            this.mntNgayMuon.Location = new System.Drawing.Point(47, 14);
            this.mntNgayMuon.MaxSelectionCount = 1;
            this.mntNgayMuon.Name = "mntNgayMuon";
            this.mntNgayMuon.TabIndex = 42;
            this.mntNgayMuon.Visible = false;
            this.mntNgayMuon.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayMuon_DateSelected);
            // 
            // btnNgayTra
            // 
            this.btnNgayTra.Location = new System.Drawing.Point(218, 127);
            this.btnNgayTra.Name = "btnNgayTra";
            this.btnNgayTra.Size = new System.Drawing.Size(27, 23);
            this.btnNgayTra.TabIndex = 41;
            this.btnNgayTra.Text = "...";
            this.btnNgayTra.UseVisualStyleBackColor = true;
            this.btnNgayTra.Click += new System.EventHandler(this.btnNgayTra_Click);
            // 
            // btnNgayMuon
            // 
            this.btnNgayMuon.Location = new System.Drawing.Point(218, 82);
            this.btnNgayMuon.Name = "btnNgayMuon";
            this.btnNgayMuon.Size = new System.Drawing.Size(27, 23);
            this.btnNgayMuon.TabIndex = 40;
            this.btnNgayMuon.Text = "...";
            this.btnNgayMuon.UseVisualStyleBackColor = true;
            this.btnNgayMuon.Click += new System.EventHandler(this.btnNgayMuon_Click);
            // 
            // rdbTra
            // 
            this.rdbTra.AutoSize = true;
            this.rdbTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTra.Location = new System.Drawing.Point(479, 164);
            this.rdbTra.Name = "rdbTra";
            this.rdbTra.Size = new System.Drawing.Size(43, 19);
            this.rdbTra.TabIndex = 39;
            this.rdbTra.TabStop = true;
            this.rdbTra.Text = "Trả";
            this.rdbTra.UseVisualStyleBackColor = true;
            // 
            // rdbMuon
            // 
            this.rdbMuon.AutoSize = true;
            this.rdbMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMuon.Location = new System.Drawing.Point(384, 164);
            this.rdbMuon.Name = "rdbMuon";
            this.rdbMuon.Size = new System.Drawing.Size(57, 19);
            this.rdbMuon.TabIndex = 38;
            this.rdbMuon.TabStop = true;
            this.rdbMuon.Text = "Mượn";
            this.rdbMuon.UseVisualStyleBackColor = true;
            // 
            // txtId_Device
            // 
            this.txtId_Device.Location = new System.Drawing.Point(384, 54);
            this.txtId_Device.MaxLength = 20;
            this.txtId_Device.Name = "txtId_Device";
            this.txtId_Device.Size = new System.Drawing.Size(138, 21);
            this.txtId_Device.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã Thiết Bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Trạng Thái";
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Location = new System.Drawing.Point(384, 104);
            this.txtId_Customer.MaxLength = 20;
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(138, 21);
            this.txtId_Customer.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtDate_Pay
            // 
            this.txtDate_Pay.Location = new System.Drawing.Point(114, 128);
            this.txtDate_Pay.MaxLength = 20;
            this.txtDate_Pay.Name = "txtDate_Pay";
            this.txtDate_Pay.Size = new System.Drawing.Size(98, 21);
            this.txtDate_Pay.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày Trả";
            // 
            // errDay_Pay
            // 
            this.errDay_Pay.ContainerControl = this;
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // errQty_Device
            // 
            this.errQty_Device.ContainerControl = this;
            // 
            // errId_Customer
            // 
            this.errId_Customer.ContainerControl = this;
            // 
            // errStatus_Rent
            // 
            this.errStatus_Rent.ContainerControl = this;
            // 
            // QLMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 550);
            this.Controls.Add(this.dgvListRentDevice);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLMuonTra";
            this.Text = "QLMuonTra";
            this.Load += new System.EventHandler(this.QLMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRentDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Rent)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Rent)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Rent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtId_Rent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListRentDevice;
        private System.Windows.Forms.ErrorProvider errId_Rent;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.Button btnTraTB;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMuonTB;
        private System.Windows.Forms.TextBox txtDate_Rent;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errDay_Rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate_Pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Device;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbTra;
        private System.Windows.Forms.RadioButton rdbMuon;
        private System.Windows.Forms.Button btnNgayTra;
        private System.Windows.Forms.Button btnNgayMuon;
        private System.Windows.Forms.MonthCalendar mntNgayMuon;
        private System.Windows.Forms.MonthCalendar mntNgayTra;
        private System.Windows.Forms.ErrorProvider errDay_Pay;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errId_Customer;
        private System.Windows.Forms.ErrorProvider errStatus_Rent;
        private System.Windows.Forms.RadioButton rdbId_Device;
        private System.Windows.Forms.RadioButton rdbId_Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Group;
    }
}