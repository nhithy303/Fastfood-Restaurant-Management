namespace GUI
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_admin = new System.Windows.Forms.RadioButton();
            this.rdb_employee = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_signin = new Guna.UI2.WinForms.Guna2Button();
            this.txtb_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptb_close = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIGN IN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // rdb_admin
            // 
            this.rdb_admin.AutoSize = true;
            this.rdb_admin.BackColor = System.Drawing.Color.Transparent;
            this.rdb_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdb_admin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_admin.Location = new System.Drawing.Point(817, 614);
            this.rdb_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_admin.Name = "rdb_admin";
            this.rdb_admin.Size = new System.Drawing.Size(97, 31);
            this.rdb_admin.TabIndex = 7;
            this.rdb_admin.TabStop = true;
            this.rdb_admin.Text = "Admin";
            this.rdb_admin.UseVisualStyleBackColor = false;
            // 
            // rdb_employee
            // 
            this.rdb_employee.AutoSize = true;
            this.rdb_employee.BackColor = System.Drawing.Color.Transparent;
            this.rdb_employee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_employee.Location = new System.Drawing.Point(1036, 614);
            this.rdb_employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_employee.Name = "rdb_employee";
            this.rdb_employee.Size = new System.Drawing.Size(130, 31);
            this.rdb_employee.TabIndex = 8;
            this.rdb_employee.TabStop = true;
            this.rdb_employee.Text = "Employee";
            this.rdb_employee.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 439);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // bnt_signin
            // 
            this.bnt_signin.BackColor = System.Drawing.Color.Transparent;
            this.bnt_signin.BorderColor = System.Drawing.Color.Transparent;
            this.bnt_signin.BorderRadius = 10;
            this.bnt_signin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bnt_signin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bnt_signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bnt_signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bnt_signin.FillColor = System.Drawing.Color.Black;
            this.bnt_signin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_signin.ForeColor = System.Drawing.Color.White;
            this.bnt_signin.Location = new System.Drawing.Point(629, 688);
            this.bnt_signin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_signin.Name = "bnt_signin";
            this.bnt_signin.Size = new System.Drawing.Size(737, 55);
            this.bnt_signin.TabIndex = 15;
            this.bnt_signin.Text = "LOG IN";
            // 
            // txtb_user
            // 
            this.txtb_user.BackColor = System.Drawing.Color.Transparent;
            this.txtb_user.BorderColor = System.Drawing.Color.Black;
            this.txtb_user.BorderRadius = 10;
            this.txtb_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_user.DefaultText = "";
            this.txtb_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtb_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_user.Location = new System.Drawing.Point(629, 316);
            this.txtb_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_user.Name = "txtb_user";
            this.txtb_user.PasswordChar = '\0';
            this.txtb_user.PlaceholderText = "";
            this.txtb_user.SelectedText = "";
            this.txtb_user.Size = new System.Drawing.Size(737, 78);
            this.txtb_user.TabIndex = 16;
            // 
            // txtb_pass
            // 
            this.txtb_pass.BackColor = System.Drawing.Color.Transparent;
            this.txtb_pass.BorderColor = System.Drawing.Color.Black;
            this.txtb_pass.BorderRadius = 10;
            this.txtb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_pass.DefaultText = "";
            this.txtb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtb_pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtb_pass.Location = new System.Drawing.Point(629, 484);
            this.txtb_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.PasswordChar = '\0';
            this.txtb_pass.PlaceholderText = "";
            this.txtb_pass.SelectedText = "";
            this.txtb_pass.Size = new System.Drawing.Size(737, 78);
            this.txtb_pass.TabIndex = 17;
            // 
            // ptb_close
            // 
            this.ptb_close.BackColor = System.Drawing.Color.Transparent;
            this.ptb_close.Image = global::GUI.Properties.Resources.iconX;
            this.ptb_close.ImageRotate = 0F;
            this.ptb_close.Location = new System.Drawing.Point(1887, -15);
            this.ptb_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_close.Name = "ptb_close";
            this.ptb_close.Size = new System.Drawing.Size(180, 80);
            this.ptb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_close.TabIndex = 18;
            this.ptb_close.TabStop = false;
            this.ptb_close.UseTransparentBackground = true;
            this.ptb_close.Click += new System.EventHandler(this.ptb_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.Login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.Controls.Add(this.ptb_close);
            this.Controls.Add(this.txtb_pass);
            this.Controls.Add(this.txtb_user);
            this.Controls.Add(this.bnt_signin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_employee);
            this.Controls.Add(this.rdb_admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_admin;
        private System.Windows.Forms.RadioButton rdb_employee;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button bnt_signin;
        private Guna.UI2.WinForms.Guna2TextBox txtb_user;
        private Guna.UI2.WinForms.Guna2TextBox txtb_pass;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_close;
    }
}