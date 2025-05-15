namespace Manage_Furniture.Forms
{
    partial class UCOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Order = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.btn_order = new Guna.UI2.WinForms.Guna2Button();
            this.btn_export = new Guna.UI2.WinForms.Guna2Button();
            this.txt_customer_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customer_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_custormer_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cmb_customer_sex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_order_note = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_customer_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv_orders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txt_sum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_search_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_Report = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.manageFurnitureDataSet = new Manage_Furniture.ManageFurnitureDataSet();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageFurnitureDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Montserrat", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(9, 30);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(725, 92);
            this.Order.TabIndex = 0;
            this.Order.Text = "Order Management";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // btn_reset
            // 
            this.btn_reset.BorderRadius = 16;
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_reset.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(1148, 879);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(175, 64);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_order
            // 
            this.btn_order.BorderRadius = 16;
            this.btn_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_order.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.Black;
            this.btn_order.Location = new System.Drawing.Point(948, 879);
            this.btn_order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(175, 64);
            this.btn_order.TabIndex = 7;
            this.btn_order.Text = "Order";
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_export
            // 
            this.btn_export.BorderRadius = 16;
            this.btn_export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_export.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.Black;
            this.btn_export.Location = new System.Drawing.Point(1348, 879);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(175, 64);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "Export";
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.BackColor = System.Drawing.Color.White;
            this.txt_customer_name.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_name.BorderRadius = 16;
            this.txt_customer_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_name.DefaultText = "";
            this.txt_customer_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_name.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_name.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_name.Location = new System.Drawing.Point(36, 116);
            this.txt_customer_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_name.PlaceholderText = "Name Customer*";
            this.txt_customer_name.SelectedText = "";
            this.txt_customer_name.Size = new System.Drawing.Size(511, 71);
            this.txt_customer_name.TabIndex = 3;
            this.txt_customer_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_customer_name_KeyPress);
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.BackColor = System.Drawing.Color.White;
            this.txt_customer_phone.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_phone.BorderRadius = 16;
            this.txt_customer_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_phone.DefaultText = "";
            this.txt_customer_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_phone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_phone.Location = new System.Drawing.Point(36, 25);
            this.txt_customer_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_phone.PlaceholderText = "Phone*";
            this.txt_customer_phone.SelectedText = "";
            this.txt_customer_phone.Size = new System.Drawing.Size(333, 71);
            this.txt_customer_phone.TabIndex = 1;
            // 
            // txt_custormer_address
            // 
            this.txt_custormer_address.BackColor = System.Drawing.Color.White;
            this.txt_custormer_address.BorderColor = System.Drawing.Color.Maroon;
            this.txt_custormer_address.BorderRadius = 16;
            this.txt_custormer_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_custormer_address.DefaultText = "";
            this.txt_custormer_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_custormer_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_custormer_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_custormer_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_custormer_address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_custormer_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_custormer_address.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_custormer_address.ForeColor = System.Drawing.Color.Black;
            this.txt_custormer_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_custormer_address.Location = new System.Drawing.Point(36, 207);
            this.txt_custormer_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_custormer_address.Name = "txt_custormer_address";
            this.txt_custormer_address.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_custormer_address.PlaceholderText = "Address";
            this.txt_custormer_address.SelectedText = "";
            this.txt_custormer_address.Size = new System.Drawing.Size(511, 71);
            this.txt_custormer_address.TabIndex = 4;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 16;
            this.guna2CustomGradientPanel1.Controls.Add(this.cmb_customer_sex);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_order_note);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_custormer_address);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_phone);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_name);
            this.guna2CustomGradientPanel1.Controls.Add(this.cmb_customer_type);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(948, 258);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(575, 583);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // cmb_customer_sex
            // 
            this.cmb_customer_sex.AutoCompleteCustomSource.AddRange(new string[] {
            "Sex"});
            this.cmb_customer_sex.BackColor = System.Drawing.Color.Transparent;
            this.cmb_customer_sex.BorderColor = System.Drawing.Color.Maroon;
            this.cmb_customer_sex.BorderRadius = 16;
            this.cmb_customer_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_customer_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer_sex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.cmb_customer_sex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer_sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer_sex.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer_sex.ForeColor = System.Drawing.Color.Black;
            this.cmb_customer_sex.ItemHeight = 50;
            this.cmb_customer_sex.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmb_customer_sex.Location = new System.Drawing.Point(389, 25);
            this.cmb_customer_sex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_customer_sex.Name = "cmb_customer_sex";
            this.cmb_customer_sex.Size = new System.Drawing.Size(157, 56);
            this.cmb_customer_sex.StartIndex = 0;
            this.cmb_customer_sex.TabIndex = 2;
            this.cmb_customer_sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_order_note
            // 
            this.txt_order_note.BackColor = System.Drawing.Color.White;
            this.txt_order_note.BorderColor = System.Drawing.Color.Maroon;
            this.txt_order_note.BorderRadius = 16;
            this.txt_order_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_order_note.DefaultText = "";
            this.txt_order_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_order_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_order_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_order_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_order_note.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_order_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_order_note.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_note.ForeColor = System.Drawing.Color.Black;
            this.txt_order_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_order_note.Location = new System.Drawing.Point(36, 393);
            this.txt_order_note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_order_note.Multiline = true;
            this.txt_order_note.Name = "txt_order_note";
            this.txt_order_note.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txt_order_note.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_order_note.PlaceholderText = "Note Orders";
            this.txt_order_note.SelectedText = "";
            this.txt_order_note.Size = new System.Drawing.Size(511, 162);
            this.txt_order_note.TabIndex = 6;
            // 
            // cmb_customer_type
            // 
            this.cmb_customer_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Regular",
            "Loyal",
            "VIP"});
            this.cmb_customer_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_customer_type.BorderColor = System.Drawing.Color.Maroon;
            this.cmb_customer_type.BorderRadius = 16;
            this.cmb_customer_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_customer_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.cmb_customer_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer_type.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer_type.ForeColor = System.Drawing.Color.Black;
            this.cmb_customer_type.ItemHeight = 50;
            this.cmb_customer_type.Items.AddRange(new object[] {
            "Regular",
            "Loyal",
            "VIP"});
            this.cmb_customer_type.Location = new System.Drawing.Point(36, 298);
            this.cmb_customer_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_customer_type.Name = "cmb_customer_type";
            this.cmb_customer_type.Size = new System.Drawing.Size(511, 56);
            this.cmb_customer_type.StartIndex = 0;
            this.cmb_customer_type.TabIndex = 5;
            this.cmb_customer_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_orders
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(19)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_orders.ColumnHeadersHeight = 50;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_product,
            this.col_quantity,
            this.col_date_purchase,
            this.col_money,
            this.col_total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orders.Location = new System.Drawing.Point(11, 25);
            this.dgv_orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_orders.Name = "dgv_orders";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(19)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_orders.RowHeadersVisible = false;
            this.dgv_orders.RowHeadersWidth = 51;
            this.dgv_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_orders.RowTemplate.Height = 24;
            this.dgv_orders.Size = new System.Drawing.Size(875, 558);
            this.dgv_orders.TabIndex = 1;
            this.dgv_orders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_orders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_orders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_orders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_orders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_orders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_orders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_orders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_orders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_orders.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_orders.ThemeStyle.ReadOnly = false;
            this.dgv_orders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_orders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_orders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_orders.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_orders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_orders.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellValueChanged);
            this.dgv_orders.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_RowLeave);
            // 
            // col_id
            // 
            this.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_id.FillWeight = 47.03881F;
            this.col_id.HeaderText = "No";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_product
            // 
            this.col_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product.DataPropertyName = "id";
            this.col_product.FillWeight = 168.0779F;
            this.col_product.HeaderText = "Product";
            this.col_product.MinimumWidth = 6;
            this.col_product.Name = "col_product";
            this.col_product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_quantity
            // 
            this.col_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_quantity.DataPropertyName = "quantity";
            this.col_quantity.FillWeight = 95.68577F;
            this.col_quantity.HeaderText = "Quantity";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            // 
            // col_date_purchase
            // 
            this.col_date_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_date_purchase.DataPropertyName = "date_purchase";
            this.col_date_purchase.FillWeight = 95.68577F;
            this.col_date_purchase.HeaderText = "Date Purchase";
            this.col_date_purchase.MinimumWidth = 6;
            this.col_date_purchase.Name = "col_date_purchase";
            this.col_date_purchase.ReadOnly = true;
            // 
            // col_money
            // 
            this.col_money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_money.DataPropertyName = "money";
            this.col_money.FillWeight = 95.68577F;
            this.col_money.HeaderText = "Money";
            this.col_money.MinimumWidth = 6;
            this.col_money.Name = "col_money";
            this.col_money.ReadOnly = true;
            // 
            // col_total
            // 
            this.col_total.FillWeight = 84.24312F;
            this.col_total.HeaderText = "Total";
            this.col_total.MinimumWidth = 6;
            this.col_total.Name = "col_total";
            this.col_total.ReadOnly = true;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 16;
            this.guna2CustomGradientPanel2.Controls.Add(this.txt_sum);
            this.guna2CustomGradientPanel2.Controls.Add(this.dgv_orders);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(25, 258);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(899, 708);
            this.guna2CustomGradientPanel2.TabIndex = 8;
            // 
            // txt_sum
            // 
            this.txt_sum.BackColor = System.Drawing.Color.White;
            this.txt_sum.BorderColor = System.Drawing.Color.Maroon;
            this.txt_sum.BorderRadius = 15;
            this.txt_sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sum.DefaultText = "";
            this.txt_sum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sum.Enabled = false;
            this.txt_sum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_sum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sum.ForeColor = System.Drawing.Color.Black;
            this.txt_sum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sum.Location = new System.Drawing.Point(628, 622);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_sum.PlaceholderText = "Total = 0";
            this.txt_sum.SelectedText = "";
            this.txt_sum.Size = new System.Drawing.Size(256, 64);
            this.txt_sum.TabIndex = 5;
            // 
            // txt_search_phone
            // 
            this.txt_search_phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.txt_search_phone.BorderRadius = 16;
            this.txt_search_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_phone.DefaultText = "";
            this.txt_search_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_phone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Italic);
            this.txt_search_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_search_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_phone.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_search_phone.IconRightSize = new System.Drawing.Size(25, 25);
            this.txt_search_phone.Location = new System.Drawing.Point(1095, 160);
            this.txt_search_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search_phone.Name = "txt_search_phone";
            this.txt_search_phone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search_phone.PlaceholderText = "Phone Customer";
            this.txt_search_phone.SelectedText = "";
            this.txt_search_phone.Size = new System.Drawing.Size(428, 69);
            this.txt_search_phone.TabIndex = 10;
            this.txt_search_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_phone_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.White;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btn_search.Image = global::Manage_Furniture.Properties.Resources.search_1;
            this.btn_search.Location = new System.Drawing.Point(1464, 171);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_search.Size = new System.Drawing.Size(51, 46);
            this.btn_search.TabIndex = 10;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BorderRadius = 5;
            this.btn_Report.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Report.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Report.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Report.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(29, 208);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(115, 33);
            this.btn_Report.TabIndex = 11;
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
            this.btn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.Location = new System.Drawing.Point(163, 208);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(115, 33);
            this.btn_Excel.TabIndex = 12;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // manageFurnitureDataSet
            // 
            this.manageFurnitureDataSet.DataSetName = "ManageFurnitureDataSet";
            this.manageFurnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search_phone);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(1552, 1036);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manageFurnitureDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Order;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Button btn_order;
        private Guna.UI2.WinForms.Guna2Button btn_export;
        private ManageFurnitureDataSet manageFurnitureDataSet;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_custormer_address;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_orders;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_phone;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_order_note;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_customer_type;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_customer_sex;
        private Guna.UI2.WinForms.Guna2TextBox txt_sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private Guna.UI2.WinForms.Guna2Button btn_Report;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
    }
}
