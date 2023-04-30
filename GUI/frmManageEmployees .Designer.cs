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
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_tennv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_honv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_gioitinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_sdt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_addr = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_ngayVaoLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_loainv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_account = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbEmployeeType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
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
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BorderThickness = 1;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(1154, 408);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(166, 43);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Xuất File";
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
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BorderColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BorderRadius = 5;
            this.txtFirstName.BorderThickness = 0;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Transparent;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(197, 163);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(263, 32);
            this.txtFirstName.TabIndex = 16;
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
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderRadius = 5;
            this.txtLastName.BorderThickness = 0;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtLastName.ForeColor = System.Drawing.Color.Transparent;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(197, 99);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(263, 32);
            this.txtLastName.TabIndex = 14;
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
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 5;
            this.txtPhone.BorderThickness = 0;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtPhone.ForeColor = System.Drawing.Color.Transparent;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(717, 75);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(263, 32);
            this.txtPhone.TabIndex = 22;
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
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderThickness = 0;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtAddress.ForeColor = System.Drawing.Color.Transparent;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(717, 11);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(263, 32);
            this.txtAddress.TabIndex = 20;
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
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.BorderColor = System.Drawing.Color.Transparent;
            this.txtAccount.BorderRadius = 5;
            this.txtAccount.BorderThickness = 0;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.DefaultText = "";
            this.txtAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtAccount.ForeColor = System.Drawing.Color.Transparent;
            this.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccount.Location = new System.Drawing.Point(1270, 99);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAccount.PlaceholderText = "";
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(263, 32);
            this.txtAccount.TabIndex = 26;
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
            this.guna2Panel1.Controls.Add(this.dtpStartDate);
            this.guna2Panel1.Controls.Add(this.cmbEmployeeType);
            this.guna2Panel1.Controls.Add(this.cmbGender);
            this.guna2Panel1.Controls.Add(this.dtpBirthday);
            this.guna2Panel1.Controls.Add(this.txtPhone);
            this.guna2Panel1.Controls.Add(this.txtAddress);
            this.guna2Panel1.Controls.Add(this.lbl_sdt);
            this.guna2Panel1.Controls.Add(this.lbl_addr);
            this.guna2Panel1.Controls.Add(this.lbl_gioitinh);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 88);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1584, 200);
            this.guna2Panel1.TabIndex = 31;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.FillColor = System.Drawing.Color.White;
            this.dtpBirthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthday.Location = new System.Drawing.Point(197, 139);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(263, 36);
            this.dtpBirthday.TabIndex = 36;
            this.dtpBirthday.Value = new System.DateTime(2023, 4, 26, 15, 40, 20, 439);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderThickness = 1;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(605, 408);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 43);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "THÊM";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(788, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 43);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "XÓA";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(971, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 43);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "SỬA";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.ColumnHeadersHeight = 30;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployees.Location = new System.Drawing.Point(0, 475);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(1584, 351);
            this.dgvEmployees.TabIndex = 35;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmployees.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvEmployees.ThemeStyle.ReadOnly = true;
            this.dgvEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmployees.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Location = new System.Drawing.Point(717, 135);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(177, 36);
            this.cmbGender.TabIndex = 37;
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmployeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmployeeType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEmployeeType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmployeeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEmployeeType.ItemHeight = 30;
            this.cmbEmployeeType.Location = new System.Drawing.Point(1270, 75);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(177, 36);
            this.cmbEmployeeType.TabIndex = 38;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(1270, 139);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(263, 36);
            this.dtpStartDate.TabIndex = 39;
            this.dtpStartDate.Value = new System.DateTime(2023, 4, 26, 15, 40, 20, 439);
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbl_ngayVaoLam);
            this.Controls.Add(this.lbl_loainv);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbl_tennv);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbl_honv);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageEmployees";
            this.Load += new System.EventHandler(this.frmManageEmployees_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txb_search;
        private Guna.UI2.WinForms.Guna2CircleButton btn_search;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_date;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_tennv;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_honv;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gioitinh;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_sdt;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_addr;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ngayVaoLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_loainv;
        private Guna.UI2.WinForms.Guna2TextBox txtAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_account;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEmployeeType;
    }
}