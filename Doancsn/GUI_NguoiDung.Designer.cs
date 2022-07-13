namespace Doancsn
{
    partial class GUI_NguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NguoiDung));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonFind = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccountUser = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExits = new FontAwesome.Sharp.IconButton();
            this.panelKS = new System.Windows.Forms.Panel();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.picboxHome = new RJCircularPictureBox();
            this.rjTextBox1 = new Doancsn.RJTextBox();
            this.cboArea = new Doancsn.RJComboBox();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.picboxHome);
            this.panelMenu.Controls.Add(this.iconButtonFind);
            this.panelMenu.Controls.Add(this.rjTextBox1);
            this.panelMenu.Controls.Add(this.cboArea);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnAccountUser);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(331, 845);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonFind
            // 
            this.iconButtonFind.FlatAppearance.BorderSize = 0;
            this.iconButtonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFind.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButtonFind.IconColor = System.Drawing.Color.White;
            this.iconButtonFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFind.IconSize = 35;
            this.iconButtonFind.Location = new System.Drawing.Point(270, 345);
            this.iconButtonFind.Name = "iconButtonFind";
            this.iconButtonFind.Size = new System.Drawing.Size(51, 35);
            this.iconButtonFind.TabIndex = 7;
            this.iconButtonFind.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khu vực";
            // 
            // btnAccountUser
            // 
            this.btnAccountUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccountUser.FlatAppearance.BorderSize = 0;
            this.btnAccountUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountUser.ForeColor = System.Drawing.Color.White;
            this.btnAccountUser.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnAccountUser.IconColor = System.Drawing.Color.White;
            this.btnAccountUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountUser.Location = new System.Drawing.Point(0, 703);
            this.btnAccountUser.Name = "btnAccountUser";
            this.btnAccountUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAccountUser.Size = new System.Drawing.Size(331, 71);
            this.btnAccountUser.TabIndex = 4;
            this.btnAccountUser.Text = "Đổi mật khẩu";
            this.btnAccountUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountUser.UseVisualStyleBackColor = true;
            this.btnAccountUser.Click += new System.EventHandler(this.btnAccountUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 774);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(331, 71);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnExits);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(331, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(937, 46);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(787, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(838, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 30);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExits
            // 
            this.btnExits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExits.FlatAppearance.BorderSize = 0;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExits.IconColor = System.Drawing.Color.Black;
            this.btnExits.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExits.IconSize = 30;
            this.btnExits.Location = new System.Drawing.Point(889, 3);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(45, 30);
            this.btnExits.TabIndex = 0;
            this.btnExits.UseVisualStyleBackColor = true;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // panelKS
            // 
            this.panelKS.BackColor = System.Drawing.Color.White;
            this.panelKS.Controls.Add(this.lblKhuVuc);
            this.panelKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKS.Location = new System.Drawing.Point(331, 46);
            this.panelKS.Name = "panelKS";
            this.panelKS.Size = new System.Drawing.Size(937, 799);
            this.panelKS.TabIndex = 2;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhuVuc.Location = new System.Drawing.Point(6, 16);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(91, 25);
            this.lblKhuVuc.TabIndex = 0;
            this.lblKhuVuc.Text = "Khu vực";
            // 
            // picboxHome
            // 
            this.picboxHome.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picboxHome.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picboxHome.BorderColor2 = System.Drawing.Color.HotPink;
            this.picboxHome.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picboxHome.BorderSize = 2;
            this.picboxHome.GradientAngle = 50F;
            this.picboxHome.Image = ((System.Drawing.Image)(resources.GetObject("picboxHome.Image")));
            this.picboxHome.Location = new System.Drawing.Point(53, 3);
            this.picboxHome.Name = "picboxHome";
            this.picboxHome.Size = new System.Drawing.Size(233, 233);
            this.picboxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxHome.TabIndex = 8;
            this.picboxHome.TabStop = false;
            this.picboxHome.Click += new System.EventHandler(this.picboxHome_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.rjTextBox1.BorderRadius = 8;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(13, 345);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.White;
            this.rjTextBox1.PlaceholderText = "Tìm khách sạn";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox1.TabIndex = 6;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // cboArea
            // 
            this.cboArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cboArea.BorderColor = System.Drawing.Color.White;
            this.cboArea.BorderSize = 1;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboArea.ForeColor = System.Drawing.Color.White;
            this.cboArea.IconColor = System.Drawing.Color.White;
            this.cboArea.Items.AddRange(new object[] {
            "Hiệp Thành",
            "Phú Lợi",
            "Phú Cường",
            "Phú Hòa",
            "Phú Thọ",
            "Chánh Nghĩa",
            "Định Hoà",
            "Hoà Phú",
            "Phú Mỹ",
            "Phú Tân",
            "Tân An",
            "Hiệp An",
            "Tương Bình Hiệp",
            "Chánh Mỹ"});
            this.cboArea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboArea.ListTextColor = System.Drawing.Color.DimGray;
            this.cboArea.Location = new System.Drawing.Point(17, 288);
            this.cboArea.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboArea.Name = "cboArea";
            this.cboArea.Padding = new System.Windows.Forms.Padding(1);
            this.cboArea.Size = new System.Drawing.Size(200, 30);
            this.cboArea.TabIndex = 5;
            this.cboArea.Texts = "";
            this.cboArea.OnSelectedIndexChanged += new System.EventHandler(this.cboArea_OnSelectedIndexChanged);
            // 
            // GUI_NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1268, 845);
            this.Controls.Add(this.panelKS);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "GUI_NguoiDung";
            this.Text = "GUI_User";
            this.Load += new System.EventHandler(this.GUI_NguoiDung_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelKS.ResumeLayout(false);
            this.panelKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExits;
        private System.Windows.Forms.Panel panelKS;
        private System.Windows.Forms.Label lblKhuVuc;
        private RJTextBox rjTextBox1;
        private RJComboBox cboArea;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonFind;
        private RJCircularPictureBox picboxHome;
        private FontAwesome.Sharp.IconButton btnAccountUser;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}