namespace Doancsn
{
    partial class GUI_SuaNV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManv = new Doancsn.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTennv = new Doancsn.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new Doancsn.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Doancsn.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiachi = new Doancsn.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new Doancsn.RJButton();
            this.cboMaks = new Doancsn.RJComboBox();
            this.dpkNgaysinh = new RJDatePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 29;
            this.btnClose.Location = new System.Drawing.Point(425, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtManv
            // 
            this.txtManv.BackColor = System.Drawing.SystemColors.Window;
            this.txtManv.BorderColor = System.Drawing.Color.Turquoise;
            this.txtManv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtManv.BorderRadius = 8;
            this.txtManv.BorderSize = 2;
            this.txtManv.Enabled = false;
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtManv.Location = new System.Drawing.Point(147, 80);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4);
            this.txtManv.Multiline = false;
            this.txtManv.Name = "txtManv";
            this.txtManv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtManv.PasswordChar = false;
            this.txtManv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtManv.PlaceholderText = "";
            this.txtManv.Size = new System.Drawing.Size(141, 35);
            this.txtManv.TabIndex = 0;
            this.txtManv.Texts = "";
            this.txtManv.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTennv
            // 
            this.txtTennv.BackColor = System.Drawing.SystemColors.Window;
            this.txtTennv.BorderColor = System.Drawing.Color.Turquoise;
            this.txtTennv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTennv.BorderRadius = 8;
            this.txtTennv.BorderSize = 2;
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTennv.Location = new System.Drawing.Point(147, 143);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennv.Multiline = false;
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTennv.PasswordChar = false;
            this.txtTennv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTennv.PlaceholderText = "";
            this.txtTennv.Size = new System.Drawing.Size(250, 35);
            this.txtTennv.TabIndex = 1;
            this.txtTennv.Texts = "";
            this.txtTennv.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.Color.Turquoise;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 8;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(147, 205);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(178, 35);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.Turquoise;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(147, 270);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 35);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiachi.BorderColor = System.Drawing.Color.Turquoise;
            this.txtDiachi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiachi.BorderRadius = 8;
            this.txtDiachi.BorderSize = 2;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiachi.Location = new System.Drawing.Point(147, 391);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiachi.PasswordChar = false;
            this.txtDiachi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiachi.PlaceholderText = "";
            this.txtDiachi.Size = new System.Drawing.Size(250, 107);
            this.txtDiachi.TabIndex = 4;
            this.txtDiachi.Texts = "";
            this.txtDiachi.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã khách sạn";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.BgColor = System.Drawing.Color.Turquoise;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(343, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboMaks
            // 
            this.cboMaks.BackColor = System.Drawing.Color.White;
            this.cboMaks.BorderColor = System.Drawing.Color.Turquoise;
            this.cboMaks.BorderSize = 1;
            this.cboMaks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaks.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaks.IconColor = System.Drawing.Color.Turquoise;
            this.cboMaks.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaks.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaks.Location = new System.Drawing.Point(147, 520);
            this.cboMaks.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaks.Name = "cboMaks";
            this.cboMaks.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaks.Size = new System.Drawing.Size(200, 37);
            this.cboMaks.TabIndex = 5;
            this.cboMaks.Texts = "";
            // 
            // dpkNgaysinh
            // 
            this.dpkNgaysinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpkNgaysinh.BorderSize = 0;
            this.dpkNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpkNgaysinh.Location = new System.Drawing.Point(147, 330);
            this.dpkNgaysinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpkNgaysinh.Name = "dpkNgaysinh";
            this.dpkNgaysinh.Size = new System.Drawing.Size(200, 35);
            this.dpkNgaysinh.SkinColor = System.Drawing.Color.Turquoise;
            this.dpkNgaysinh.TabIndex = 5;
            this.dpkNgaysinh.TextColor = System.Drawing.Color.White;
            // 
            // GUI_SuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 661);
            this.Controls.Add(this.dpkNgaysinh);
            this.Controls.Add(this.cboMaks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_SuaNV";
            this.Text = "GUI_SuaNV";
            this.Load += new System.EventHandler(this.GUI_SuaNV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtManv;
        private System.Windows.Forms.Label label2;
        private RJTextBox txtTennv;
        private System.Windows.Forms.Label label3;
        private RJTextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private RJTextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RJTextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private RJButton btnSave;
        private RJComboBox cboMaks;
        private RJDatePicker dpkNgaysinh;
    }
}