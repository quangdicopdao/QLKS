namespace Doancsn
{
    partial class GUI_SuaKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMakh = new Doancsn.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenkh = new Doancsn.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCCCD = new Doancsn.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new Doancsn.RJButton();
            this.btnNam = new Doancsn.RJRadioButton();
            this.btnNu = new Doancsn.RJRadioButton();
            this.dpkNgaysinh = new RJDatePicker();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(478, 36);
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
            this.btnClose.Location = new System.Drawing.Point(432, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtMakh
            // 
            this.txtMakh.BackColor = System.Drawing.SystemColors.Window;
            this.txtMakh.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtMakh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMakh.BorderRadius = 8;
            this.txtMakh.BorderSize = 2;
            this.txtMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMakh.Location = new System.Drawing.Point(169, 63);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakh.Multiline = false;
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMakh.PasswordChar = false;
            this.txtMakh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMakh.PlaceholderText = "";
            this.txtMakh.Size = new System.Drawing.Size(122, 35);
            this.txtMakh.TabIndex = 2;
            this.txtMakh.Texts = "";
            this.txtMakh.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
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
            this.txtTenkh.Location = new System.Drawing.Point(169, 121);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkh.Multiline = false;
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenkh.PasswordChar = false;
            this.txtTenkh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenkh.PlaceholderText = "";
            this.txtTenkh.Size = new System.Drawing.Size(250, 35);
            this.txtTenkh.TabIndex = 2;
            this.txtTenkh.Texts = "";
            this.txtTenkh.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "CCCD/CMND";
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
            this.txtCCCD.Location = new System.Drawing.Point(169, 236);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Multiline = false;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.Size = new System.Drawing.Size(209, 35);
            this.txtCCCD.TabIndex = 2;
            this.txtCCCD.Texts = "";
            this.txtCCCD.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSave.BgColor = System.Drawing.Color.BlueViolet;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(318, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNam
            // 
            this.btnNam.AutoSize = true;
            this.btnNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNam.Location = new System.Drawing.Point(179, 183);
            this.btnNam.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnNam.Name = "btnNam";
            this.btnNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNam.Size = new System.Drawing.Size(67, 21);
            this.btnNam.TabIndex = 4;
            this.btnNam.TabStop = true;
            this.btnNam.Text = "Nam";
            this.btnNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnNu
            // 
            this.btnNu.AutoSize = true;
            this.btnNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNu.Location = new System.Drawing.Point(278, 183);
            this.btnNu.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnNu.Name = "btnNu";
            this.btnNu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNu.Size = new System.Drawing.Size(55, 21);
            this.btnNu.TabIndex = 4;
            this.btnNu.TabStop = true;
            this.btnNu.Text = "Nữ";
            this.btnNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnNu.UseVisualStyleBackColor = true;
            // 
            // dpkNgaysinh
            // 
            this.dpkNgaysinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpkNgaysinh.BorderSize = 0;
            this.dpkNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpkNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgaysinh.Location = new System.Drawing.Point(169, 291);
            this.dpkNgaysinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpkNgaysinh.Name = "dpkNgaysinh";
            this.dpkNgaysinh.Size = new System.Drawing.Size(200, 35);
            this.dpkNgaysinh.SkinColor = System.Drawing.Color.BlueViolet;
            this.dpkNgaysinh.TabIndex = 5;
            this.dpkNgaysinh.TextColor = System.Drawing.Color.White;
            // 
            // GUI_SuaKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 422);
            this.Controls.Add(this.dpkNgaysinh);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelThem);
            this.Name = "GUI_SuaKH";
            this.Text = "GUI_SuaKH";
            this.Load += new System.EventHandler(this.GUI_SuaKH_Load);
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtMakh;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label label2;
        private RJTextBox txtTenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJTextBox txtCCCD;
        private System.Windows.Forms.Label label5;
        private RJButton btnSave;
        private RJRadioButton btnNam;
        private RJRadioButton btnNu;
        private RJDatePicker dpkNgaysinh;
    }
}