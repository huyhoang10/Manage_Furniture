namespace Manage_Furniture.Controls
{
    partial class ucHumanResourceManagement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnAd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.gnaUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnaUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(321, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1078, 88);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Human Resource Management";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(1263, 140);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(152, 51);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Admin";
            // 
            // btnAd
            // 
            this.btnAd.BorderRadius = 16;
            this.btnAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAd.FillColor = System.Drawing.Color.White;
            this.btnAd.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.Black;
            this.btnAd.Location = new System.Drawing.Point(480, 840);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(152, 106);
            this.btnAd.TabIndex = 7;
            this.btnAd.Text = "Thêm";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 16;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(679, 840);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 106);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 16;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(883, 840);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 106);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xoá";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(101, 239);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ShowRowErrors = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1399, 522);
            this.dgvEmployees.TabIndex = 3;
            // 
            // gnaUserAvatar
            // 
            this.gnaUserAvatar.ImageRotate = 0F;
            this.gnaUserAvatar.Location = new System.Drawing.Point(1421, 140);
            this.gnaUserAvatar.Name = "gnaUserAvatar";
            this.gnaUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaUserAvatar.Size = new System.Drawing.Size(64, 64);
            this.gnaUserAvatar.TabIndex = 10;
            this.gnaUserAvatar.TabStop = false;
            // 
            // ucHumanResourceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(184)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.gnaUserAvatar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucHumanResourceManagement";
            this.Size = new System.Drawing.Size(1552, 1036);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnaUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserRole;
        private Guna.UI2.WinForms.Guna2Button btnAd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2CirclePictureBox gnaUserAvatar;
    }
}
