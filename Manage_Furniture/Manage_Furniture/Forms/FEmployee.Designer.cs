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
            this.btnHR = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnWarehouse = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserControls = new Guna.UI2.WinForms.Guna2Panel();
            this.ucHR1 = new Manage_Furniture.Controls.ucHR();
            this.ucWarehouse1 = new Manage_Furniture.Forms.ucWarehouse();
            this.ucSuppliercs1 = new Manage_Furniture.Forms.ucSuppliercs();
            this.ucOverview1 = new Manage_Furniture.Forms.ucOverview();
            this.pnlAllButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlUserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAllButton
            // 
            this.pnlAllButton.BackColor = System.Drawing.Color.White;
            this.pnlAllButton.Controls.Add(this.btnHR);
            this.pnlAllButton.Controls.Add(this.btnHome);
            this.pnlAllButton.Controls.Add(this.btnLogout);
            this.pnlAllButton.Controls.Add(this.label1);
            this.pnlAllButton.Controls.Add(this.picLogo);
            this.pnlAllButton.Controls.Add(this.guna2Button4);
            this.pnlAllButton.Controls.Add(this.btnSupplier);
            this.pnlAllButton.Controls.Add(this.btnWarehouse);
            this.pnlAllButton.Controls.Add(this.btnOrder);
            this.pnlAllButton.Controls.Add(this.btnCustomer);
            this.pnlAllButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAllButton.Location = new System.Drawing.Point(0, 0);
            this.pnlAllButton.Name = "pnlAllButton";
            this.pnlAllButton.Size = new System.Drawing.Size(350, 1033);
            this.pnlAllButton.TabIndex = 1;
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
            this.btnHR.Location = new System.Drawing.Point(25, 695);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(300, 76);
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
            this.btnHome.Location = new System.Drawing.Point(25, 175);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 76);
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
            this.btnLogout.Location = new System.Drawing.Point(25, 945);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 76);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "HQ3T";
            // 
            // picLogo
            // 
            this.picLogo.FillColor = System.Drawing.Color.Black;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(19, 19);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLogo.Size = new System.Drawing.Size(90, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
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
            this.guna2Button4.Location = new System.Drawing.Point(25, 130);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(300, 3);
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
            this.btnSupplier.Location = new System.Drawing.Point(25, 591);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(300, 76);
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
            this.btnWarehouse.Location = new System.Drawing.Point(25, 487);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(300, 76);
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
            this.btnOrder.Location = new System.Drawing.Point(25, 279);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(300, 76);
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
            this.btnCustomer.Location = new System.Drawing.Point(25, 383);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(300, 76);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlUserControls
            // 
            this.pnlUserControls.BackColor = System.Drawing.Color.White;
            this.pnlUserControls.Controls.Add(this.ucOverview1);
            this.pnlUserControls.Controls.Add(this.ucHR1);
            this.pnlUserControls.Controls.Add(this.ucWarehouse1);
            this.pnlUserControls.Controls.Add(this.ucSuppliercs1);
            this.pnlUserControls.Location = new System.Drawing.Point(350, 0);
            this.pnlUserControls.Name = "pnlUserControls";
            this.pnlUserControls.Size = new System.Drawing.Size(1700, 1036);
            this.pnlUserControls.TabIndex = 3;
            // 
            // ucHR1
            // 
            this.ucHR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucHR1.Location = new System.Drawing.Point(0, 0);
            this.ucHR1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucHR1.Name = "ucHR1";
            this.ucHR1.Size = new System.Drawing.Size(1552, 1036);
            this.ucHR1.TabIndex = 3;
            // 
            // ucWarehouse1
            // 
            this.ucWarehouse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucWarehouse1.Location = new System.Drawing.Point(0, 0);
            this.ucWarehouse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucWarehouse1.Name = "ucWarehouse1";
            this.ucWarehouse1.Size = new System.Drawing.Size(1552, 1036);
            this.ucWarehouse1.TabIndex = 2;
            // 
            // ucSuppliercs1
            // 
            this.ucSuppliercs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucSuppliercs1.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliercs1.Margin = new System.Windows.Forms.Padding(4);
            this.ucSuppliercs1.Name = "ucSuppliercs1";
            this.ucSuppliercs1.Size = new System.Drawing.Size(1552, 1036);
            this.ucSuppliercs1.TabIndex = 1;
            // 
            // ucOverview1
            // 
            this.ucOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOverview1.Location = new System.Drawing.Point(0, 0);
            this.ucOverview1.Name = "ucOverview1";
            this.ucOverview1.Size = new System.Drawing.Size(1552, 1036);
            this.ucOverview1.TabIndex = 4;
            // 
            // FEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlUserControls);
            this.Controls.Add(this.pnlAllButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Furniture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FEmployee_Load);
            this.pnlAllButton.ResumeLayout(false);
            this.pnlAllButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        protected Guna.UI2.WinForms.Guna2CirclePictureBox picLogo;
        protected System.Windows.Forms.Label label1;
        protected Guna.UI2.WinForms.Guna2Button btnLogout;
        protected Guna.UI2.WinForms.Guna2Panel pnlUserControls;
        private ucSuppliercs ucSuppliercs1;
        private ucWarehouse ucWarehouse1;
        protected Guna.UI2.WinForms.Guna2Button btnHR;
        protected Guna.UI2.WinForms.Guna2Button btnHome;
        private Controls.ucHR ucHR1;
        private ucOverview ucOverview1;
    }
}