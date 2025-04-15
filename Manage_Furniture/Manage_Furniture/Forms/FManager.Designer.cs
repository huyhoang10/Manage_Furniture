namespace Manage_Furniture.Forms
{
    partial class FManager
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
        protected  void InitializeComponent()
        {
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnHR = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.BorderRadius = 16;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(25, 179);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 76);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHR
            // 
            this.btnHR.BackColor = System.Drawing.Color.White;
            this.btnHR.BorderRadius = 16;
            this.btnHR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHR.FillColor = System.Drawing.Color.White;
            this.btnHR.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHR.ForeColor = System.Drawing.Color.Black;
            this.btnHR.Location = new System.Drawing.Point(25, 660);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(300, 76);
            this.btnHR.TabIndex = 6;
            this.btnHR.Text = "HR";
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnHome);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FManager";
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.FManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Guna.UI2.WinForms.Guna2Button btnHome;
        protected Guna.UI2.WinForms.Guna2Button btnHR;
    }
}