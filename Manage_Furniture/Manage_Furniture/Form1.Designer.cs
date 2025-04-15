namespace Manage_Furniture
{
    partial class Form1
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
            this.btnE = new Guna.UI2.WinForms.Guna2Button();
            this.btnM = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnE
            // 
            this.btnE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Location = new System.Drawing.Point(136, 174);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(180, 45);
            this.btnE.TabIndex = 0;
            this.btnE.Text = "Employee";
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnM
            // 
            this.btnM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.Location = new System.Drawing.Point(438, 174);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(180, 45);
            this.btnM.TabIndex = 1;
            this.btnM.Text = "Manager";
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnE;
        private Guna.UI2.WinForms.Guna2Button btnM;
    }
}

