namespace GUI.Admin
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tabSettings = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpEmployeeCategory = new System.Windows.Forms.TabPage();
            this.tpMenuCategory = new System.Windows.Forms.TabPage();
            this.tpUnit = new System.Windows.Forms.TabPage();
            this.tpOrderState = new System.Windows.Forms.TabPage();
            this.tpPaymentMethod = new System.Windows.Forms.TabPage();
            this.tblMenuCategory = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMenuCategoryBody = new System.Windows.Forms.TableLayoutPanel();
            this.tblMenuCategoryInput = new System.Windows.Forms.TableLayoutPanel();
            this.tblMenuCategoryButton = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenuCategoryID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateMenuCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateMenuCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveMenuCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMenuCategory = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMenuCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tblMain.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tpMenuCategory.SuspendLayout();
            this.tblMenuCategory.SuspendLayout();
            this.tblMenuCategoryBody.SuspendLayout();
            this.tblMenuCategoryInput.SuspendLayout();
            this.tblMenuCategoryButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.tabSettings, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1052, 604);
            this.tblMain.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabSettings.Controls.Add(this.tpGeneral);
            this.tabSettings.Controls.Add(this.tpUnit);
            this.tabSettings.Controls.Add(this.tpPaymentMethod);
            this.tabSettings.Controls.Add(this.tpEmployeeCategory);
            this.tabSettings.Controls.Add(this.tpMenuCategory);
            this.tabSettings.Controls.Add(this.tpOrderState);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.ItemSize = new System.Drawing.Size(180, 40);
            this.tabSettings.Location = new System.Drawing.Point(3, 3);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(1046, 598);
            this.tabSettings.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSettings.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabSettings.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabSettings.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSettings.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabSettings.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabSettings.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabSettings.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabSettings.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabSettings.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabSettings.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabSettings.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpGeneral.Location = new System.Drawing.Point(184, 4);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(858, 590);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Cài đặt chung";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeCategory
            // 
            this.tpEmployeeCategory.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpEmployeeCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpEmployeeCategory.Location = new System.Drawing.Point(184, 4);
            this.tpEmployeeCategory.Name = "tpEmployeeCategory";
            this.tpEmployeeCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeCategory.Size = new System.Drawing.Size(858, 590);
            this.tpEmployeeCategory.TabIndex = 1;
            this.tpEmployeeCategory.Text = "Phân loại nhân viên";
            this.tpEmployeeCategory.UseVisualStyleBackColor = true;
            // 
            // tpMenuCategory
            // 
            this.tpMenuCategory.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpMenuCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpMenuCategory.Controls.Add(this.tblMenuCategory);
            this.tpMenuCategory.Location = new System.Drawing.Point(184, 4);
            this.tpMenuCategory.Name = "tpMenuCategory";
            this.tpMenuCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenuCategory.Size = new System.Drawing.Size(858, 590);
            this.tpMenuCategory.TabIndex = 2;
            this.tpMenuCategory.Text = "Phân loại thực đơn";
            this.tpMenuCategory.UseVisualStyleBackColor = true;
            // 
            // tpUnit
            // 
            this.tpUnit.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpUnit.Location = new System.Drawing.Point(184, 4);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnit.Size = new System.Drawing.Size(858, 590);
            this.tpUnit.TabIndex = 3;
            this.tpUnit.Text = "Đơn vị tính";
            this.tpUnit.UseVisualStyleBackColor = true;
            // 
            // tpOrderState
            // 
            this.tpOrderState.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpOrderState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpOrderState.Location = new System.Drawing.Point(184, 4);
            this.tpOrderState.Name = "tpOrderState";
            this.tpOrderState.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderState.Size = new System.Drawing.Size(858, 590);
            this.tpOrderState.TabIndex = 4;
            this.tpOrderState.Text = "Trạng thái đơn hàng";
            this.tpOrderState.UseVisualStyleBackColor = true;
            // 
            // tpPaymentMethod
            // 
            this.tpPaymentMethod.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.tpPaymentMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpPaymentMethod.Location = new System.Drawing.Point(184, 4);
            this.tpPaymentMethod.Name = "tpPaymentMethod";
            this.tpPaymentMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaymentMethod.Size = new System.Drawing.Size(858, 590);
            this.tpPaymentMethod.TabIndex = 5;
            this.tpPaymentMethod.Text = "Hình thức thanh toán";
            this.tpPaymentMethod.UseVisualStyleBackColor = true;
            // 
            // tblMenuCategory
            // 
            this.tblMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.tblMenuCategory.ColumnCount = 1;
            this.tblMenuCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuCategory.Controls.Add(this.label1, 0, 0);
            this.tblMenuCategory.Controls.Add(this.tblMenuCategoryBody, 0, 1);
            this.tblMenuCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenuCategory.Location = new System.Drawing.Point(3, 3);
            this.tblMenuCategory.Name = "tblMenuCategory";
            this.tblMenuCategory.RowCount = 2;
            this.tblMenuCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMenuCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblMenuCategory.Size = new System.Drawing.Size(852, 584);
            this.tblMenuCategory.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 38);
            this.label1.TabIndex = 75;
            this.label1.Text = "PHÂN LOẠI THỰC ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblMenuCategoryBody
            // 
            this.tblMenuCategoryBody.ColumnCount = 1;
            this.tblMenuCategoryBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuCategoryBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenuCategoryBody.Controls.Add(this.dgvMenuCategory, 0, 2);
            this.tblMenuCategoryBody.Controls.Add(this.tblMenuCategoryInput, 0, 0);
            this.tblMenuCategoryBody.Controls.Add(this.tblMenuCategoryButton, 0, 1);
            this.tblMenuCategoryBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenuCategoryBody.Location = new System.Drawing.Point(3, 61);
            this.tblMenuCategoryBody.Name = "tblMenuCategoryBody";
            this.tblMenuCategoryBody.RowCount = 3;
            this.tblMenuCategoryBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMenuCategoryBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMenuCategoryBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMenuCategoryBody.Size = new System.Drawing.Size(846, 520);
            this.tblMenuCategoryBody.TabIndex = 76;
            // 
            // tblMenuCategoryInput
            // 
            this.tblMenuCategoryInput.ColumnCount = 4;
            this.tblMenuCategoryInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMenuCategoryInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMenuCategoryInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMenuCategoryInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenuCategoryInput.Controls.Add(this.label3, 0, 0);
            this.tblMenuCategoryInput.Controls.Add(this.txtMenuCategoryID, 0, 0);
            this.tblMenuCategoryInput.Controls.Add(this.label2, 0, 0);
            this.tblMenuCategoryInput.Controls.Add(this.txtMenuCategoryName, 3, 0);
            this.tblMenuCategoryInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenuCategoryInput.Location = new System.Drawing.Point(3, 3);
            this.tblMenuCategoryInput.Name = "tblMenuCategoryInput";
            this.tblMenuCategoryInput.RowCount = 1;
            this.tblMenuCategoryInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuCategoryInput.Size = new System.Drawing.Size(840, 72);
            this.tblMenuCategoryInput.TabIndex = 0;
            // 
            // tblMenuCategoryButton
            // 
            this.tblMenuCategoryButton.ColumnCount = 4;
            this.tblMenuCategoryButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenuCategoryButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenuCategoryButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenuCategoryButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenuCategoryButton.Controls.Add(this.btnSaveMenuCategory, 0, 0);
            this.tblMenuCategoryButton.Controls.Add(this.btnUpdateMenuCategory, 0, 0);
            this.tblMenuCategoryButton.Controls.Add(this.btnCreateMenuCategory, 0, 0);
            this.tblMenuCategoryButton.Controls.Add(this.btnDeleteMenuCategory, 3, 0);
            this.tblMenuCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenuCategoryButton.Location = new System.Drawing.Point(3, 81);
            this.tblMenuCategoryButton.Name = "tblMenuCategoryButton";
            this.tblMenuCategoryButton.RowCount = 1;
            this.tblMenuCategoryButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenuCategoryButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenuCategoryButton.Size = new System.Drawing.Size(840, 72);
            this.tblMenuCategoryButton.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mã loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMenuCategoryID
            // 
            this.txtMenuCategoryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.txtMenuCategoryID.BorderColor = System.Drawing.Color.Transparent;
            this.txtMenuCategoryID.BorderRadius = 5;
            this.txtMenuCategoryID.BorderThickness = 0;
            this.txtMenuCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMenuCategoryID.DefaultText = "";
            this.txtMenuCategoryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMenuCategoryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMenuCategoryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuCategoryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuCategoryID.Enabled = false;
            this.txtMenuCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuCategoryID.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtMenuCategoryID.ForeColor = System.Drawing.Color.Black;
            this.txtMenuCategoryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuCategoryID.Location = new System.Drawing.Point(173, 21);
            this.txtMenuCategoryID.Margin = new System.Windows.Forms.Padding(5);
            this.txtMenuCategoryID.Name = "txtMenuCategoryID";
            this.txtMenuCategoryID.PasswordChar = '\0';
            this.txtMenuCategoryID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMenuCategoryID.PlaceholderText = "";
            this.txtMenuCategoryID.ReadOnly = true;
            this.txtMenuCategoryID.SelectedText = "";
            this.txtMenuCategoryID.Size = new System.Drawing.Size(116, 30);
            this.txtMenuCategoryID.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tên loại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMenuCategoryName
            // 
            this.txtMenuCategoryName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMenuCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.txtMenuCategoryName.BorderColor = System.Drawing.Color.Transparent;
            this.txtMenuCategoryName.BorderRadius = 5;
            this.txtMenuCategoryName.BorderThickness = 0;
            this.txtMenuCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMenuCategoryName.DefaultText = "";
            this.txtMenuCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMenuCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMenuCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuCategoryName.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtMenuCategoryName.ForeColor = System.Drawing.Color.Black;
            this.txtMenuCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuCategoryName.Location = new System.Drawing.Point(425, 21);
            this.txtMenuCategoryName.Margin = new System.Windows.Forms.Padding(5);
            this.txtMenuCategoryName.Name = "txtMenuCategoryName";
            this.txtMenuCategoryName.PasswordChar = '\0';
            this.txtMenuCategoryName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMenuCategoryName.PlaceholderText = "";
            this.txtMenuCategoryName.SelectedText = "";
            this.txtMenuCategoryName.Size = new System.Drawing.Size(280, 30);
            this.txtMenuCategoryName.TabIndex = 95;
            // 
            // btnCreateMenuCategory
            // 
            this.btnCreateMenuCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateMenuCategory.BorderRadius = 5;
            this.btnCreateMenuCategory.BorderThickness = 1;
            this.btnCreateMenuCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateMenuCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateMenuCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateMenuCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateMenuCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateMenuCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnCreateMenuCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCreateMenuCategory.Location = new System.Drawing.Point(30, 16);
            this.btnCreateMenuCategory.Name = "btnCreateMenuCategory";
            this.btnCreateMenuCategory.Size = new System.Drawing.Size(150, 40);
            this.btnCreateMenuCategory.TabIndex = 37;
            this.btnCreateMenuCategory.Text = "Thêm";
            // 
            // btnUpdateMenuCategory
            // 
            this.btnUpdateMenuCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMenuCategory.BorderRadius = 5;
            this.btnUpdateMenuCategory.BorderThickness = 1;
            this.btnUpdateMenuCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateMenuCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateMenuCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateMenuCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateMenuCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateMenuCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnUpdateMenuCategory.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMenuCategory.Location = new System.Drawing.Point(240, 16);
            this.btnUpdateMenuCategory.Name = "btnUpdateMenuCategory";
            this.btnUpdateMenuCategory.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateMenuCategory.TabIndex = 38;
            this.btnUpdateMenuCategory.Text = "Sửa";
            // 
            // btnSaveMenuCategory
            // 
            this.btnSaveMenuCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveMenuCategory.BorderRadius = 5;
            this.btnSaveMenuCategory.BorderThickness = 1;
            this.btnSaveMenuCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMenuCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMenuCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveMenuCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveMenuCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveMenuCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSaveMenuCategory.ForeColor = System.Drawing.Color.Black;
            this.btnSaveMenuCategory.Location = new System.Drawing.Point(450, 16);
            this.btnSaveMenuCategory.Name = "btnSaveMenuCategory";
            this.btnSaveMenuCategory.Size = new System.Drawing.Size(150, 40);
            this.btnSaveMenuCategory.TabIndex = 40;
            this.btnSaveMenuCategory.Text = "Lưu";
            // 
            // btnDeleteMenuCategory
            // 
            this.btnDeleteMenuCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteMenuCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMenuCategory.BorderRadius = 5;
            this.btnDeleteMenuCategory.BorderThickness = 1;
            this.btnDeleteMenuCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMenuCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMenuCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMenuCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMenuCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteMenuCategory.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnDeleteMenuCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteMenuCategory.Location = new System.Drawing.Point(660, 16);
            this.btnDeleteMenuCategory.Name = "btnDeleteMenuCategory";
            this.btnDeleteMenuCategory.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteMenuCategory.TabIndex = 41;
            this.btnDeleteMenuCategory.Text = "Xóa";
            // 
            // dgvMenuCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMenuCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuCategory.ColumnHeadersHeight = 40;
            this.dgvMenuCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMenuCategory.Location = new System.Drawing.Point(3, 159);
            this.dgvMenuCategory.Name = "dgvMenuCategory";
            this.dgvMenuCategory.RowHeadersVisible = false;
            this.dgvMenuCategory.RowHeadersWidth = 51;
            this.dgvMenuCategory.RowTemplate.Height = 24;
            this.dgvMenuCategory.Size = new System.Drawing.Size(840, 358);
            this.dgvMenuCategory.TabIndex = 32;
            this.dgvMenuCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenuCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMenuCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMenuCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMenuCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMenuCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenuCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMenuCategory.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMenuCategory.ThemeStyle.ReadOnly = false;
            this.dgvMenuCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenuCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenuCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMenuCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMenuCategory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMenuCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMenuCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 604);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Cài đặt";
            this.tblMain.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tpMenuCategory.ResumeLayout(false);
            this.tblMenuCategory.ResumeLayout(false);
            this.tblMenuCategory.PerformLayout();
            this.tblMenuCategoryBody.ResumeLayout(false);
            this.tblMenuCategoryInput.ResumeLayout(false);
            this.tblMenuCategoryInput.PerformLayout();
            this.tblMenuCategoryButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private Guna.UI2.WinForms.Guna2TabControl tabSettings;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpEmployeeCategory;
        private System.Windows.Forms.TabPage tpMenuCategory;
        private System.Windows.Forms.TabPage tpUnit;
        private System.Windows.Forms.TabPage tpOrderState;
        private System.Windows.Forms.TabPage tpPaymentMethod;
        private System.Windows.Forms.TableLayoutPanel tblMenuCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblMenuCategoryBody;
        private System.Windows.Forms.TableLayoutPanel tblMenuCategoryInput;
        private System.Windows.Forms.TableLayoutPanel tblMenuCategoryButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMenuCategoryID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMenuCategoryName;
        private Guna.UI2.WinForms.Guna2Button btnCreateMenuCategory;
        private Guna.UI2.WinForms.Guna2Button btnUpdateMenuCategory;
        private Guna.UI2.WinForms.Guna2Button btnSaveMenuCategory;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMenuCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMenuCategory;
    }
}