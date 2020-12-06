namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QLNhomNguoiDung
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
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.Id_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Group,
            this.Name_Group});
            this.dgvDSThietBi.Location = new System.Drawing.Point(232, 193);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.RowHeadersWidth = 51;
            this.dgvDSThietBi.Size = new System.Drawing.Size(464, 228);
            this.dgvDSThietBi.TabIndex = 29;
            // 
            // Id_Group
            // 
            this.Id_Group.DataPropertyName = "Id_Group";
            this.Id_Group.HeaderText = "Mã Nhóm";
            this.Id_Group.MinimumWidth = 6;
            this.Id_Group.Name = "Id_Group";
            this.Id_Group.Width = 150;
            // 
            // Name_Group
            // 
            this.Name_Group.DataPropertyName = "Name_Group";
            this.Name_Group.HeaderText = "Tên Nhóm";
            this.Name_Group.MinimumWidth = 6;
            this.Name_Group.Name = "Name_Group";
            this.Name_Group.Width = 150;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(38, 60);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(867, 61);
            this.lbl_QLTaiKhoan.TabIndex = 28;
            this.lbl_QLTaiKhoan.Text = "DANH SÁCH NHÓM NGƯỜI DÙNG";
            // 
            // QLNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.dgvDSThietBi);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QLNhomNguoiDung";
            this.Text = "QLNhomNguoiDung";
            this.Load += new System.EventHandler(this.QLNhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Group;
    }
}