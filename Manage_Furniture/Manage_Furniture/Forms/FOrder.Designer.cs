namespace Manage_Furniture.Forms
{
    partial class FOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOrder));
            this.gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.gunaAreaDataset2 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.gunaAreaDataset3 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.gunaAreaDataset4 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.ucOrder1 = new Manage_Furniture.Forms.UCOrder();
            this.SuspendLayout();
            // 
            // gunaAreaDataset1
            // 
            this.gunaAreaDataset1.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.Label = "Area1";
            // 
            // gunaAreaDataset2
            // 
            this.gunaAreaDataset2.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset2.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset2.Label = "Area2";
            // 
            // gunaAreaDataset3
            // 
            this.gunaAreaDataset3.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset3.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset3.Label = "Area3";
            // 
            // gunaAreaDataset4
            // 
            this.gunaAreaDataset4.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset4.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset4.Label = "Area4";
            // 
            // ucOrder1
            // 
            this.ucOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOrder1.Location = new System.Drawing.Point(350, 0);
            this.ucOrder1.Name = "ucOrder1";
            this.ucOrder1.Size = new System.Drawing.Size(1552, 1057);
            this.ucOrder1.TabIndex = 0;
            // 
            // FOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.ucOrder1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset2;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset3;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset4;
        private UCOrder ucOrder1;
    }
}