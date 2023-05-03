namespace GUI.Employee
{
    partial class frmOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            this.dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cboPayment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.tblInput = new System.Windows.Forms.TableLayoutPanel();
            this.tblInput2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblInput1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.tblInput2.SuspendLayout();
            this.tblInput1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeight = 40;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(3, 350);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1340, 421);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrder.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvOrder.ThemeStyle.ReadOnly = true;
            this.dgvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrder.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnUpdate.Location = new System.Drawing.Point(427, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "Sửa";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnSave.Location = new System.Drawing.Point(762, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Lưu";
            // 
            // cboPayment
            // 
            this.cboPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cboPayment.Location = new System.Drawing.Point(341, 16);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(250, 36);
            this.cboPayment.TabIndex = 84;
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
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(1070, 18);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 78;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.txtID.Location = new System.Drawing.Point(226, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = true;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(80, 32);
            this.txtID.TabIndex = 76;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(1097, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Xóa";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnDetail.Location = new System.Drawing.Point(92, 15);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(150, 40);
            this.btnDetail.TabIndex = 87;
            this.btnDetail.Text = "Chi tiết";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.BorderRadius = 5;
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Enabled = false;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(642, 16);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 36);
            this.dtpDate.TabIndex = 88;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDate.Value = new System.DateTime(2023, 5, 2, 9, 59, 16, 605);
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
            this.cboState.Location = new System.Drawing.Point(935, 16);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(250, 36);
            this.cboState.TabIndex = 91;
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.dgvOrder, 0, 3);
            this.tblMain.Controls.Add(this.tblButton, 0, 2);
            this.tblMain.Controls.Add(this.tblInput, 0, 1);
            this.tblMain.Controls.Add(this.label1, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblMain.Size = new System.Drawing.Size(1346, 774);
            this.tblMain.TabIndex = 92;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 4;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.Controls.Add(this.btnDetail, 0, 0);
            this.tblButton.Controls.Add(this.btnUpdate, 1, 0);
            this.tblButton.Controls.Add(this.btnSave, 2, 0);
            this.tblButton.Controls.Add(this.btnDelete, 3, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(3, 273);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.Size = new System.Drawing.Size(1340, 71);
            this.tblButton.TabIndex = 72;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 1;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInput.Controls.Add(this.tblInput2, 0, 1);
            this.tblInput.Controls.Add(this.tblInput1, 0, 0);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput.Location = new System.Drawing.Point(3, 119);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 2;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.Size = new System.Drawing.Size(1340, 148);
            this.tblInput.TabIndex = 73;
            // 
            // tblInput2
            // 
            this.tblInput2.ColumnCount = 4;
            this.tblInput2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInput2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInput2.Controls.Add(this.label6, 2, 0);
            this.tblInput2.Controls.Add(this.label5, 0, 0);
            this.tblInput2.Controls.Add(this.cboState, 3, 0);
            this.tblInput2.Controls.Add(this.cboPayment, 1, 0);
            this.tblInput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput2.Location = new System.Drawing.Point(3, 77);
            this.tblInput2.Name = "tblInput2";
            this.tblInput2.RowCount = 1;
            this.tblInput2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInput2.Size = new System.Drawing.Size(1334, 68);
            this.tblInput2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 93;
            this.label6.Text = "Trạng thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "Thanh toán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblInput1
            // 
            this.tblInput1.ColumnCount = 6;
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblInput1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput1.Controls.Add(this.label4, 4, 0);
            this.tblInput1.Controls.Add(this.label3, 2, 0);
            this.tblInput1.Controls.Add(this.txtTotal, 5, 0);
            this.tblInput1.Controls.Add(this.txtID, 1, 0);
            this.tblInput1.Controls.Add(this.dtpDate, 3, 0);
            this.tblInput1.Controls.Add(this.label2, 0, 0);
            this.tblInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput1.Location = new System.Drawing.Point(3, 3);
            this.tblInput1.Name = "tblInput1";
            this.tblInput1.RowCount = 1;
            this.tblInput1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInput1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblInput1.Size = new System.Drawing.Size(1334, 68);
            this.tblInput1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(917, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 92;
            this.label4.Text = "Tổng tiền";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Ngày hóa đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "Mã hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 76);
            this.label1.TabIndex = 74;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 774);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblInput.ResumeLayout(false);
            this.tblInput2.ResumeLayout(false);
            this.tblInput2.PerformLayout();
            this.tblInput1.ResumeLayout(false);
            this.tblInput1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cboPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboState;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.TableLayoutPanel tblInput;
        private System.Windows.Forms.TableLayoutPanel tblInput2;
        private System.Windows.Forms.TableLayoutPanel tblInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}