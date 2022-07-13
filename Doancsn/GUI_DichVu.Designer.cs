namespace Doancsn
{
    partial class GUI_DichVu
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
            this.iconPictureBoxClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxService = new FontAwesome.Sharp.IconPictureBox();
            this.cboLoaidv = new Doancsn.RJComboBox();
            this.btnReset = new Doancsn.RJButton();
            this.btnSave = new Doancsn.RJButton();
            this.txtDonGia = new Doancsn.RJTextBox();
            this.txtTendv = new Doancsn.RJTextBox();
            this.txtMadv = new Doancsn.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelThem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxService)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBoxClose
            // 
            this.iconPictureBoxClose.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconPictureBoxClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxClose.IconSize = 29;
            this.iconPictureBoxClose.Location = new System.Drawing.Point(432, 3);
            this.iconPictureBoxClose.Name = "iconPictureBoxClose";
            this.iconPictureBoxClose.Size = new System.Drawing.Size(42, 29);
            this.iconPictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxClose.TabIndex = 6;
            this.iconPictureBoxClose.TabStop = false;
            this.iconPictureBoxClose.Click += new System.EventHandler(this.iconPictureBoxClose_Click);
            // 
            // iconPictureBoxService
            // 
            this.iconPictureBoxService.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxService.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxService.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.iconPictureBoxService.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxService.IconSize = 125;
            this.iconPictureBoxService.Location = new System.Drawing.Point(135, 62);
            this.iconPictureBoxService.Name = "iconPictureBoxService";
            this.iconPictureBoxService.Size = new System.Drawing.Size(201, 125);
            this.iconPictureBoxService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxService.TabIndex = 5;
            this.iconPictureBoxService.TabStop = false;
            // 
            // cboLoaidv
            // 
            this.cboLoaidv.BackColor = System.Drawing.Color.White;
            this.cboLoaidv.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.cboLoaidv.BorderSize = 1;
            this.cboLoaidv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaidv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLoaidv.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaidv.IconColor = System.Drawing.Color.CornflowerBlue;
            this.cboLoaidv.Items.AddRange(new object[] {
            "ĐỒ ĂN",
            "NƯỚC UỐNG"});
            this.cboLoaidv.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaidv.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaidv.Location = new System.Drawing.Point(181, 344);
            this.cboLoaidv.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaidv.Name = "cboLoaidv";
            this.cboLoaidv.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaidv.Size = new System.Drawing.Size(200, 41);
            this.cboLoaidv.TabIndex = 2;
            this.cboLoaidv.Texts = "";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(258, 481);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 42);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Làm lại";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(58, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 8;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.Location = new System.Drawing.Point(181, 423);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "Đơn giá";
            this.txtDonGia.Size = new System.Drawing.Size(174, 35);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // txtTendv
            // 
            this.txtTendv.BackColor = System.Drawing.SystemColors.Window;
            this.txtTendv.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtTendv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTendv.BorderRadius = 8;
            this.txtTendv.BorderSize = 2;
            this.txtTendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTendv.Location = new System.Drawing.Point(181, 269);
            this.txtTendv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendv.Multiline = false;
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTendv.PasswordChar = false;
            this.txtTendv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTendv.PlaceholderText = "Tên dịch vụ";
            this.txtTendv.Size = new System.Drawing.Size(250, 35);
            this.txtTendv.TabIndex = 1;
            this.txtTendv.Texts = "";
            this.txtTendv.UnderlinedStyle = false;
            // 
            // txtMadv
            // 
            this.txtMadv.BackColor = System.Drawing.SystemColors.Window;
            this.txtMadv.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtMadv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMadv.BorderRadius = 8;
            this.txtMadv.BorderSize = 2;
            this.txtMadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMadv.Location = new System.Drawing.Point(181, 205);
            this.txtMadv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadv.Multiline = false;
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMadv.PasswordChar = false;
            this.txtMadv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMadv.PlaceholderText = "Mã dịch vụ";
            this.txtMadv.Size = new System.Drawing.Size(120, 35);
            this.txtMadv.TabIndex = 0;
            this.txtMadv.Texts = "";
            this.txtMadv.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelThem);
            this.panel3.Controls.Add(this.iconPictureBoxService);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboLoaidv);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtMadv);
            this.panel3.Controls.Add(this.txtTendv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 554);
            this.panel3.TabIndex = 2;
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.iconPictureBoxClose);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(477, 35);
            this.panelThem.TabIndex = 7;
            // 
            // GUI_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 554);
            this.Controls.Add(this.panel3);
            this.Name = "GUI_DichVu";
            this.Text = "GUI_NhanVien";
            this.Load += new System.EventHandler(this.GUI_DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxService)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelThem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private RJButton btnSave;
        private RJTextBox txtMadv;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtDonGia;
        private RJTextBox txtTendv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJComboBox cboLoaidv;
        private RJButton btnReset;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxService;
        private System.Windows.Forms.Panel panelThem;
    }
}