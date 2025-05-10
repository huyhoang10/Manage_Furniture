namespace Manage_Furniture.Controls
{
    partial class UCCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_Customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_FillterType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_Sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_Report = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Management";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderRadius = 24;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_Update.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(1156, 708);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.BorderRadius = 24;
            this.btn_Update.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Update.ShadowDecoration.Enabled = true;
            this.btn_Update.Size = new System.Drawing.Size(183, 67);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderColor = System.Drawing.Color.Maroon;
            this.txt_Name.BorderRadius = 16;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.DefaultText = "";
            this.txt_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.txt_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name.Location = new System.Drawing.Point(22, 25);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Name.PlaceholderText = "Name Customer";
            this.txt_Name.SelectedText = "";
            this.txt_Name.Size = new System.Drawing.Size(367, 69);
            this.txt_Name.TabIndex = 9;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.White;
            this.txt_Phone.BorderColor = System.Drawing.Color.Maroon;
            this.txt_Phone.BorderRadius = 16;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.Location = new System.Drawing.Point(22, 125);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Phone.PlaceholderText = "Phone";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.Size = new System.Drawing.Size(367, 69);
            this.txt_Phone.TabIndex = 11;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.BorderColor = System.Drawing.Color.Maroon;
            this.txt_ID.BorderRadius = 16;
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.DefaultText = "";
            this.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.Location = new System.Drawing.Point(407, 25);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_ID.PlaceholderText = "ID";
            this.txt_ID.SelectedText = "";
            this.txt_ID.Size = new System.Drawing.Size(144, 69);
            this.txt_ID.TabIndex = 12;
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.txt_Address.BorderRadius = 16;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.Location = new System.Drawing.Point(22, 225);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Address.PlaceholderText = "Address";
            this.txt_Address.SelectedText = "";
            this.txt_Address.Size = new System.Drawing.Size(525, 69);
            this.txt_Address.TabIndex = 14;
            // 
            // dgv_Customer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customer.ColumnHeadersHeight = 50;
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_name,
            this.col_phone,
            this.col_sex,
            this.col_address,
            this.col_type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_Customer.Location = new System.Drawing.Point(15, 25);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.ReadOnly = true;
            this.dgv_Customer.RowHeadersVisible = false;
            this.dgv_Customer.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_Customer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Customer.RowTemplate.Height = 30;
            this.dgv_Customer.Size = new System.Drawing.Size(869, 661);
            this.dgv_Customer.TabIndex = 16;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Customer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Customer.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Customer.ThemeStyle.ReadOnly = true;
            this.dgv_Customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "id";
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "name";
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_phone
            // 
            this.col_phone.DataPropertyName = "phone";
            this.col_phone.HeaderText = "Phone";
            this.col_phone.MinimumWidth = 6;
            this.col_phone.Name = "col_phone";
            this.col_phone.ReadOnly = true;
            // 
            // col_sex
            // 
            this.col_sex.DataPropertyName = "sex";
            this.col_sex.HeaderText = "Sex";
            this.col_sex.MinimumWidth = 6;
            this.col_sex.Name = "col_sex";
            this.col_sex.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "address";
            this.col_address.HeaderText = "Address";
            this.col_address.MinimumWidth = 6;
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_type
            // 
            this.col_type.DataPropertyName = "type";
            this.col_type.HeaderText = "Type";
            this.col_type.MinimumWidth = 6;
            this.col_type.Name = "col_type";
            this.col_type.ReadOnly = true;
            // 
            // cmb_FillterType
            // 
            this.cmb_FillterType.BackColor = System.Drawing.Color.Transparent;
            this.cmb_FillterType.BorderColor = System.Drawing.Color.Maroon;
            this.cmb_FillterType.BorderRadius = 16;
            this.cmb_FillterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_FillterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FillterType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_FillterType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_FillterType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_FillterType.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cmb_FillterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_FillterType.ItemHeight = 50;
            this.cmb_FillterType.Items.AddRange(new object[] {
            "All",
            "Regular",
            "Loyal",
            "VIP"});
            this.cmb_FillterType.Location = new System.Drawing.Point(775, 160);
            this.cmb_FillterType.Name = "cmb_FillterType";
            this.cmb_FillterType.Size = new System.Drawing.Size(149, 56);
            this.cmb_FillterType.TabIndex = 18;
            this.cmb_FillterType.SelectedIndexChanged += new System.EventHandler(this.cmb_FillterType_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(712, 176);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 29);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Type";
            // 
            // txt_Search
            // 
            this.txt_Search.BorderColor = System.Drawing.Color.Maroon;
            this.txt_Search.BorderRadius = 20;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_Search.IconRightSize = new System.Drawing.Size(24, 24);
            this.txt_Search.Location = new System.Drawing.Point(1097, 160);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Search.PlaceholderText = "Search Phone";
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(428, 69);
            this.txt_Search.TabIndex = 8;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cmb_Type
            // 
            this.cmb_Type.BackColor = System.Drawing.Color.White;
            this.cmb_Type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.cmb_Type.BorderRadius = 16;
            this.cmb_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.cmb_Type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Type.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Type.ItemHeight = 50;
            this.cmb_Type.Items.AddRange(new object[] {
            "Regular",
            "Loyal",
            "VIP"});
            this.cmb_Type.Location = new System.Drawing.Point(22, 325);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(525, 56);
            this.cmb_Type.TabIndex = 20;
            // 
            // cmb_Sex
            // 
            this.cmb_Sex.BackColor = System.Drawing.Color.White;
            this.cmb_Sex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.cmb_Sex.BorderRadius = 16;
            this.cmb_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            this.cmb_Sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Sex.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Sex.ItemHeight = 50;
            this.cmb_Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Sex.Location = new System.Drawing.Point(407, 125);
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(140, 56);
            this.cmb_Sex.TabIndex = 22;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 16;
            this.guna2CustomGradientPanel1.Controls.Add(this.cmb_Sex);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_Name);
            this.guna2CustomGradientPanel1.Controls.Add(this.cmb_Type);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_Phone);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_Address);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_ID);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(950, 258);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(575, 429);
            this.guna2CustomGradientPanel1.TabIndex = 24;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 16;
            this.guna2CustomGradientPanel2.Controls.Add(this.dgv_Customer);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(25, 258);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(899, 708);
            this.guna2CustomGradientPanel2.TabIndex = 23;
            // 
            // btn_Report
            // 
            this.btn_Report.BorderRadius = 5;
            this.btn_Report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Report.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(40, 210);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(114, 33);
            this.btn_Report.TabIndex = 25;
            this.btn_Report.Text = "Report";
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.BorderRadius = 5;
            this.btn_Excel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Excel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Excel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Excel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Excel.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_Excel.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.Location = new System.Drawing.Point(160, 210);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(114, 33);
            this.btn_Excel.TabIndex = 26;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmb_FillterType);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(1552, 1036);
            this.Load += new System.EventHandler(this.UCCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_FillterType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Type;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Sex;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_Report;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
    }
}
