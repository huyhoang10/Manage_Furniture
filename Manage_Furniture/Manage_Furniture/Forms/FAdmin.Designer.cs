namespace Manage_Furniture.Forms
{
    partial class FAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected virtual void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdmin));
            this.pnlAllButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHopDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnChucVuvaVaiTro = new Guna.UI2.WinForms.Guna2Button();
            this.btnBangLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserControls = new Guna.UI2.WinForms.Guna2Panel();
            this.ucHistory1 = new Manage_Furniture.Forms.ucHopDong();
            this.ucHR1 = new Manage_Furniture.Controls.ucHR();
            this.ucSuppliercs1 = new Manage_Furniture.Forms.ucChucVuVaiTro();
            this.ucWarehouse1 = new Manage_Furniture.Forms.ucBangLuong();
            this.ucCustomer1 = new Manage_Furniture.Controls.ucChamCong();
            this.ucOrder1 = new Manage_Furniture.Forms.UCPhongBan();
            this.ucOverview1 = new Manage_Furniture.Forms.ucTaiKhoan();
            this.pnlAllButton.SuspendLayout();
            this.pnlUserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAllButton
            // 
            this.pnlAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlAllButton.Controls.Add(this.btnHopDong);
            this.pnlAllButton.Controls.Add(this.btnUser);
            this.pnlAllButton.Controls.Add(this.btnNhanVien);
            this.pnlAllButton.Controls.Add(this.btnLogout);
            this.pnlAllButton.Controls.Add(this.guna2Button4);
            this.pnlAllButton.Controls.Add(this.btnChucVuvaVaiTro);
            this.pnlAllButton.Controls.Add(this.btnBangLuong);
            this.pnlAllButton.Controls.Add(this.btnTaiKhoan);
            this.pnlAllButton.Controls.Add(this.btnChamCong);
            this.pnlAllButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAllButton.Location = new System.Drawing.Point(0, 0);
            this.pnlAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAllButton.Name = "pnlAllButton";
            this.pnlAllButton.Size = new System.Drawing.Size(270, 685);
            this.pnlAllButton.TabIndex = 1;
            // 
            // btnHopDong
            // 
            this.btnHopDong.BorderRadius = 16;
            this.btnHopDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHopDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHopDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHopDong.FillColor = System.Drawing.Color.White;
            this.btnHopDong.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnHopDong.ForeColor = System.Drawing.Color.Black;
            this.btnHopDong.Image = ((System.Drawing.Image)(resources.GetObject("btnHopDong.Image")));
            this.btnHopDong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHopDong.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHopDong.Location = new System.Drawing.Point(9, 454);
            this.btnHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(250, 62);
            this.btnHopDong.TabIndex = 13;
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHopDong.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnUser
            // 
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnUser.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUser.Location = new System.Drawing.Point(9, 11);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(251, 81);
            this.btnUser.TabIndex = 12;
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 16;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(209)))), ((int)(((byte)(194)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNhanVien.Location = new System.Drawing.Point(9, 142);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(250, 62);
            this.btnNhanVien.TabIndex = 10;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 16;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(35, 35);
            this.btnLogout.Location = new System.Drawing.Point(19, 768);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(225, 62);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(19, 106);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(225, 2);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "guna2Button4";
            // 
            // btnChucVuvaVaiTro
            // 
            this.btnChucVuvaVaiTro.BorderRadius = 16;
            this.btnChucVuvaVaiTro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChucVuvaVaiTro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChucVuvaVaiTro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChucVuvaVaiTro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChucVuvaVaiTro.FillColor = System.Drawing.Color.White;
            this.btnChucVuvaVaiTro.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnChucVuvaVaiTro.ForeColor = System.Drawing.Color.Black;
            this.btnChucVuvaVaiTro.Image = ((System.Drawing.Image)(resources.GetObject("btnChucVuvaVaiTro.Image")));
            this.btnChucVuvaVaiTro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChucVuvaVaiTro.ImageSize = new System.Drawing.Size(35, 35);
            this.btnChucVuvaVaiTro.Location = new System.Drawing.Point(11, 532);
            this.btnChucVuvaVaiTro.Margin = new System.Windows.Forms.Padding(2);
            this.btnChucVuvaVaiTro.Name = "btnChucVuvaVaiTro";
            this.btnChucVuvaVaiTro.Size = new System.Drawing.Size(250, 62);
            this.btnChucVuvaVaiTro.TabIndex = 5;
            this.btnChucVuvaVaiTro.Text = "Chức Vụ/Vai Trò";
            this.btnChucVuvaVaiTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChucVuvaVaiTro.Click += new System.EventHandler(this.btnChucVuvaVaiTro_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BorderRadius = 16;
            this.btnBangLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBangLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBangLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBangLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBangLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBangLuong.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnBangLuong.ForeColor = System.Drawing.Color.Black;
            this.btnBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBangLuong.Image")));
            this.btnBangLuong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBangLuong.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBangLuong.Location = new System.Drawing.Point(9, 376);
            this.btnBangLuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(250, 62);
            this.btnBangLuong.TabIndex = 4;
            this.btnBangLuong.Text = "Bảng lương";
            this.btnBangLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBangLuong.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderRadius = 16;
            this.btnTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTaiKhoan.Location = new System.Drawing.Point(9, 220);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(250, 62);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.BorderRadius = 16;
            this.btnChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamCong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnChamCong.Font = new System.Drawing.Font("Montserrat", 18F);
            this.btnChamCong.ForeColor = System.Drawing.Color.Black;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChamCong.ImageSize = new System.Drawing.Size(35, 35);
            this.btnChamCong.Location = new System.Drawing.Point(9, 298);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(250, 62);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChamCong.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlUserControls
            // 
            this.pnlUserControls.BackColor = System.Drawing.Color.White;
            this.pnlUserControls.Controls.Add(this.ucHistory1);
            this.pnlUserControls.Controls.Add(this.ucHR1);
            this.pnlUserControls.Controls.Add(this.ucSuppliercs1);
            this.pnlUserControls.Controls.Add(this.ucWarehouse1);
            this.pnlUserControls.Controls.Add(this.ucCustomer1);
            this.pnlUserControls.Controls.Add(this.ucOrder1);
            this.pnlUserControls.Controls.Add(this.ucOverview1);
            this.pnlUserControls.Location = new System.Drawing.Point(270, 0);
            this.pnlUserControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserControls.Name = "pnlUserControls";
            this.pnlUserControls.Size = new System.Drawing.Size(1275, 842);
            this.pnlUserControls.TabIndex = 3;
            // 
            // ucHistory1
            // 
            this.ucHistory1.BackColor = System.Drawing.Color.White;
            this.ucHistory1.Location = new System.Drawing.Point(4, 0);
            this.ucHistory1.Margin = new System.Windows.Forms.Padding(2);
            this.ucHistory1.Name = "ucHistory1";
            this.ucHistory1.Size = new System.Drawing.Size(1162, 842);
            this.ucHistory1.TabIndex = 6;
            this.ucHistory1.Load += new System.EventHandler(this.ucHistory1_Load);
            // 
            // ucHR1
            // 
            this.ucHR1.BackColor = System.Drawing.Color.White;
            this.ucHR1.Location = new System.Drawing.Point(0, 0);
            this.ucHR1.Margin = new System.Windows.Forms.Padding(4);
            this.ucHR1.Name = "ucHR1";
            this.ucHR1.Size = new System.Drawing.Size(1164, 842);
            this.ucHR1.TabIndex = 5;
            // 
            // ucSuppliercs1
            // 
            this.ucSuppliercs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucSuppliercs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuppliercs1.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliercs1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSuppliercs1.Name = "ucSuppliercs1";
            this.ucSuppliercs1.Size = new System.Drawing.Size(1275, 842);
            this.ucSuppliercs1.TabIndex = 4;
            // 
            // ucWarehouse1
            // 
            this.ucWarehouse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucWarehouse1.Location = new System.Drawing.Point(0, 0);
            this.ucWarehouse1.Margin = new System.Windows.Forms.Padding(2);
            this.ucWarehouse1.Name = "ucWarehouse1";
            this.ucWarehouse1.Size = new System.Drawing.Size(1164, 842);
            this.ucWarehouse1.TabIndex = 3;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucCustomer1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomer1.Margin = new System.Windows.Forms.Padding(2);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(1164, 842);
            this.ucCustomer1.TabIndex = 2;
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucOrder1.Margin = new System.Windows.Forms.Padding(2);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1164, 842);
            this.ucOrder1.TabIndex = 1;
            // 
            // ucOverview1
            // 
            this.ucOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOverview1.Location = new System.Drawing.Point(0, 0);
            this.ucOverview1.Margin = new System.Windows.Forms.Padding(2);
            this.ucOverview1.Name = "ucOverview1";
            this.ucOverview1.Size = new System.Drawing.Size(1164, 842);
            this.ucOverview1.TabIndex = 0;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1028, 685);
            this.Controls.Add(this.pnlAllButton);
            this.Controls.Add(this.pnlUserControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Furniture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEmployee_Load);
            this.pnlAllButton.ResumeLayout(false);
            this.pnlUserControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Panel pnlAllButton;
        protected Guna.UI2.WinForms.Guna2Button btnChamCong;
        protected Guna.UI2.WinForms.Guna2Button btnChucVuvaVaiTro;
        protected Guna.UI2.WinForms.Guna2Button btnBangLuong;
        protected Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        protected Guna.UI2.WinForms.Guna2Button guna2Button4;
        protected Guna.UI2.WinForms.Guna2Button btnLogout;
        protected Guna.UI2.WinForms.Guna2Panel pnlUserControls;
        protected Guna.UI2.WinForms.Guna2Button btnNhanVien;
        protected ucChucVuVaiTro ucSuppliercs1;
        protected ucBangLuong ucWarehouse1;
        protected Controls.ucChamCong ucCustomer1;
        protected UCPhongBan ucOrder1;
        protected ucTaiKhoan ucOverview1;
        protected Guna.UI2.WinForms.Guna2Button btnUser;
        protected Controls.ucHR ucHR1;
        protected ucHopDong ucHistory1;
        protected Guna.UI2.WinForms.Guna2Button btnHopDong;
    }
}