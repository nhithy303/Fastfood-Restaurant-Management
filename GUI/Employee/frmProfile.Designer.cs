namespace GUI
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblProfile = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tblPassword = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCurrentPW = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNewPW = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRetypePW = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tblMain.SuspendLayout();
            this.tblProfile.SuspendLayout();
            this.tblInfo.SuspendLayout();
            this.tblPassword.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.label1, 0, 0);
            this.tblMain.Controls.Add(this.tblProfile, 0, 1);
            this.tblMain.Controls.Add(this.tblButton, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.Size = new System.Drawing.Size(875, 657);
            this.tblMain.TabIndex = 0;
            // 
            // tblProfile
            // 
            this.tblProfile.ColumnCount = 2;
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblProfile.Controls.Add(this.tblInfo, 0, 0);
            this.tblProfile.Controls.Add(this.tblPassword, 1, 0);
            this.tblProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProfile.Location = new System.Drawing.Point(3, 101);
            this.tblProfile.Name = "tblProfile";
            this.tblProfile.RowCount = 1;
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProfile.Size = new System.Drawing.Size(869, 453);
            this.tblProfile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 51);
            this.label1.TabIndex = 76;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblInfo
            // 
            this.tblInfo.ColumnCount = 2;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblInfo.Controls.Add(this.label11, 0, 9);
            this.tblInfo.Controls.Add(this.label2, 0, 0);
            this.tblInfo.Controls.Add(this.label3, 0, 1);
            this.tblInfo.Controls.Add(this.label4, 0, 2);
            this.tblInfo.Controls.Add(this.label5, 0, 3);
            this.tblInfo.Controls.Add(this.label6, 0, 4);
            this.tblInfo.Controls.Add(this.label7, 0, 5);
            this.tblInfo.Controls.Add(this.label8, 0, 6);
            this.tblInfo.Controls.Add(this.label9, 0, 7);
            this.tblInfo.Controls.Add(this.label10, 0, 8);
            this.tblInfo.Controls.Add(this.txtID, 1, 0);
            this.tblInfo.Controls.Add(this.txtAccount, 1, 1);
            this.tblInfo.Controls.Add(this.txtLastName, 1, 2);
            this.tblInfo.Controls.Add(this.txtFirstName, 1, 3);
            this.tblInfo.Controls.Add(this.dtpBirthday, 1, 4);
            this.tblInfo.Controls.Add(this.cboGender, 1, 5);
            this.tblInfo.Controls.Add(this.txtPhone, 1, 6);
            this.tblInfo.Controls.Add(this.txtAddress, 1, 7);
            this.tblInfo.Controls.Add(this.cboType, 1, 8);
            this.tblInfo.Controls.Add(this.dtpStartDate, 1, 9);
            this.tblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInfo.Location = new System.Drawing.Point(3, 3);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 10;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInfo.Size = new System.Drawing.Size(515, 447);
            this.tblInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mã nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Mã tài khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "Họ nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 95;
            this.label5.Text = "Tên nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 96;
            this.label6.Text = "Ngày sinh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 97;
            this.label7.Text = "Giới tính";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 98;
            this.label8.Text = "Số điện thoại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 99;
            this.label9.Text = "Địa chỉ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 25);
            this.label10.TabIndex = 100;
            this.label10.Text = "Loại nhân viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 101;
            this.label11.Text = "Ngày vào làm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderColor = System.Drawing.Color.Transparent;
            this.txtID.BorderRadius = 5;
            this.txtID.BorderThickness = 0;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(185, 6);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(80, 31);
            this.txtID.TabIndex = 102;
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.txtAccount.Enabled = false;
            this.txtAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccount.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtAccount.ForeColor = System.Drawing.Color.Black;
            this.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccount.Location = new System.Drawing.Point(185, 50);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAccount.PlaceholderText = "";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(80, 31);
            this.txtAccount.TabIndex = 103;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(185, 94);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(325, 31);
            this.txtLastName.TabIndex = 104;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(185, 138);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(150, 31);
            this.txtFirstName.TabIndex = 105;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpBirthday.BorderRadius = 5;
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.FillColor = System.Drawing.Color.White;
            this.dtpBirthday.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(183, 180);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(170, 36);
            this.dtpBirthday.TabIndex = 106;
            this.dtpBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpBirthday.Value = new System.DateTime(2023, 4, 26, 15, 40, 20, 439);
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.BorderRadius = 5;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGender.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGender.ItemHeight = 30;
            this.cboGender.Location = new System.Drawing.Point(183, 224);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(150, 36);
            this.cboGender.TabIndex = 107;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(185, 270);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(150, 31);
            this.txtPhone.TabIndex = 108;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(185, 314);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(325, 31);
            this.txtAddress.TabIndex = 109;
            // 
            // cboType
            // 
            this.cboType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboType.BackColor = System.Drawing.Color.Transparent;
            this.cboType.BorderRadius = 5;
            this.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Enabled = false;
            this.cboType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboType.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cboType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboType.ItemHeight = 30;
            this.cboType.Location = new System.Drawing.Point(183, 356);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(200, 36);
            this.cboType.TabIndex = 110;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.BorderRadius = 5;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(183, 403);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(170, 36);
            this.dtpStartDate.TabIndex = 111;
            this.dtpStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpStartDate.Value = new System.DateTime(2023, 4, 26, 15, 40, 20, 439);
            // 
            // tblPassword
            // 
            this.tblPassword.ColumnCount = 1;
            this.tblPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPassword.Controls.Add(this.btnChangePassword, 0, 7);
            this.tblPassword.Controls.Add(this.label12, 0, 0);
            this.tblPassword.Controls.Add(this.label13, 0, 1);
            this.tblPassword.Controls.Add(this.txtCurrentPW, 0, 2);
            this.tblPassword.Controls.Add(this.label14, 0, 3);
            this.tblPassword.Controls.Add(this.txtNewPW, 0, 4);
            this.tblPassword.Controls.Add(this.label15, 0, 5);
            this.tblPassword.Controls.Add(this.txtRetypePW, 0, 6);
            this.tblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPassword.Location = new System.Drawing.Point(524, 3);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.RowCount = 8;
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblPassword.Size = new System.Drawing.Size(342, 447);
            this.tblPassword.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(74, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 25);
            this.label12.TabIndex = 93;
            this.label12.Text = "Cập nhật mật khẩu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 25);
            this.label13.TabIndex = 94;
            this.label13.Text = "Mật khẩu hiện tại";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentPW
            // 
            this.txtCurrentPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrentPW.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPW.BorderColor = System.Drawing.Color.Transparent;
            this.txtCurrentPW.BorderRadius = 5;
            this.txtCurrentPW.BorderThickness = 0;
            this.txtCurrentPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPW.DefaultText = "";
            this.txtCurrentPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPW.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtCurrentPW.ForeColor = System.Drawing.Color.Black;
            this.txtCurrentPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPW.Location = new System.Drawing.Point(46, 94);
            this.txtCurrentPW.Margin = new System.Windows.Forms.Padding(5);
            this.txtCurrentPW.Name = "txtCurrentPW";
            this.txtCurrentPW.PasswordChar = '●';
            this.txtCurrentPW.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCurrentPW.PlaceholderText = "";
            this.txtCurrentPW.SelectedText = "";
            this.txtCurrentPW.Size = new System.Drawing.Size(250, 31);
            this.txtCurrentPW.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 25);
            this.label14.TabIndex = 107;
            this.label14.Text = "Mật khẩu mới";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPW
            // 
            this.txtNewPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPW.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPW.BorderColor = System.Drawing.Color.Transparent;
            this.txtNewPW.BorderRadius = 5;
            this.txtNewPW.BorderThickness = 0;
            this.txtNewPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPW.DefaultText = "";
            this.txtNewPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPW.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtNewPW.ForeColor = System.Drawing.Color.Black;
            this.txtNewPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPW.Location = new System.Drawing.Point(46, 182);
            this.txtNewPW.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.PasswordChar = '●';
            this.txtNewPW.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPW.PlaceholderText = "";
            this.txtNewPW.SelectedText = "";
            this.txtNewPW.Size = new System.Drawing.Size(250, 31);
            this.txtNewPW.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 25);
            this.label15.TabIndex = 109;
            this.label15.Text = "Xác nhận mật khẩu";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRetypePW
            // 
            this.txtRetypePW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetypePW.BackColor = System.Drawing.Color.Transparent;
            this.txtRetypePW.BorderColor = System.Drawing.Color.Transparent;
            this.txtRetypePW.BorderRadius = 5;
            this.txtRetypePW.BorderThickness = 0;
            this.txtRetypePW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetypePW.DefaultText = "";
            this.txtRetypePW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetypePW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetypePW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetypePW.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtRetypePW.ForeColor = System.Drawing.Color.Black;
            this.txtRetypePW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRetypePW.Location = new System.Drawing.Point(46, 270);
            this.txtRetypePW.Margin = new System.Windows.Forms.Padding(5);
            this.txtRetypePW.Name = "txtRetypePW";
            this.txtRetypePW.PasswordChar = '●';
            this.txtRetypePW.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRetypePW.PlaceholderText = "";
            this.txtRetypePW.SelectedText = "";
            this.txtRetypePW.Size = new System.Drawing.Size(250, 31);
            this.txtRetypePW.TabIndex = 110;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BorderRadius = 5;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Location = new System.Drawing.Point(71, 311);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.TabIndex = 111;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 3;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblButton.Controls.Add(this.btnUpdate, 0, 0);
            this.tblButton.Controls.Add(this.btnSave, 2, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(3, 560);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Size = new System.Drawing.Size(869, 94);
            this.tblButton.TabIndex = 77;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(238, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Sửa";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(480, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Lưu";
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 657);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblProfile.ResumeLayout(false);
            this.tblInfo.ResumeLayout(false);
            this.tblInfo.PerformLayout();
            this.tblPassword.ResumeLayout(false);
            this.tblPassword.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2TextBox txtAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private Guna.UI2.WinForms.Guna2ComboBox cboGender;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cboType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.TableLayoutPanel tblPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPW;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPW;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtRetypePW;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}