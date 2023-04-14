namespace GUI
{
    partial class Welcome
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptb_login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.ptb_close = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GUI.Properties.Resources.mF_icBackground;
            this.pictureBox2.Location = new System.Drawing.Point(0, -6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2000, 1046);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.mF_titleBackground;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(125, 95);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1837, 945);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // ptb_login
            // 
            this.ptb_login.BackColor = System.Drawing.Color.Transparent;
            this.ptb_login.Image = global::GUI.Properties.Resources.icUser;
            this.ptb_login.ImageRotate = 0F;
            this.ptb_login.Location = new System.Drawing.Point(0, 9);
            this.ptb_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_login.Name = "ptb_login";
            this.ptb_login.Size = new System.Drawing.Size(93, 49);
            this.ptb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_login.TabIndex = 5;
            this.ptb_login.TabStop = false;
            this.ptb_login.UseTransparentBackground = true;
            this.ptb_login.Click += new System.EventHandler(this.ptb_login_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(84, 20);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(111, 31);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "LOG IN";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
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
            this.ptb_close.TabIndex = 8;
            this.ptb_close.TabStop = false;
            this.ptb_close.UseTransparentBackground = true;
            this.ptb_close.Click += new System.EventHandler(this.ptb_close_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.mF_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 985);
            this.Controls.Add(this.ptb_close);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.ptb_login);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_login;
        private System.Windows.Forms.Label lbl_login;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_close;
    }
}

