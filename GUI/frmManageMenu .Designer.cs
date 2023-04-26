namespace GUI
{
    partial class frmManageMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_danhsachTD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chiTiet = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_khuyenMai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_phanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_phanLoaiTD = new Guna.UI2.WinForms.Guna2Button();
            this.dtg_quanLyTD = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanLyTD)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_danhsachTD
            // 
            this.lbl_danhsachTD.BackColor = System.Drawing.Color.Transparent;
            this.lbl_danhsachTD.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danhsachTD.Location = new System.Drawing.Point(323, 12);
            this.lbl_danhsachTD.Name = "lbl_danhsachTD";
            this.lbl_danhsachTD.Size = new System.Drawing.Size(936, 92);
            this.lbl_danhsachTD.TabIndex = 3;
            this.lbl_danhsachTD.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Transparent;
            this.btn_them.BorderThickness = 1;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(966, 120);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(166, 32);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            // 
            // btn_chiTiet
            // 
            this.btn_chiTiet.BackColor = System.Drawing.Color.Transparent;
            this.btn_chiTiet.BorderThickness = 1;
            this.btn_chiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chiTiet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_chiTiet.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_chiTiet.ForeColor = System.Drawing.Color.Black;
            this.btn_chiTiet.Location = new System.Drawing.Point(783, 120);
            this.btn_chiTiet.Name = "btn_chiTiet";
            this.btn_chiTiet.Size = new System.Drawing.Size(166, 32);
            this.btn_chiTiet.TabIndex = 36;
            this.btn_chiTiet.Text = "Chi tiết";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_timKiem.BorderThickness = 1;
            this.btn_timKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_timKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_timKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timKiem.Location = new System.Drawing.Point(600, 120);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(166, 32);
            this.btn_timKiem.TabIndex = 35;
            this.btn_timKiem.Text = "Tìm kiếm";
            // 
            // btn_khuyenMai
            // 
            this.btn_khuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.btn_khuyenMai.BorderThickness = 1;
            this.btn_khuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_khuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_khuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_khuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_khuyenMai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_khuyenMai.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_khuyenMai.ForeColor = System.Drawing.Color.Black;
            this.btn_khuyenMai.Location = new System.Drawing.Point(1336, 120);
            this.btn_khuyenMai.Name = "btn_khuyenMai";
            this.btn_khuyenMai.Size = new System.Drawing.Size(184, 32);
            this.btn_khuyenMai.TabIndex = 39;
            this.btn_khuyenMai.Text = "Khuyến mãi";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.BorderThickness = 1;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(1153, 120);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(166, 32);
            this.btn_xoa.TabIndex = 38;
            this.btn_xoa.Text = "Xóa";
            // 
            // cbb_phanLoai
            // 
            this.cbb_phanLoai.AutoRoundedCorners = true;
            this.cbb_phanLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbb_phanLoai.BorderRadius = 17;
            this.cbb_phanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_phanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_phanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_phanLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_phanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_phanLoai.ItemHeight = 30;
            this.cbb_phanLoai.Location = new System.Drawing.Point(307, 120);
            this.cbb_phanLoai.Name = "cbb_phanLoai";
            this.cbb_phanLoai.Size = new System.Drawing.Size(226, 36);
            this.cbb_phanLoai.TabIndex = 41;
            // 
            // btn_phanLoaiTD
            // 
            this.btn_phanLoaiTD.BackColor = System.Drawing.Color.Transparent;
            this.btn_phanLoaiTD.BorderThickness = 1;
            this.btn_phanLoaiTD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_phanLoaiTD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_phanLoaiTD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_phanLoaiTD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_phanLoaiTD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_phanLoaiTD.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_phanLoaiTD.ForeColor = System.Drawing.Color.Black;
            this.btn_phanLoaiTD.Location = new System.Drawing.Point(12, 124);
            this.btn_phanLoaiTD.Name = "btn_phanLoaiTD";
            this.btn_phanLoaiTD.Size = new System.Drawing.Size(251, 32);
            this.btn_phanLoaiTD.TabIndex = 42;
            this.btn_phanLoaiTD.Text = "Phân loại thực đơn";
            // 
            // dtg_quanLyTD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_quanLyTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_quanLyTD.ColumnHeadersHeight = 4;
            this.dtg_quanLyTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_quanLyTD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_quanLyTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyTD.Location = new System.Drawing.Point(-3, 197);
            this.dtg_quanLyTD.Name = "dtg_quanLyTD";
            this.dtg_quanLyTD.RowHeadersVisible = false;
            this.dtg_quanLyTD.RowHeadersWidth = 51;
            this.dtg_quanLyTD.RowTemplate.Height = 24;
            this.dtg_quanLyTD.Size = new System.Drawing.Size(1587, 621);
            this.dtg_quanLyTD.TabIndex = 43;
            this.dtg_quanLyTD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyTD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_quanLyTD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_quanLyTD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_quanLyTD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_quanLyTD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyTD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_quanLyTD.ThemeStyle.HeaderStyle.Height = 4;
            this.dtg_quanLyTD.ThemeStyle.ReadOnly = false;
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyTD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.dtg_quanLyTD);
            this.Controls.Add(this.btn_phanLoaiTD);
            this.Controls.Add(this.cbb_phanLoai);
            this.Controls.Add(this.btn_khuyenMai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_chiTiet);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.lbl_danhsachTD);
            this.Name = "frmManageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanLyTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_danhsachTD;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_chiTiet;
        private Guna.UI2.WinForms.Guna2Button btn_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_khuyenMai;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_phanLoai;
        private Guna.UI2.WinForms.Guna2Button btn_phanLoaiTD;
        private Guna.UI2.WinForms.Guna2DataGridView dtg_quanLyTD;
    }
}