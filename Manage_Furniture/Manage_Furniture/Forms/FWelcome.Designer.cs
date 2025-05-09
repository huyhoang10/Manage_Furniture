namespace Manage_Furniture
{
    partial class FWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWelcome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(715, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Perfect Furniture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(1097, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 104);
            this.label2.TabIndex = 2;
            this.label2.Text = "for Your Home";
            // 
            // btn_login
            // 
            this.btn_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.btn_login.BorderRadius = 35;
            this.btn_login.BorderThickness = 1;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(217)))));
            this.btn_login.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.btn_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.btn_login.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.btn_login.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(1348, 745);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(376, 97);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log In";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1411, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 928);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Furniture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_login;
    }
}

