namespace Manage_Furniture.Controls
{
    partial class ucChamCong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSuaThongtin = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvBangNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateNgayChamCong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbCaLam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnApDung = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuaThongtin
            // 
            this.btnSuaThongtin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaThongtin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaThongtin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaThongtin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaThongtin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaThongtin.ForeColor = System.Drawing.Color.White;
            this.btnSuaThongtin.Location = new System.Drawing.Point(879, 644);
            this.btnSuaThongtin.Name = "btnSuaThongtin";
            this.btnSuaThongtin.Size = new System.Drawing.Size(211, 45);
            this.btnSuaThongtin.TabIndex = 60;
            this.btnSuaThongtin.Text = "Sửa thông tin";
            this.btnSuaThongtin.Click += new System.EventHandler(this.btnSuaThongtin_Click_1);
            // 
            // btnThemChamCong
            // 
            this.btnThemChamCong.BorderRadius = 2;
            this.btnThemChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemChamCong.ForeColor = System.Drawing.Color.White;
            this.btnThemChamCong.Location = new System.Drawing.Point(261, 98);
            this.btnThemChamCong.Name = "btnThemChamCong";
            this.btnThemChamCong.Size = new System.Drawing.Size(246, 40);
            this.btnThemChamCong.TabIndex = 51;
            this.btnThemChamCong.Text = "Thêm chấm công thủ công";
            this.btnThemChamCong.Click += new System.EventHandler(this.btnThemChamCong_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(485, 35);
            this.guna2HtmlLabel1.TabIndex = 50;
            this.guna2HtmlLabel1.Text = "QUẢN LÝ CHẤM CÔNG NHÂN VIÊN";
            // 
            // dgvBangNhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBangNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangNhanVien.ColumnHeadersHeight = 4;
            this.dgvBangNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBangNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangNhanVien.Location = new System.Drawing.Point(17, 222);
            this.dgvBangNhanVien.Name = "dgvBangNhanVien";
            this.dgvBangNhanVien.RowHeadersVisible = false;
            this.dgvBangNhanVien.Size = new System.Drawing.Size(1073, 392);
            this.dgvBangNhanVien.TabIndex = 49;
            this.dgvBangNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBangNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBangNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBangNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBangNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangNhanVien.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBangNhanVien.ThemeStyle.ReadOnly = false;
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangNhanVien_CellClick);
            // 
            // dateNgayChamCong
            // 
            this.dateNgayChamCong.Checked = true;
            this.dateNgayChamCong.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateNgayChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateNgayChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayChamCong.Location = new System.Drawing.Point(17, 102);
            this.dateNgayChamCong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateNgayChamCong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateNgayChamCong.Name = "dateNgayChamCong";
            this.dateNgayChamCong.Size = new System.Drawing.Size(220, 36);
            this.dateNgayChamCong.TabIndex = 62;
            this.dateNgayChamCong.Value = new System.DateTime(2025, 9, 13, 14, 49, 5, 373);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanVien.DefaultText = "";
            this.txtNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanVien.Location = new System.Drawing.Point(17, 180);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.PlaceholderText = "";
            this.txtNhanVien.SelectedText = "";
            this.txtNhanVien.Size = new System.Drawing.Size(490, 36);
            this.txtNhanVien.TabIndex = 63;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(17, 159);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(118, 18);
            this.guna2HtmlLabel2.TabIndex = 64;
            this.guna2HtmlLabel2.Text = "Tìm kiếm nhân viên";
            // 
            // cmbCaLam
            // 
            this.cmbCaLam.BackColor = System.Drawing.Color.Transparent;
            this.cmbCaLam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCaLam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaLam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCaLam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCaLam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCaLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCaLam.ItemHeight = 30;
            this.cmbCaLam.Location = new System.Drawing.Point(574, 180);
            this.cmbCaLam.Name = "cmbCaLam";
            this.cmbCaLam.Size = new System.Drawing.Size(140, 36);
            this.cmbCaLam.TabIndex = 65;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(574, 159);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(45, 18);
            this.guna2HtmlLabel3.TabIndex = 66;
            this.guna2HtmlLabel3.Text = "Ca làm";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cmbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTrangThai.ItemHeight = 30;
            this.cmbTrangThai.Location = new System.Drawing.Point(732, 180);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(140, 36);
            this.cmbTrangThai.TabIndex = 67;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(732, 156);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(63, 18);
            this.guna2HtmlLabel4.TabIndex = 68;
            this.guna2HtmlLabel4.Text = "Trạng thái";
            // 
            // btnApDung
            // 
            this.btnApDung.BorderRadius = 2;
            this.btnApDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApDung.ForeColor = System.Drawing.Color.White;
            this.btnApDung.Location = new System.Drawing.Point(888, 180);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(202, 36);
            this.btnApDung.TabIndex = 69;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click_1);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(17, 78);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(59, 18);
            this.guna2HtmlLabel5.TabIndex = 70;
            this.guna2HtmlLabel5.Text = "Thời gian";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(634, 644);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(211, 45);
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "Xoá thông tin";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(769, 57);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 45);
            this.btnLamMoi.TabIndex = 72;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // ucChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnApDung);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmbCaLam);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.dateNgayChamCong);
            this.Controls.Add(this.btnSuaThongtin);
            this.Controls.Add(this.btnThemChamCong);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvBangNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucChamCong";
            this.Size = new System.Drawing.Size(1164, 842);
            this.Load += new System.EventHandler(this.ucChamCong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSuaThongtin;
        private Guna.UI2.WinForms.Guna2Button btnThemChamCong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBangNhanVien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateNgayChamCong;
        private Guna.UI2.WinForms.Guna2TextBox txtNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCaLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnApDung;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}
