namespace GUI
{
    partial class frmSalesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesManagement));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSale = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tblInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbPayment = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbDate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbEmployee = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.tblInput.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tblSearch.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.label1, 0, 0);
            this.tblMain.Controls.Add(this.dgvSale, 0, 4);
            this.tblMain.Controls.Add(this.tblInput, 0, 1);
            this.tblMain.Controls.Add(this.guna2GroupBox1, 0, 2);
            this.tblMain.Controls.Add(this.tblButton, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblMain.Size = new System.Drawing.Size(1582, 815);
            this.tblMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 76);
            this.label1.TabIndex = 75;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSale.ColumnHeadersHeight = 40;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.Location = new System.Drawing.Point(3, 450);
            this.dgvSale.MultiSelect = false;
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowTemplate.Height = 24;
            this.dgvSale.Size = new System.Drawing.Size(1576, 362);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSale.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSale.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvSale.ThemeStyle.ReadOnly = true;
            this.dgvSale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSale.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSale.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 6;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInput.Controls.Add(this.txtTotal, 0, 1);
            this.tblInput.Controls.Add(this.label9, 0, 1);
            this.tblInput.Controls.Add(this.label4, 0, 0);
            this.tblInput.Controls.Add(this.label5, 2, 1);
            this.tblInput.Controls.Add(this.label7, 2, 0);
            this.tblInput.Controls.Add(this.label6, 4, 0);
            this.tblInput.Controls.Add(this.label8, 4, 1);
            this.tblInput.Controls.Add(this.txtID, 1, 0);
            this.tblInput.Controls.Add(this.dtpDate, 5, 0);
            this.tblInput.Controls.Add(this.cboEmployee, 3, 0);
            this.tblInput.Controls.Add(this.cboPayment, 3, 1);
            this.tblInput.Controls.Add(this.cboState, 5, 1);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput.Location = new System.Drawing.Point(3, 125);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 2;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.Size = new System.Drawing.Size(1576, 116);
            this.tblInput.TabIndex = 78;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BorderColor = System.Drawing.Color.Transparent;
            this.txtTotal.BorderRadius = 5;
            this.txtTotal.BorderThickness = 0;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(241, 71);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(200, 32);
            this.txtTotal.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 97;
            this.label9.Text = "Tổng tiền";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Mã hóa đơn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Thanh toán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 95;
            this.label7.Text = "Nhân viên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1042, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 94;
            this.label6.Text = "Ngày hóa đơn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1077, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 96;
            this.label8.Text = "Trạng thái";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(241, 13);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(80, 32);
            this.txtID.TabIndex = 98;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDate.BorderRadius = 5;
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Enabled = false;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1183, 11);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 36);
            this.dtpDate.TabIndex = 99;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDate.Value = new System.DateTime(2023, 5, 2, 9, 59, 16, 605);
            // 
            // cboEmployee
            // 
            this.cboEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmployee.AutoRoundedCorners = true;
            this.cboEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cboEmployee.BorderRadius = 17;
            this.cboEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboEmployee.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployee.ForeColor = System.Drawing.Color.Black;
            this.cboEmployee.ItemHeight = 30;
            this.cboEmployee.Location = new System.Drawing.Point(632, 11);
            this.cboEmployee.MaxDropDownItems = 5;
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(388, 36);
            this.cboEmployee.TabIndex = 101;
            // 
            // cboPayment
            // 
            this.cboPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPayment.AutoRoundedCorners = true;
            this.cboPayment.BackColor = System.Drawing.Color.Transparent;
            this.cboPayment.BorderRadius = 17;
            this.cboPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPayment.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayment.ForeColor = System.Drawing.Color.Black;
            this.cboPayment.ItemHeight = 30;
            this.cboPayment.Location = new System.Drawing.Point(632, 69);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(300, 36);
            this.cboPayment.TabIndex = 103;
            // 
            // cboState
            // 
            this.cboState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboState.AutoRoundedCorners = true;
            this.cboState.BackColor = System.Drawing.Color.Transparent;
            this.cboState.BorderRadius = 17;
            this.cboState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboState.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.ForeColor = System.Drawing.Color.Black;
            this.cboState.ItemHeight = 30;
            this.cboState.Location = new System.Drawing.Point(1183, 69);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(250, 36);
            this.cboState.TabIndex = 104;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.tblSearch);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 247);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1576, 116);
            this.guna2GroupBox1.TabIndex = 79;
            this.guna2GroupBox1.Text = "Tìm kiếm";
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 5;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearch.Controls.Add(this.btnSearch, 4, 0);
            this.tblSearch.Controls.Add(this.cbPayment, 3, 0);
            this.tblSearch.Controls.Add(this.cbDate, 2, 0);
            this.tblSearch.Controls.Add(this.cbEmployee, 1, 0);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(0, 40);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(1576, 76);
            this.tblSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::GUI.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1184, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 108;
            // 
            // cbPayment
            // 
            this.cbPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPayment.AutoSize = true;
            this.cbPayment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayment.CheckedState.BorderRadius = 0;
            this.cbPayment.CheckedState.BorderThickness = 0;
            this.cbPayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPayment.Location = new System.Drawing.Point(916, 23);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(214, 29);
            this.cbPayment.TabIndex = 111;
            this.cbPayment.Text = "Hình thức thanh toán";
            this.cbPayment.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbPayment.UncheckedState.BorderRadius = 0;
            this.cbPayment.UncheckedState.BorderThickness = 0;
            this.cbPayment.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // cbDate
            // 
            this.cbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDate.AutoSize = true;
            this.cbDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate.CheckedState.BorderRadius = 0;
            this.cbDate.CheckedState.BorderThickness = 0;
            this.cbDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDate.Location = new System.Drawing.Point(630, 23);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(157, 29);
            this.cbDate.TabIndex = 110;
            this.cbDate.Text = "Ngày hóa đơn";
            this.cbDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbDate.UncheckedState.BorderRadius = 0;
            this.cbDate.UncheckedState.BorderThickness = 0;
            this.cbDate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEmployee.AutoSize = true;
            this.cbEmployee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployee.CheckedState.BorderRadius = 0;
            this.cbEmployee.CheckedState.BorderThickness = 0;
            this.cbEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployee.Location = new System.Drawing.Point(332, 23);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(123, 29);
            this.cbEmployee.TabIndex = 109;
            this.cbEmployee.Text = "Nhân viên";
            this.cbEmployee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbEmployee.UncheckedState.BorderRadius = 0;
            this.cbEmployee.UncheckedState.BorderThickness = 0;
            this.cbEmployee.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 3;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblButton.Controls.Add(this.btnReload, 0, 0);
            this.tblButton.Controls.Add(this.btnExportExcel, 1, 0);
            this.tblButton.Controls.Add(this.btnDetail, 0, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(3, 369);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(1576, 75);
            this.tblButton.TabIndex = 80;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 5;
            this.btnReload.BorderThickness = 1;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(712, 17);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 40);
            this.btnReload.TabIndex = 94;
            this.btnReload.Text = "Tải lại";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BorderRadius = 5;
            this.btnExportExcel.BorderThickness = 1;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(948, 17);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(150, 40);
            this.btnExportExcel.TabIndex = 92;
            this.btnExportExcel.Text = "Xuất Excel";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BorderRadius = 5;
            this.btnDetail.BorderThickness = 1;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDetail.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.Location = new System.Drawing.Point(477, 17);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(150, 40);
            this.btnDetail.TabIndex = 93;
            this.btnDetail.Text = "Chi tiết";
            // 
            // frmSalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 815);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.tblInput.ResumeLayout(false);
            this.tblInput.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2ComboBox cboPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox cboState;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2CheckBox cbPayment;
        private Guna.UI2.WinForms.Guna2CheckBox cbDate;
        private Guna.UI2.WinForms.Guna2CheckBox cbEmployee;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
    }
}