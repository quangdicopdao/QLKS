namespace Doancsn
{
    partial class GUI_Phong
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
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnReset = new Doancsn.RJButton();
            this.btnAdd = new Doancsn.RJButton();
            this.cboLoaiPhong = new Doancsn.RJComboBox();
            this.cboTrangThai = new Doancsn.RJComboBox();
            this.cboMaks = new Doancsn.RJComboBox();
            this.txtDonGia = new Doancsn.RJTextBox();
            this.txtMaphong = new Doancsn.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThem
            // 
            this.panelThem.BackColor = System.Drawing.Color.White;
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Controls.Add(this.iconPictureBox1);
            this.panelThem.Controls.Add(this.btnReset);
            this.panelThem.Controls.Add(this.btnAdd);
            this.panelThem.Controls.Add(this.cboLoaiPhong);
            this.panelThem.Controls.Add(this.cboTrangThai);
            this.panelThem.Controls.Add(this.cboMaks);
            this.panelThem.Controls.Add(this.txtDonGia);
            this.panelThem.Controls.Add(this.txtMaphong);
            this.panelThem.Controls.Add(this.label5);
            this.panelThem.Controls.Add(this.label4);
            this.panelThem.Controls.Add(this.label3);
            this.panelThem.Controls.Add(this.label2);
            this.panelThem.Controls.Add(this.label1);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(413, 526);
            this.panelThem.TabIndex = 0;
            this.panelThem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelThem_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(357, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Pink;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Pink;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 99;
            this.iconPictureBox1.Location = new System.Drawing.Point(123, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(155, 99);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Pink;
            this.btnReset.BgColor = System.Drawing.Color.Pink;
            this.btnReset.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(229, 463);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 46);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Làm lại";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.BgColor = System.Drawing.Color.Pink;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.BackColor = System.Drawing.Color.White;
            this.cboLoaiPhong.BorderColor = System.Drawing.Color.Pink;
            this.cboLoaiPhong.BorderSize = 1;
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLoaiPhong.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaiPhong.IconColor = System.Drawing.Color.Pink;
            this.cboLoaiPhong.Items.AddRange(new object[] {
            "ĐƠN",
            "ĐÔI"});
            this.cboLoaiPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiPhong.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiPhong.Location = new System.Drawing.Point(167, 201);
            this.cboLoaiPhong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiPhong.Size = new System.Drawing.Size(200, 42);
            this.cboLoaiPhong.TabIndex = 1;
            this.cboLoaiPhong.Texts = "";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.White;
            this.cboTrangThai.BorderColor = System.Drawing.Color.Pink;
            this.cboTrangThai.BorderSize = 1;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.cboTrangThai.IconColor = System.Drawing.Color.Pink;
            this.cboTrangThai.Items.AddRange(new object[] {
            "ĐÃ ĐẶT",
            "CHƯA ĐẶT"});
            this.cboTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTrangThai.Location = new System.Drawing.Point(167, 337);
            this.cboTrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Padding = new System.Windows.Forms.Padding(1);
            this.cboTrangThai.Size = new System.Drawing.Size(200, 38);
            this.cboTrangThai.TabIndex = 3;
            this.cboTrangThai.Texts = "CHƯA ĐẶT";
            // 
            // cboMaks
            // 
            this.cboMaks.BackColor = System.Drawing.Color.White;
            this.cboMaks.BorderColor = System.Drawing.Color.Pink;
            this.cboMaks.BorderSize = 1;
            this.cboMaks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaks.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaks.IconColor = System.Drawing.Color.Pink;
            this.cboMaks.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaks.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaks.Location = new System.Drawing.Point(167, 399);
            this.cboMaks.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaks.Name = "cboMaks";
            this.cboMaks.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaks.Size = new System.Drawing.Size(200, 38);
            this.cboMaks.TabIndex = 4;
            this.cboMaks.Texts = "";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.Pink;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDonGia.BorderRadius = 8;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.Location = new System.Drawing.Point(167, 271);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "Đơn giá";
            this.txtDonGia.Size = new System.Drawing.Size(200, 35);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // txtMaphong
            // 
            this.txtMaphong.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaphong.BorderColor = System.Drawing.Color.Pink;
            this.txtMaphong.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtMaphong.BorderRadius = 8;
            this.txtMaphong.BorderSize = 2;
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaphong.Location = new System.Drawing.Point(167, 133);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Multiline = false;
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaphong.PasswordChar = false;
            this.txtMaphong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaphong.PlaceholderText = "Mã phòng";
            this.txtMaphong.Size = new System.Drawing.Size(98, 35);
            this.txtMaphong.TabIndex = 0;
            this.txtMaphong.Texts = "";
            this.txtMaphong.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khách sạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // GUI_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 526);
            this.Controls.Add(this.panelThem);
            this.Name = "GUI_Phong";
            this.Text = "P";
            this.Load += new System.EventHandler(this.GUI_Phong_Load);
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private RJButton btnAdd;
        private RJComboBox cboMaks;
        private RJTextBox txtMaphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private RJComboBox cboLoaiPhong;
        private RJComboBox cboTrangThai;
        private RJTextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJButton btnReset;
    }
}