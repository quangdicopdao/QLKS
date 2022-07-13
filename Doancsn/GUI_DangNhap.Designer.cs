namespace Doancsn
{
    partial class GUI_DangNhap
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
            this.paneltileClose = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.cbxSaveInfo = new System.Windows.Forms.CheckBox();
            this.iconPictureBoxLogin = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogin = new Doancsn.RJButton();
            this.rjTextBox2 = new Doancsn.RJTextBox();
            this.rjTextBox1 = new Doancsn.RJTextBox();
            this.paneltileClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltileClose
            // 
            this.paneltileClose.Controls.Add(this.iconButtonClose);
            this.paneltileClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltileClose.Location = new System.Drawing.Point(0, 0);
            this.paneltileClose.Name = "paneltileClose";
            this.paneltileClose.Size = new System.Drawing.Size(424, 43);
            this.paneltileClose.TabIndex = 0;
            this.paneltileClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltileClose_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.Location = new System.Drawing.Point(373, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(54, 37);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // cbxSaveInfo
            // 
            this.cbxSaveInfo.AutoSize = true;
            this.cbxSaveInfo.ForeColor = System.Drawing.Color.White;
            this.cbxSaveInfo.Location = new System.Drawing.Point(65, 355);
            this.cbxSaveInfo.Name = "cbxSaveInfo";
            this.cbxSaveInfo.Size = new System.Drawing.Size(102, 20);
            this.cbxSaveInfo.TabIndex = 3;
            this.cbxSaveInfo.Text = "Lưu thông tin";
            this.cbxSaveInfo.UseVisualStyleBackColor = true;
            // 
            // iconPictureBoxLogin
            // 
            this.iconPictureBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBoxLogin.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconPictureBoxLogin.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxLogin.IconSize = 122;
            this.iconPictureBoxLogin.Location = new System.Drawing.Point(142, 61);
            this.iconPictureBoxLogin.Name = "iconPictureBoxLogin";
            this.iconPictureBoxLogin.Size = new System.Drawing.Size(132, 122);
            this.iconPictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxLogin.TabIndex = 6;
            this.iconPictureBoxLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.BgColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(65, 429);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.Gold;
            this.rjTextBox2.BorderRadius = 10;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(65, 232);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.PlaceholderText = "Tên đăng nhập";
            this.rjTextBox2.Size = new System.Drawing.Size(300, 35);
            this.rjTextBox2.TabIndex = 0;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Gold;
            this.rjTextBox1.BorderRadius = 10;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(65, 297);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = true;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.PlaceholderText = "Mật khẩu";
            this.rjTextBox1.Size = new System.Drawing.Size(300, 35);
            this.rjTextBox1.TabIndex = 1;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(424, 549);
            this.Controls.Add(this.iconPictureBoxLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxSaveInfo);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.paneltileClose);
            this.Name = "GUI_DangNhap";
            this.Text = "GUI_DangNhap";
            this.paneltileClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltileClose;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private RJTextBox rjTextBox1;
        private RJTextBox rjTextBox2;
        private System.Windows.Forms.CheckBox cbxSaveInfo;
        private RJButton btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxLogin;
    }
}