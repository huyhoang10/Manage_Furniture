namespace Manage_Furniture.Forms
{
    partial class FEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmployee));
            this.pnlAllButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnHR = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnWarehouse = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserControls = new Guna.UI2.WinForms.Guna2Panel();
            this.ucHR1 = new Manage_Furniture.Controls.ucHR();
            this.ucSuppliercs1 = new Manage_Furniture.Forms.ucSuppliercs();
            this.ucWarehouse1 = new Manage_Furniture.Forms.ucWarehouse();
            this.ucCustomer1 = new Manage_Furniture.Controls.UCCustomer();
            this.ucOrder1 = new Manage_Furniture.Forms.UCOrder();
            this.ucOverview1 = new Manage_Furniture.Forms.ucOverview();
            this.pnlAllButton.SuspendLayout();
            this.pnlUserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAllButton
            // 
            this.pnlAllButton.BackColor = System.Drawing.Color.White;
            this.pnlAllButton.Controls.Add(this.btnUser);
            this.pnlAllButton.Controls.Add(this.btnHR);
            this.pnlAllButton.Controls.Add(this.btnHome);
            this.pnlAllButton.Controls.Add(this.btnLogout);
            this.pnlAllButton.Controls.Add(this.guna2Button4);
            this.pnlAllButton.Controls.Add(this.btnSupplier);
            this.pnlAllButton.Controls.Add(this.btnWarehouse);
            this.pnlAllButton.Controls.Add(this.btnOrder);
            this.pnlAllButton.Controls.Add(this.btnCustomer);
            this.pnlAllButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAllButton.Location = new System.Drawing.Point(0, 0);
            this.pnlAllButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAllButton.Name = "pnlAllButton";
            this.pnlAllButton.Size = new System.Drawing.Size(262, 749);
            this.pnlAllButton.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUser.Location = new System.Drawing.Point(9, 10);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(251, 81);
            this.btnUser.TabIndex = 12;
            this.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHR
            // 
            this.btnHR.BorderRadius = 16;
            this.btnHR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHR.FillColor = System.Drawing.Color.White;
            this.btnHR.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHR.ForeColor = System.Drawing.Color.Black;
            this.btnHR.Image = ((System.Drawing.Image)(resources.GetObject("btnHR.Image")));
            this.btnHR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHR.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHR.Location = new System.Drawing.Point(19, 565);
            this.btnHR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(225, 62);
            this.btnHR.TabIndex = 11;
            this.btnHR.Text = "HR";
            this.btnHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 16;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(166)))), ((int)(((byte)(158)))));
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Location = new System.Drawing.Point(19, 142);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 62);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(225, 2);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "guna2Button4";
            // 
            // btnSupplier
            // 
            this.btnSupplier.BorderRadius = 16;
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.Color.White;
            this.btnSupplier.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSupplier.Location = new System.Drawing.Point(19, 480);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(225, 62);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BorderRadius = 16;
            this.btnWarehouse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWarehouse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWarehouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWarehouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWarehouse.FillColor = System.Drawing.Color.White;
            this.btnWarehouse.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.Black;
            this.btnWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnWarehouse.Image")));
            this.btnWarehouse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWarehouse.ImageSize = new System.Drawing.Size(35, 35);
            this.btnWarehouse.Location = new System.Drawing.Point(19, 396);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(225, 62);
            this.btnWarehouse.TabIndex = 4;
            this.btnWarehouse.Text = "Warehouse";
            this.btnWarehouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 16;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOrder.Location = new System.Drawing.Point(19, 227);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(225, 62);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderRadius = 16;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.White;
            this.btnCustomer.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomer.Location = new System.Drawing.Point(19, 311);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(225, 62);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlUserControls
            // 
            this.pnlUserControls.BackColor = System.Drawing.Color.White;
            this.pnlUserControls.Controls.Add(this.ucHR1);
            this.pnlUserControls.Controls.Add(this.ucSuppliercs1);
            this.pnlUserControls.Controls.Add(this.ucWarehouse1);
            this.pnlUserControls.Controls.Add(this.ucCustomer1);
            this.pnlUserControls.Controls.Add(this.ucOrder1);
            this.pnlUserControls.Controls.Add(this.ucOverview1);
            this.pnlUserControls.Location = new System.Drawing.Point(262, 0);
            this.pnlUserControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUserControls.Name = "pnlUserControls";
            this.pnlUserControls.Size = new System.Drawing.Size(1275, 842);
            this.pnlUserControls.TabIndex = 3;
            // 
            // ucHR1
            // 
            this.ucHR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucHR1.Location = new System.Drawing.Point(0, 0);
            this.ucHR1.Name = "ucHR1";
            this.ucHR1.Size = new System.Drawing.Size(1164, 842);
            this.ucHR1.TabIndex = 5;
            // 
            // ucSuppliercs1
            // 
            this.ucSuppliercs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucSuppliercs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuppliercs1.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliercs1.Name = "ucSuppliercs1";
            this.ucSuppliercs1.Size = new System.Drawing.Size(1275, 842);
            this.ucSuppliercs1.TabIndex = 4;
            // 
            // ucWarehouse1
            // 
            this.ucWarehouse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucWarehouse1.Location = new System.Drawing.Point(0, 0);
            this.ucWarehouse1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucWarehouse1.Name = "ucWarehouse1";
            this.ucWarehouse1.Size = new System.Drawing.Size(1164, 842);
            this.ucWarehouse1.TabIndex = 3;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucCustomer1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(1164, 842);
            this.ucCustomer1.TabIndex = 2;
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucOrder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1164, 842);
            this.ucOrder1.TabIndex = 1;
            // 
            // ucOverview1
            // 
            this.ucOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOverview1.Location = new System.Drawing.Point(0, 0);
            this.ucOverview1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucOverview1.Name = "ucOverview1";
            this.ucOverview1.Size = new System.Drawing.Size(1164, 842);
            this.ucOverview1.TabIndex = 0;
            // 
            // FEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1218, 749);
            this.Controls.Add(this.pnlAllButton);
            this.Controls.Add(this.pnlUserControls);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FEmployee";
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
        protected Guna.UI2.WinForms.Guna2Button btnCustomer;
        protected Guna.UI2.WinForms.Guna2Button btnSupplier;
        protected Guna.UI2.WinForms.Guna2Button btnWarehouse;
        protected Guna.UI2.WinForms.Guna2Button btnOrder;
        protected Guna.UI2.WinForms.Guna2Button guna2Button4;
        protected Guna.UI2.WinForms.Guna2Button btnLogout;
        protected Guna.UI2.WinForms.Guna2Panel pnlUserControls;
        protected Guna.UI2.WinForms.Guna2Button btnHR;
        protected Guna.UI2.WinForms.Guna2Button btnHome;
        private ucSuppliercs ucSuppliercs1;
        private ucWarehouse ucWarehouse1;
        private Controls.UCCustomer ucCustomer1;
        private UCOrder ucOrder1;
        private ucOverview ucOverview1;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Controls.ucHR ucHR1;
    }
}