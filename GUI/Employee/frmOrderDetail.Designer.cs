namespace GUI
{
    partial class frmOrderDetail
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
            this.dgvOrderDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtUnitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.cboMenu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.tblInput = new System.Windows.Forms.TableLayoutPanel();
            this.tblTotal = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.tblInput.SuspendLayout();
            this.tblTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetail.ColumnHeadersHeight = 40;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderDetail.Location = new System.Drawing.Point(3, 240);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersVisible = false;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(976, 291);
            this.dgvOrderDetail.TabIndex = 49;
            this.dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrderDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrderDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrderDetail.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvOrderDetail.ThemeStyle.ReadOnly = false;
            this.dgvOrderDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrderDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrderDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(779, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Xóa";
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
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(535, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Lưu";
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
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(291, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "Sửa";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BorderRadius = 5;
            this.txtUnitPrice.BorderThickness = 0;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.DefaultText = "";
            this.txtUnitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(200, 69);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUnitPrice.PlaceholderText = "";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 31);
            this.txtUnitPrice.TabIndex = 65;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.BorderThickness = 1;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(47, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 55;
            this.btnCreate.Text = "Thêm";
            // 
            // cboMenu
            // 
            this.cboMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboMenu.AutoRoundedCorners = true;
            this.cboMenu.BackColor = System.Drawing.Color.Transparent;
            this.cboMenu.BorderRadius = 17;
            this.cboMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMenu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMenu.ForeColor = System.Drawing.Color.Black;
            this.cboMenu.ItemHeight = 30;
            this.cboMenu.Location = new System.Drawing.Point(198, 10);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(270, 36);
            this.cboMenu.TabIndex = 66;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.BorderRadius = 5;
            this.txtTotalPrice.BorderThickness = 0;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(687, 69);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 31);
            this.txtTotalPrice.TabIndex = 68;
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
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(688, 12);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(200, 31);
            this.txtTotal.TabIndex = 70;
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.BorderRadius = 5;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.numQuantity.Location = new System.Drawing.Point(685, 12);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 32);
            this.numQuantity.TabIndex = 71;
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.label1, 0, 0);
            this.tblMain.Controls.Add(this.dgvOrderDetail, 0, 3);
            this.tblMain.Controls.Add(this.tblButton, 0, 2);
            this.tblMain.Controls.Add(this.tblInput, 0, 1);
            this.tblMain.Controls.Add(this.tblTotal, 0, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMain.Size = new System.Drawing.Size(982, 595);
            this.tblMain.TabIndex = 72;
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 4;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblButton.Controls.Add(this.btnCreate, 0, 0);
            this.tblButton.Controls.Add(this.btnUpdate, 1, 0);
            this.tblButton.Controls.Add(this.btnSave, 2, 0);
            this.tblButton.Controls.Add(this.btnDelete, 3, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(3, 181);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButton.Size = new System.Drawing.Size(976, 53);
            this.tblButton.TabIndex = 56;
            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 4;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblInput.Controls.Add(this.label5, 2, 1);
            this.tblInput.Controls.Add(this.label4, 0, 1);
            this.tblInput.Controls.Add(this.label3, 2, 0);
            this.tblInput.Controls.Add(this.label2, 0, 0);
            this.tblInput.Controls.Add(this.numQuantity, 3, 0);
            this.tblInput.Controls.Add(this.cboMenu, 1, 0);
            this.tblInput.Controls.Add(this.txtTotalPrice, 3, 1);
            this.tblInput.Controls.Add(this.txtUnitPrice, 1, 1);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInput.Location = new System.Drawing.Point(3, 62);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 2;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInput.Size = new System.Drawing.Size(976, 113);
            this.tblInput.TabIndex = 57;
            // 
            // tblTotal
            // 
            this.tblTotal.ColumnCount = 2;
            this.tblTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblTotal.Controls.Add(this.label6, 0, 0);
            this.tblTotal.Controls.Add(this.txtTotal, 1, 0);
            this.tblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTotal.Location = new System.Drawing.Point(3, 537);
            this.tblTotal.Name = "tblTotal";
            this.tblTotal.RowCount = 1;
            this.tblTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTotal.Size = new System.Drawing.Size(976, 55);
            this.tblTotal.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 45);
            this.label1.TabIndex = 75;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên món";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 92;
            this.label3.Text = "Số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Thành tiền";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Tổng tiền";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 595);
            this.Controls.Add(this.tblMain);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tblInput.ResumeLayout(false);
            this.tblInput.PerformLayout();
            this.tblTotal.ResumeLayout(false);
            this.tblTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderDetail;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitPrice;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2ComboBox cboMenu;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.TableLayoutPanel tblInput;
        private System.Windows.Forms.TableLayoutPanel tblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}