namespace GUI
{
    partial class frmManageEmployees
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
            this.txb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_xuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_tennv = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_tennv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_honv = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_honv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_gioitinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_sdt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_addr = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_addr = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_ngayVaoLam = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_ngayVaoLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_loainv = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_loainv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txb_account = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_account = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.dtv_quanLyNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dt_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_quanLyNV)).BeginInit();
            this.SuspendLayout();
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
            this.txb_search.Location = new System.Drawing.Point(259, 322);
            this.txb_search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_search.Name = "txb_search";
            this.txb_search.PasswordChar = '\0';
            this.txb_search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_search.PlaceholderText = "Search";
            this.txb_search.SelectedText = "";
            this.txb_search.Size = new System.Drawing.Size(1070, 55);
            this.txb_search.TabIndex = 0;
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
            this.btn_search.Location = new System.Drawing.Point(1337, 340);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_search.Size = new System.Drawing.Size(35, 37);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(315, -10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(957, 92);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "DANH SÁCH NHÂN VIÊN";
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
            this.btn_xuatfile.Location = new System.Drawing.Point(1154, 408);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(166, 43);
            this.btn_xuatfile.TabIndex = 3;
            this.btn_xuatfile.Text = "Xuất File";
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(56, 232);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(96, 28);
            this.lbl_date.TabIndex = 17;
            this.lbl_date.Text = "Ngày sinh";
            // 
            // txb_tennv
            // 
            this.txb_tennv.BackColor = System.Drawing.Color.Transparent;
            this.txb_tennv.BorderColor = System.Drawing.Color.Transparent;
            this.txb_tennv.BorderRadius = 5;
            this.txb_tennv.BorderThickness = 0;
            this.txb_tennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_tennv.DefaultText = "";
            this.txb_tennv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_tennv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_tennv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tennv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tennv.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_tennv.ForeColor = System.Drawing.Color.Transparent;
            this.txb_tennv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tennv.Location = new System.Drawing.Point(197, 163);
            this.txb_tennv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_tennv.Name = "txb_tennv";
            this.txb_tennv.PasswordChar = '\0';
            this.txb_tennv.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_tennv.PlaceholderText = "";
            this.txb_tennv.SelectedText = "";
            this.txb_tennv.Size = new System.Drawing.Size(263, 32);
            this.txb_tennv.TabIndex = 16;
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tennv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tennv.Location = new System.Drawing.Point(56, 168);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(137, 28);
            this.lbl_tennv.TabIndex = 15;
            this.lbl_tennv.Text = "Tên nhân viên";
            // 
            // txb_honv
            // 
            this.txb_honv.BackColor = System.Drawing.Color.Transparent;
            this.txb_honv.BorderColor = System.Drawing.Color.Transparent;
            this.txb_honv.BorderRadius = 5;
            this.txb_honv.BorderThickness = 0;
            this.txb_honv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_honv.DefaultText = "";
            this.txb_honv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_honv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_honv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_honv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_honv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_honv.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_honv.ForeColor = System.Drawing.Color.Transparent;
            this.txb_honv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_honv.Location = new System.Drawing.Point(197, 99);
            this.txb_honv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_honv.Name = "txb_honv";
            this.txb_honv.PasswordChar = '\0';
            this.txb_honv.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_honv.PlaceholderText = "";
            this.txb_honv.SelectedText = "";
            this.txb_honv.Size = new System.Drawing.Size(263, 32);
            this.txb_honv.TabIndex = 14;
            // 
            // lbl_honv
            // 
            this.lbl_honv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_honv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_honv.Location = new System.Drawing.Point(56, 104);
            this.lbl_honv.Name = "lbl_honv";
            this.lbl_honv.Size = new System.Drawing.Size(128, 28);
            this.lbl_honv.TabIndex = 13;
            this.lbl_honv.Text = "Họ nhân viên";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.BorderRadius = 5;
            this.guna2TextBox4.BorderThickness = 0;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(717, 139);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(263, 32);
            this.guna2TextBox4.TabIndex = 24;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(601, 144);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(85, 28);
            this.lbl_gioitinh.TabIndex = 23;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // txb_sdt
            // 
            this.txb_sdt.BackColor = System.Drawing.Color.Transparent;
            this.txb_sdt.BorderColor = System.Drawing.Color.Transparent;
            this.txb_sdt.BorderRadius = 5;
            this.txb_sdt.BorderThickness = 0;
            this.txb_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_sdt.DefaultText = "";
            this.txb_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sdt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_sdt.ForeColor = System.Drawing.Color.Transparent;
            this.txb_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sdt.Location = new System.Drawing.Point(717, 75);
            this.txb_sdt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.PasswordChar = '\0';
            this.txb_sdt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_sdt.PlaceholderText = "";
            this.txb_sdt.SelectedText = "";
            this.txb_sdt.Size = new System.Drawing.Size(263, 32);
            this.txb_sdt.TabIndex = 22;
            // 
            // lbl_sdt
            // 
            this.lbl_sdt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdt.Location = new System.Drawing.Point(601, 80);
            this.lbl_sdt.Name = "lbl_sdt";
            this.lbl_sdt.Size = new System.Drawing.Size(47, 28);
            this.lbl_sdt.TabIndex = 21;
            this.lbl_sdt.Text = "SĐT";
            // 
            // txb_addr
            // 
            this.txb_addr.BackColor = System.Drawing.Color.Transparent;
            this.txb_addr.BorderColor = System.Drawing.Color.Transparent;
            this.txb_addr.BorderRadius = 5;
            this.txb_addr.BorderThickness = 0;
            this.txb_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_addr.DefaultText = "";
            this.txb_addr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_addr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_addr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_addr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_addr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_addr.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_addr.ForeColor = System.Drawing.Color.Transparent;
            this.txb_addr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_addr.Location = new System.Drawing.Point(717, 11);
            this.txb_addr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_addr.Name = "txb_addr";
            this.txb_addr.PasswordChar = '\0';
            this.txb_addr.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_addr.PlaceholderText = "";
            this.txb_addr.SelectedText = "";
            this.txb_addr.Size = new System.Drawing.Size(263, 32);
            this.txb_addr.TabIndex = 20;
            // 
            // lbl_addr
            // 
            this.lbl_addr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addr.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addr.Location = new System.Drawing.Point(601, 16);
            this.lbl_addr.Name = "lbl_addr";
            this.lbl_addr.Size = new System.Drawing.Size(70, 28);
            this.lbl_addr.TabIndex = 19;
            this.lbl_addr.Text = "Địa chỉ";
            // 
            // txb_ngayVaoLam
            // 
            this.txb_ngayVaoLam.BackColor = System.Drawing.Color.Transparent;
            this.txb_ngayVaoLam.BorderColor = System.Drawing.Color.Transparent;
            this.txb_ngayVaoLam.BorderRadius = 5;
            this.txb_ngayVaoLam.BorderThickness = 0;
            this.txb_ngayVaoLam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_ngayVaoLam.DefaultText = "";
            this.txb_ngayVaoLam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_ngayVaoLam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_ngayVaoLam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_ngayVaoLam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_ngayVaoLam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_ngayVaoLam.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_ngayVaoLam.ForeColor = System.Drawing.Color.Transparent;
            this.txb_ngayVaoLam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_ngayVaoLam.Location = new System.Drawing.Point(1270, 227);
            this.txb_ngayVaoLam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_ngayVaoLam.Name = "txb_ngayVaoLam";
            this.txb_ngayVaoLam.PasswordChar = '\0';
            this.txb_ngayVaoLam.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_ngayVaoLam.PlaceholderText = "";
            this.txb_ngayVaoLam.SelectedText = "";
            this.txb_ngayVaoLam.Size = new System.Drawing.Size(263, 32);
            this.txb_ngayVaoLam.TabIndex = 30;
            // 
            // lbl_ngayVaoLam
            // 
            this.lbl_ngayVaoLam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ngayVaoLam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayVaoLam.Location = new System.Drawing.Point(1120, 232);
            this.lbl_ngayVaoLam.Name = "lbl_ngayVaoLam";
            this.lbl_ngayVaoLam.Size = new System.Drawing.Size(131, 28);
            this.lbl_ngayVaoLam.TabIndex = 29;
            this.lbl_ngayVaoLam.Text = "Ngày vào làm";
            // 
            // txb_loainv
            // 
            this.txb_loainv.BackColor = System.Drawing.Color.Transparent;
            this.txb_loainv.BorderColor = System.Drawing.Color.Transparent;
            this.txb_loainv.BorderRadius = 5;
            this.txb_loainv.BorderThickness = 0;
            this.txb_loainv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_loainv.DefaultText = "......";
            this.txb_loainv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_loainv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_loainv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_loainv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_loainv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_loainv.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_loainv.ForeColor = System.Drawing.Color.Transparent;
            this.txb_loainv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_loainv.Location = new System.Drawing.Point(1270, 163);
            this.txb_loainv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_loainv.Name = "txb_loainv";
            this.txb_loainv.PasswordChar = '\0';
            this.txb_loainv.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_loainv.PlaceholderText = "Search";
            this.txb_loainv.SelectedText = "";
            this.txb_loainv.Size = new System.Drawing.Size(263, 32);
            this.txb_loainv.TabIndex = 28;
            // 
            // lbl_loainv
            // 
            this.lbl_loainv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loainv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loainv.Location = new System.Drawing.Point(1120, 168);
            this.lbl_loainv.Name = "lbl_loainv";
            this.lbl_loainv.Size = new System.Drawing.Size(142, 28);
            this.lbl_loainv.TabIndex = 27;
            this.lbl_loainv.Text = "Loại nhân viên";
            // 
            // txb_account
            // 
            this.txb_account.BackColor = System.Drawing.Color.Transparent;
            this.txb_account.BorderColor = System.Drawing.Color.Transparent;
            this.txb_account.BorderRadius = 5;
            this.txb_account.BorderThickness = 0;
            this.txb_account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_account.DefaultText = "";
            this.txb_account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_account.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txb_account.ForeColor = System.Drawing.Color.Transparent;
            this.txb_account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_account.Location = new System.Drawing.Point(1270, 99);
            this.txb_account.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_account.Name = "txb_account";
            this.txb_account.PasswordChar = '\0';
            this.txb_account.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txb_account.PlaceholderText = "";
            this.txb_account.SelectedText = "";
            this.txb_account.Size = new System.Drawing.Size(263, 32);
            this.txb_account.TabIndex = 26;
            // 
            // lbl_account
            // 
            this.lbl_account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_account.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(1120, 104);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(101, 28);
            this.lbl_account.TabIndex = 25;
            this.lbl_account.Text = "Tài Khoản";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.dt_date);
            this.guna2Panel1.Controls.Add(this.txb_sdt);
            this.guna2Panel1.Controls.Add(this.txb_addr);
            this.guna2Panel1.Controls.Add(this.guna2TextBox4);
            this.guna2Panel1.Controls.Add(this.lbl_sdt);
            this.guna2Panel1.Controls.Add(this.lbl_addr);
            this.guna2Panel1.Controls.Add(this.lbl_gioitinh);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 88);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1584, 200);
            this.guna2Panel1.TabIndex = 31;
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
            this.btn_them.Location = new System.Drawing.Point(605, 408);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(166, 43);
            this.btn_them.TabIndex = 32;
            this.btn_them.Text = "THÊM";
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
            this.btn_xoa.Location = new System.Drawing.Point(788, 408);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(166, 43);
            this.btn_xoa.TabIndex = 33;
            this.btn_xoa.Text = "XÓA";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BorderThickness = 1;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(971, 408);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(166, 43);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "SỬA";
            // 
            // dtv_quanLyNV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtv_quanLyNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtv_quanLyNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtv_quanLyNV.ColumnHeadersHeight = 4;
            this.dtv_quanLyNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtv_quanLyNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtv_quanLyNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_quanLyNV.Location = new System.Drawing.Point(0, 475);
            this.dtv_quanLyNV.Name = "dtv_quanLyNV";
            this.dtv_quanLyNV.RowHeadersVisible = false;
            this.dtv_quanLyNV.RowHeadersWidth = 51;
            this.dtv_quanLyNV.RowTemplate.Height = 24;
            this.dtv_quanLyNV.Size = new System.Drawing.Size(1584, 351);
            this.dtv_quanLyNV.TabIndex = 35;
            this.dtv_quanLyNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtv_quanLyNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtv_quanLyNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtv_quanLyNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtv_quanLyNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtv_quanLyNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtv_quanLyNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtv_quanLyNV.ThemeStyle.HeaderStyle.Height = 4;
            this.dtv_quanLyNV.ThemeStyle.ReadOnly = false;
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.Height = 24;
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtv_quanLyNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dt_date
            // 
            this.dt_date.Checked = true;
            this.dt_date.FillColor = System.Drawing.Color.White;
            this.dt_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_date.Location = new System.Drawing.Point(197, 139);
            this.dt_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(263, 36);
            this.dt_date.TabIndex = 36;
            this.dt_date.Value = new System.DateTime(2023, 4, 26, 15, 40, 20, 439);
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.dtv_quanLyNV);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txb_ngayVaoLam);
            this.Controls.Add(this.lbl_ngayVaoLam);
            this.Controls.Add(this.txb_loainv);
            this.Controls.Add(this.lbl_loainv);
            this.Controls.Add(this.txb_account);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txb_tennv);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.txb_honv);
            this.Controls.Add(this.lbl_honv);
            this.Controls.Add(this.btn_xuatfile);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageEmployees";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_quanLyNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txb_search;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_xuatfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_date;
        private Guna.UI2.WinForms.Guna2TextBox txb_tennv;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_tennv;
        private Guna.UI2.WinForms.Guna2TextBox txb_honv;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_honv;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gioitinh;
        private Guna.UI2.WinForms.Guna2TextBox txb_sdt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_sdt;
        private Guna.UI2.WinForms.Guna2TextBox txb_addr;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_addr;
        private Guna.UI2.WinForms.Guna2TextBox txb_ngayVaoLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ngayVaoLam;
        private Guna.UI2.WinForms.Guna2TextBox txb_loainv;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_loainv;
        private Guna.UI2.WinForms.Guna2TextBox txb_account;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_account;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2DataGridView dtv_quanLyNV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_date;
    }
}