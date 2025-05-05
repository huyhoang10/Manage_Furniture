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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Order = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.btn_history = new Guna.UI2.WinForms.Guna2Button();
            this.btn_order = new Guna.UI2.WinForms.Guna2Button();
            this.btn_export = new Guna.UI2.WinForms.Guna2Button();
            this.manageFurnitureDataSet = new Manage_Furniture.ManageFurnitureDataSet();
            this.txt_customer_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customer_sex = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customer_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_custormer_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customer_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgv_orders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txt_customer_note = new Guna.UI2.WinForms.Guna2TextBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_purchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.manageFurnitureDataSet)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Montserrat ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(13, 0);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(665, 83);
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
            // btn_history
            // 
            this.btn_history.BorderRadius = 30;
            this.btn_history.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_history.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_history.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_history.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_history.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_history.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.Color.Black;
            this.btn_history.Location = new System.Drawing.Point(23, 949);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(175, 64);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "History";
            // 
            // btn_order
            // 
            this.btn_order.BorderRadius = 30;
            this.btn_order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_order.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.Black;
            this.btn_order.Location = new System.Drawing.Point(1034, 949);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(175, 64);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Order";
            // 
            // btn_export
            // 
            this.btn_export.BorderRadius = 30;
            this.btn_export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(223)))), ((int)(((byte)(172)))));
            this.btn_export.Font = new System.Drawing.Font("Montserrat Medium", 15F, System.Drawing.FontStyle.Bold);
            this.btn_export.ForeColor = System.Drawing.Color.Black;
            this.btn_export.Location = new System.Drawing.Point(1283, 949);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(175, 64);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "Export";
            // 
            // manageFurnitureDataSet
            // 
            this.manageFurnitureDataSet.DataSetName = "ManageFurnitureDataSet";
            this.manageFurnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.BackColor = System.Drawing.Color.White;
            this.txt_customer_name.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_name.BorderRadius = 25;
            this.txt_customer_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_name.DefaultText = "";
            this.txt_customer_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_name.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_customer_name.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_name.Location = new System.Drawing.Point(36, 25);
            this.txt_customer_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_name.PlaceholderText = "Name Customer";
            this.txt_customer_name.SelectedText = "";
            this.txt_customer_name.Size = new System.Drawing.Size(334, 72);
            this.txt_customer_name.TabIndex = 2;
            // 
            // txt_customer_sex
            // 
            this.txt_customer_sex.BackColor = System.Drawing.Color.White;
            this.txt_customer_sex.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_sex.BorderRadius = 25;
            this.txt_customer_sex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_sex.DefaultText = "";
            this.txt_customer_sex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_sex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_sex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_sex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_sex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_sex.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_customer_sex.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_sex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_sex.Location = new System.Drawing.Point(397, 25);
            this.txt_customer_sex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_sex.Name = "txt_customer_sex";
            this.txt_customer_sex.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_sex.PlaceholderText = "Sex";
            this.txt_customer_sex.SelectedText = "";
            this.txt_customer_sex.Size = new System.Drawing.Size(150, 72);
            this.txt_customer_sex.TabIndex = 2;
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.BackColor = System.Drawing.Color.White;
            this.txt_customer_phone.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_phone.BorderRadius = 25;
            this.txt_customer_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_phone.DefaultText = "";
            this.txt_customer_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_phone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_phone.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_customer_phone.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_phone.Location = new System.Drawing.Point(36, 141);
            this.txt_customer_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_phone.PlaceholderText = "Phone";
            this.txt_customer_phone.SelectedText = "";
            this.txt_customer_phone.Size = new System.Drawing.Size(511, 72);
            this.txt_customer_phone.TabIndex = 2;
            // 
            // txt_custormer_address
            // 
            this.txt_custormer_address.BackColor = System.Drawing.Color.White;
            this.txt_custormer_address.BorderColor = System.Drawing.Color.Maroon;
            this.txt_custormer_address.BorderRadius = 25;
            this.txt_custormer_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_custormer_address.DefaultText = "";
            this.txt_custormer_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_custormer_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_custormer_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_custormer_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_custormer_address.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_custormer_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_custormer_address.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_custormer_address.ForeColor = System.Drawing.Color.Black;
            this.txt_custormer_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_custormer_address.Location = new System.Drawing.Point(36, 263);
            this.txt_custormer_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_custormer_address.Name = "txt_custormer_address";
            this.txt_custormer_address.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_custormer_address.PlaceholderText = "Address";
            this.txt_custormer_address.SelectedText = "";
            this.txt_custormer_address.Size = new System.Drawing.Size(511, 72);
            this.txt_custormer_address.TabIndex = 2;
            // 
            // txt_customer_type
            // 
            this.txt_customer_type.BackColor = System.Drawing.Color.White;
            this.txt_customer_type.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_type.BorderRadius = 25;
            this.txt_customer_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_type.DefaultText = "";
            this.txt_customer_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_type.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_customer_type.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_type.Location = new System.Drawing.Point(36, 385);
            this.txt_customer_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_type.Name = "txt_customer_type";
            this.txt_customer_type.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_type.PlaceholderText = "Type";
            this.txt_customer_type.SelectedText = "";
            this.txt_customer_type.Size = new System.Drawing.Size(511, 72);
            this.txt_customer_type.TabIndex = 2;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 16;
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_note);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_type);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_custormer_address);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_phone);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_sex);
            this.guna2CustomGradientPanel1.Controls.Add(this.txt_customer_name);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(948, 193);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(575, 740);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // dgv_orders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(19)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orders.ColumnHeadersHeight = 50;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_product,
            this.col_quantity,
            this.col_date_purchase,
            this.col_money});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_orders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orders.Location = new System.Drawing.Point(10, 25);
            this.dgv_orders.Name = "dgv_orders";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(19)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_orders.RowHeadersVisible = false;
            this.dgv_orders.RowHeadersWidth = 51;
            this.dgv_orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_orders.RowTemplate.Height = 24;
            this.dgv_orders.Size = new System.Drawing.Size(874, 692);
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
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 16;
            this.guna2CustomGradientPanel2.Controls.Add(this.dgv_orders);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(23, 193);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(899, 740);
            this.guna2CustomGradientPanel2.TabIndex = 8;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Italic);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRightOffset = new System.Drawing.Point(5, 0);
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox1.Location = new System.Drawing.Point(1135, 69);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.PlaceholderText = "ID or Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(388, 70);
            this.guna2TextBox1.TabIndex = 9;
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
            this.btn_search.Location = new System.Drawing.Point(1461, 83);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_search.Size = new System.Drawing.Size(50, 45);
            this.btn_search.TabIndex = 10;
            // 
            // txt_customer_note
            // 
            this.txt_customer_note.BackColor = System.Drawing.Color.White;
            this.txt_customer_note.BorderColor = System.Drawing.Color.Maroon;
            this.txt_customer_note.BorderRadius = 40;
            this.txt_customer_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customer_note.DefaultText = "";
            this.txt_customer_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customer_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customer_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customer_note.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(227)))));
            this.txt_customer_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_note.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_customer_note.ForeColor = System.Drawing.Color.Black;
            this.txt_customer_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customer_note.Location = new System.Drawing.Point(36, 503);
            this.txt_customer_note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_customer_note.Name = "txt_customer_note";
            this.txt_customer_note.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_customer_note.PlaceholderText = "Note Orders";
            this.txt_customer_note.SelectedText = "";
            this.txt_customer_note.Size = new System.Drawing.Size(511, 214);
            this.txt_customer_note.TabIndex = 2;
            // 
            // col_id
            // 
            this.col_id.FillWeight = 32.08556F;
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            // 
            // col_product
            // 
            this.col_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_product.DataPropertyName = "id";
            this.col_product.FillWeight = 113.5829F;
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
            this.col_quantity.FillWeight = 113.5829F;
            this.col_quantity.HeaderText = "Quantity";
            this.col_quantity.MinimumWidth = 6;
            this.col_quantity.Name = "col_quantity";
            // 
            // col_date_purchase
            // 
            this.col_date_purchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_date_purchase.DataPropertyName = "date_purchase";
            this.col_date_purchase.FillWeight = 113.5829F;
            this.col_date_purchase.HeaderText = "Date Purchase";
            this.col_date_purchase.MinimumWidth = 6;
            this.col_date_purchase.Name = "col_date_purchase";
            // 
            // col_money
            // 
            this.col_money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_money.DataPropertyName = "money";
            this.col_money.FillWeight = 113.5829F;
            this.col_money.HeaderText = "Money";
            this.col_money.MinimumWidth = 6;
            this.col_money.Name = "col_money";
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(1552, 1036);
            ((System.ComponentModel.ISupportInitialize)(this.manageFurnitureDataSet)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Order;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2Button btn_history;
        private Guna.UI2.WinForms.Guna2Button btn_order;
        private Guna.UI2.WinForms.Guna2Button btn_export;
        private ManageFurnitureDataSet manageFurnitureDataSet;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_sex;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_custormer_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_type;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_orders;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_customer_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_money;
    }
}
