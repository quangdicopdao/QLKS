namespace Doancsn
{
    partial class GUI_SuaP
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
            this.txtMaphong = new Doancsn.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDongia = new Doancsn.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new Doancsn.RJButton();
            this.cboLoaiphong = new Doancsn.RJComboBox();
            this.cboTrangthai = new Doancsn.RJComboBox();
            this.cboMaks = new Doancsn.RJComboBox();
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
            this.panelThem.Size = new System.Drawing.Size(468, 38);
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
            this.btnClose.IconSize = 33;
            this.btnClose.Location = new System.Drawing.Point(418, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng";
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
            this.txtMaphong.Location = new System.Drawing.Point(176, 58);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Multiline = false;
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaphong.PasswordChar = false;
            this.txtMaphong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaphong.PlaceholderText = "";
            this.txtMaphong.Size = new System.Drawing.Size(112, 35);
            this.txtMaphong.TabIndex = 2;
            this.txtMaphong.Texts = "";
            this.txtMaphong.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn giá";
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDongia.BorderColor = System.Drawing.Color.Pink;
            this.txtDongia.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.txtDongia.BorderRadius = 8;
            this.txtDongia.BorderSize = 2;
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDongia.Location = new System.Drawing.Point(176, 179);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDongia.Multiline = false;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDongia.PasswordChar = false;
            this.txtDongia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDongia.PlaceholderText = "";
            this.txtDongia.Size = new System.Drawing.Size(200, 35);
            this.txtDongia.TabIndex = 2;
            this.txtDongia.Texts = "";
            this.txtDongia.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã khách sạn";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Pink;
            this.btnSave.BgColor = System.Drawing.Color.Pink;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(305, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.BackColor = System.Drawing.Color.White;
            this.cboLoaiphong.BorderColor = System.Drawing.Color.Pink;
            this.cboLoaiphong.BorderSize = 1;
            this.cboLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLoaiphong.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaiphong.IconColor = System.Drawing.Color.Pink;
            this.cboLoaiphong.Items.AddRange(new object[] {
            "ĐƠN ",
            "ĐÔI"});
            this.cboLoaiphong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiphong.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiphong.Location = new System.Drawing.Point(176, 115);
            this.cboLoaiphong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiphong.Size = new System.Drawing.Size(200, 37);
            this.cboLoaiphong.TabIndex = 4;
            this.cboLoaiphong.Texts = "";
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.BackColor = System.Drawing.Color.White;
            this.cboTrangthai.BorderColor = System.Drawing.Color.Pink;
            this.cboTrangthai.BorderSize = 1;
            this.cboTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTrangthai.ForeColor = System.Drawing.Color.DimGray;
            this.cboTrangthai.IconColor = System.Drawing.Color.Pink;
            this.cboTrangthai.Items.AddRange(new object[] {
            "ĐÃ ĐẶT",
            "CHƯA ĐẶT"});
            this.cboTrangthai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTrangthai.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTrangthai.Location = new System.Drawing.Point(176, 246);
            this.cboTrangthai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Padding = new System.Windows.Forms.Padding(1);
            this.cboTrangthai.Size = new System.Drawing.Size(200, 37);
            this.cboTrangthai.TabIndex = 4;
            this.cboTrangthai.Texts = "";
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
            this.cboMaks.Location = new System.Drawing.Point(176, 307);
            this.cboMaks.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaks.Name = "cboMaks";
            this.cboMaks.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaks.Size = new System.Drawing.Size(200, 37);
            this.cboMaks.TabIndex = 4;
            this.cboMaks.Texts = "";
            // 
            // GUI_SuaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 444);
            this.Controls.Add(this.cboMaks);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.cboLoaiphong);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelThem);
            this.Name = "GUI_SuaP";
            this.Text = "GUI_SuaP";
            this.Load += new System.EventHandler(this.GUI_SuaP_Load);
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtMaphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RJTextBox txtDongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJButton btnSave;
        private RJComboBox cboLoaiphong;
        private RJComboBox cboTrangthai;
        private RJComboBox cboMaks;
    }
}