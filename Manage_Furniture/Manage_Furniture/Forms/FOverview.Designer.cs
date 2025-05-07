namespace Manage_Furniture.Forms
{
    partial class FOverview
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
            this.ucOverview1 = new Manage_Furniture.Forms.ucOverview();
            this.SuspendLayout();
            // 
            // ucOverview1
            // 
            this.ucOverview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.ucOverview1.Location = new System.Drawing.Point(348, 1);
            this.ucOverview1.Name = "ucOverview1";
            this.ucOverview1.Size = new System.Drawing.Size(1552, 1036);
            this.ucOverview1.TabIndex = 0;
            // 
            // FOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ucOverview1);
            this.Name = "FOverview";
            this.Text = "FOverview";
            this.ResumeLayout(false);

        }

        #endregion

        private ucOverview ucOverview1;
    }
}