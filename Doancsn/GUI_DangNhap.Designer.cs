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
            this.txtUserName = new Doancsn.RJTextBox();
            this.txtPass = new Doancsn.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.iconButtonClose.TabIndex = 4;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // cbxSaveInfo
            // 
            this.cbxSaveInfo.AutoSize = true;
            this.cbxSaveInfo.ForeColor = System.Drawing.Color.White;
            this.cbxSaveInfo.Location = new System.Drawing.Point(65, 366);
            this.cbxSaveInfo.Name = "cbxSaveInfo";
            this.cbxSaveInfo.Size = new System.Drawing.Size(102, 20);
            this.cbxSaveInfo.TabIndex = 3;
            this.cbxSaveInfo.Text = "Lưu thông tin";
            this.cbxSaveInfo.UseVisualStyleBackColor = true;
            this.cbxSaveInfo.CheckedChanged += new System.EventHandler(this.cbxSaveInfo_CheckedChanged);
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
            this.btnLogin.Location = new System.Drawing.Point(65, 440);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtUserName.BorderColor = System.Drawing.Color.White;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(65, 232);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.Size = new System.Drawing.Size(300, 35);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtPass.BorderColor = System.Drawing.Color.White;
            this.txtPass.BorderFocusColor = System.Drawing.Color.Gold;
            this.txtPass.BorderRadius = 10;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(65, 308);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = true;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.Size = new System.Drawing.Size(300, 35);
            this.txtPass.TabIndex = 1;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(424, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBoxLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxSaveInfo);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.paneltileClose);
            this.Name = "GUI_DangNhap";
            this.Text = "GUI_DangNhap";
            this.Load += new System.EventHandler(this.GUI_DangNhap_Load);
            this.paneltileClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltileClose;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private RJTextBox txtPass;
        private RJTextBox txtUserName;
        private System.Windows.Forms.CheckBox cbxSaveInfo;
        private RJButton btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}