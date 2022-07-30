namespace Doancsn
{
    partial class GUI_KhachHang
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnReset = new Doancsn.RJButton();
            this.btnAdd = new Doancsn.RJButton();
            this.dpkNgaySinh = new RJDatePicker();
            this.btnNu = new Doancsn.RJRadioButton();
            this.btnNam = new Doancsn.RJRadioButton();
            this.txtCCCD = new Doancsn.RJTextBox();
            this.txtTenkh = new Doancsn.RJTextBox();
            this.txtMaKH = new Doancsn.RJTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 112);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 13);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 174);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 13);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 240);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 13);
            label3.TabIndex = 0;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 305);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 13);
            label4.TabIndex = 0;
            label4.Text = "CCCD/CMND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 358);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 13);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh";
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Controls.Add(this.iconPictureBox1);
            this.panelThem.Controls.Add(this.btnReset);
            this.panelThem.Controls.Add(this.btnAdd);
            this.panelThem.Controls.Add(this.dpkNgaySinh);
            this.panelThem.Controls.Add(this.btnNu);
            this.panelThem.Controls.Add(this.btnNam);
            this.panelThem.Controls.Add(this.txtCCCD);
            this.panelThem.Controls.Add(this.txtTenkh);
            this.panelThem.Controls.Add(this.txtMaKH);
            this.panelThem.Controls.Add(label5);
            this.panelThem.Controls.Add(label4);
            this.panelThem.Controls.Add(label3);
            this.panelThem.Controls.Add(label2);
            this.panelThem.Controls.Add(label1);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(310, 453);
            this.panelThem.TabIndex = 0;
            this.panelThem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelThem_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 26;
            this.btnClose.Location = new System.Drawing.Point(273, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.Color.BlueViolet;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(102, 10);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(111, 78);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.BlueViolet;
            this.btnReset.BgColor = System.Drawing.Color.BlueViolet;
            this.btnReset.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnReset.BorderRadius = 8;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(176, 402);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm lại";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.BgColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.BorderRadius = 8;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 402);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dpkNgaySinh
            // 
            this.dpkNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpkNgaySinh.BorderSize = 0;
            this.dpkNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgaySinh.Location = new System.Drawing.Point(112, 356);
            this.dpkNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpkNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.Size = new System.Drawing.Size(188, 35);
            this.dpkNgaySinh.SkinColor = System.Drawing.Color.BlueViolet;
            this.dpkNgaySinh.TabIndex = 3;
            this.dpkNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // btnNu
            // 
            this.btnNu.AccessibleDescription = "";
            this.btnNu.AutoSize = true;
            this.btnNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNu.Location = new System.Drawing.Point(206, 236);
            this.btnNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNu.MinimumSize = new System.Drawing.Size(0, 17);
            this.btnNu.Name = "btnNu";
            this.btnNu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNu.Size = new System.Drawing.Size(47, 17);
            this.btnNu.TabIndex = 2;
            this.btnNu.TabStop = true;
            this.btnNu.Text = "Nữ";
            this.btnNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnNu.UseVisualStyleBackColor = true;
            // 
            // btnNam
            // 
            this.btnNam.AutoSize = true;
            this.btnNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNam.Location = new System.Drawing.Point(122, 240);
            this.btnNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNam.MinimumSize = new System.Drawing.Size(0, 17);
            this.btnNam.Name = "btnNam";
            this.btnNam.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNam.Size = new System.Drawing.Size(55, 17);
            this.btnNam.TabIndex = 2;
            this.btnNam.TabStop = true;
            this.btnNam.Text = "Nam";
            this.btnNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.SystemColors.Window;
            this.txtCCCD.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtCCCD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCCCD.BorderRadius = 8;
            this.txtCCCD.BorderSize = 2;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCCCD.Location = new System.Drawing.Point(112, 297);
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCCCD.PlaceholderText = "CCCD/CMND";
            this.txtCCCD.Size = new System.Drawing.Size(188, 29);
            this.txtCCCD.TabIndex = 2;
            this.txtCCCD.Texts = "";
            this.txtCCCD.UnderlinedStyle = false;
            // 
            // txtTenkh
            // 
            this.txtTenkh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenkh.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtTenkh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenkh.BorderRadius = 8;
            this.txtTenkh.BorderSize = 2;
            this.txtTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenkh.Location = new System.Drawing.Point(112, 166);
            this.txtTenkh.Multiline = false;
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtTenkh.PasswordChar = false;
            this.txtTenkh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenkh.PlaceholderText = "Tên khách hàng";
            this.txtTenkh.Size = new System.Drawing.Size(188, 29);
            this.txtTenkh.TabIndex = 1;
            this.txtTenkh.Texts = "";
            this.txtTenkh.UnderlinedStyle = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKH.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtMaKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKH.BorderRadius = 8;
            this.txtMaKH.BorderSize = 2;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKH.Location = new System.Drawing.Point(112, 104);
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtMaKH.PasswordChar = false;
            this.txtMaKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKH.PlaceholderText = "Mã khách hàng";
            this.txtMaKH.Size = new System.Drawing.Size(101, 29);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.Texts = "";
            this.txtMaKH.UnderlinedStyle = false;
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 453);
            this.Controls.Add(this.panelThem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_KhachHang";
            this.Text = "P";
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private RJTextBox txtMaKH;
        private RJDatePicker dpkNgaySinh;
        private RJRadioButton btnNu;
        private RJRadioButton btnNam;
        private RJTextBox txtCCCD;
        private RJTextBox txtTenkh;
        private RJButton btnAdd;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private RJButton btnReset;
    }
}