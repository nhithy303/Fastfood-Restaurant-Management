namespace GUI
{
    partial class frmManageStorage
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
            this.dtg_quanLyKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_xuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbl_quanLyKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanLyKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_quanLyKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_quanLyKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_quanLyKH.ColumnHeadersHeight = 4;
            this.dtg_quanLyKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_quanLyKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_quanLyKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyKH.Location = new System.Drawing.Point(-5, 301);
            this.dtg_quanLyKH.Name = "dtg_quanLyKH";
            this.dtg_quanLyKH.RowHeadersVisible = false;
            this.dtg_quanLyKH.RowHeadersWidth = 51;
            this.dtg_quanLyKH.RowTemplate.Height = 24;
            this.dtg_quanLyKH.Size = new System.Drawing.Size(1592, 514);
            this.dtg_quanLyKH.TabIndex = 64;
            this.dtg_quanLyKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtg_quanLyKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtg_quanLyKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtg_quanLyKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtg_quanLyKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtg_quanLyKH.ThemeStyle.HeaderStyle.Height = 4;
            this.dtg_quanLyKH.ThemeStyle.ReadOnly = false;
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.Height = 24;
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtg_quanLyKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_xuatfile.BorderThickness = 1;
            this.btn_xuatfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xuatfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xuatfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xuatfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xuatfile.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_xuatfile.ForeColor = System.Drawing.Color.Black;
            this.btn_xuatfile.Location = new System.Drawing.Point(1149, 234);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(166, 43);
            this.btn_xuatfile.TabIndex = 60;
            this.btn_xuatfile.Text = "Xuất File";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = global::GUI.Properties.Resources.icon_search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(1332, 166);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_search.Size = new System.Drawing.Size(35, 37);
            this.btn_search.TabIndex = 58;
            this.btn_search.UseTransparentBackground = true;
            // 
            // lbl_quanLyKH
            // 
            this.lbl_quanLyKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quanLyKH.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quanLyKH.Location = new System.Drawing.Point(406, -2);
            this.lbl_quanLyKH.Name = "lbl_quanLyKH";
            this.lbl_quanLyKH.Size = new System.Drawing.Size(836, 92);
            this.lbl_quanLyKH.TabIndex = 59;
            this.lbl_quanLyKH.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.Color.Transparent;
            this.txb_search.BorderColor = System.Drawing.Color.Transparent;
            this.txb_search.BorderRadius = 15;
            this.txb_search.BorderThickness = 0;
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.DefaultText = "";
            this.txb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_search.ForeColor = System.Drawing.Color.Transparent;
            this.txb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Location = new System.Drawing.Point(254, 148);
            this.txb_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_search.Name = "txb_search";
            this.txb_search.PasswordChar = '\0';
            this.txb_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_search.PlaceholderText = "Search";
            this.txb_search.SelectedText = "";
            this.txb_search.Size = new System.Drawing.Size(1070, 55);
            this.txb_search.TabIndex = 57;
            // 
            // frmManageStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.dtg_quanLyKH);
            this.Controls.Add(this.btn_xuatfile);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_quanLyKH);
            this.Controls.Add(this.txb_search);
            this.Name = "frmManageStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageStorage";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_quanLyKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtg_quanLyKH;
        private Guna.UI2.WinForms.Guna2Button btn_xuatfile;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_quanLyKH;
        private Guna.UI2.WinForms.Guna2TextBox txb_search;
    }
}