namespace GUI
{
    partial class frmShowImportBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_chiTietHoaDon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_xuatHD = new Guna.UI2.WinForms.Guna2Button();
            this.dtg_chiTietHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_chiTietHoaDon
            // 
            this.lbl_chiTietHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chiTietHoaDon.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiTietHoaDon.Location = new System.Drawing.Point(613, 24);
            this.lbl_chiTietHoaDon.Name = "lbl_chiTietHoaDon";
            this.lbl_chiTietHoaDon.Size = new System.Drawing.Size(383, 92);
            this.lbl_chiTietHoaDon.TabIndex = 59;
            this.lbl_chiTietHoaDon.Text = "HÓA ĐƠN";
            // 
            // btn_xuatHD
            // 
            this.btn_xuatHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_xuatHD.BorderThickness = 1;
            this.btn_xuatHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xuatHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xuatHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xuatHD.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_xuatHD.ForeColor = System.Drawing.Color.Black;
            this.btn_xuatHD.Location = new System.Drawing.Point(1302, 703);
            this.btn_xuatHD.Name = "btn_xuatHD";
            this.btn_xuatHD.Size = new System.Drawing.Size(166, 43);
            this.btn_xuatHD.TabIndex = 60;
            this.btn_xuatHD.Text = "Xuất Hóa Đơn";
            // 
            // dtg_chiTietHoaDon
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtg_chiTietHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_chiTietHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_chiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_chiTietHoaDon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_chiTietHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_chiTietHoaDon.Location = new System.Drawing.Point(139, 157);
            this.dtg_chiTietHoaDon.Name = "dtg_chiTietHoaDon";
            this.dtg_chiTietHoaDon.RowHeadersVisible = false;
            this.dtg_chiTietHoaDon.RowHeadersWidth = 51;
            this.dtg_chiTietHoaDon.RowTemplate.Height = 24;
            this.dtg_chiTietHoaDon.Size = new System.Drawing.Size(1349, 520);
            this.dtg_chiTietHoaDon.TabIndex = 61;
            this.dtg_chiTietHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_chiTietHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_chiTietHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_chiTietHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_chiTietHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_chiTietHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_chiTietHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_chiTietHoaDon.ThemeStyle.HeaderStyle.Height = 4;
            this.dtg_chiTietHoaDon.ThemeStyle.ReadOnly = false;
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_chiTietHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmShowImportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.dtg_chiTietHoaDon);
            this.Controls.Add(this.btn_xuatHD);
            this.Controls.Add(this.lbl_chiTietHoaDon);
            this.Name = "frmShowImportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowImportBill";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_chiTietHoaDon;
        private Guna.UI2.WinForms.Guna2Button btn_xuatHD;
        private Guna.UI2.WinForms.Guna2DataGridView dtg_chiTietHoaDon;
    }
}