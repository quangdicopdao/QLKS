namespace Doancsn
{
    partial class GUI_SuaDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMadv = new Doancsn.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTendv = new Doancsn.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new Doancsn.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new Doancsn.RJButton();
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.cboLoaidv = new Doancsn.RJComboBox();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ";
            // 
            // txtMadv
            // 
            this.txtMadv.BackColor = System.Drawing.SystemColors.Window;
            this.txtMadv.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtMadv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMadv.BorderRadius = 8;
            this.txtMadv.BorderSize = 2;
            this.txtMadv.Enabled = false;
            this.txtMadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMadv.ForeColor = System.Drawing.Color.Black;
            this.txtMadv.Location = new System.Drawing.Point(145, 65);
            this.txtMadv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadv.Multiline = false;
            this.txtMadv.Name = "txtMadv";
            this.txtMadv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMadv.PasswordChar = false;
            this.txtMadv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMadv.PlaceholderText = "";
            this.txtMadv.Size = new System.Drawing.Size(152, 35);
            this.txtMadv.TabIndex = 1;
            this.txtMadv.Texts = "";
            this.txtMadv.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtTendv
            // 
            this.txtTendv.BackColor = System.Drawing.SystemColors.Window;
            this.txtTendv.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtTendv.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTendv.BorderRadius = 8;
            this.txtTendv.BorderSize = 2;
            this.txtTendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendv.ForeColor = System.Drawing.Color.Black;
            this.txtTendv.Location = new System.Drawing.Point(145, 123);
            this.txtTendv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendv.Multiline = false;
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTendv.PasswordChar = false;
            this.txtTendv.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTendv.PlaceholderText = "";
            this.txtTendv.Size = new System.Drawing.Size(250, 35);
            this.txtTendv.TabIndex = 2;
            this.txtTendv.Texts = "";
            this.txtTendv.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 8;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(145, 264);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.Size = new System.Drawing.Size(190, 35);
            this.txtDonGia.TabIndex = 1;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại dịch vụ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 35;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(280, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 53);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnClose);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(433, 40);
            this.panelThem.TabIndex = 3;
            this.panelThem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelThem_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 36;
            this.btnClose.Location = new System.Drawing.Point(395, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 36);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboLoaidv
            // 
            this.cboLoaidv.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.cboLoaidv.Location = new System.Drawing.Point(145, 190);
            this.cboLoaidv.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaidv.Name = "cboLoaidv";
            this.cboLoaidv.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaidv.Size = new System.Drawing.Size(200, 30);
            this.cboLoaidv.TabIndex = 3;
            this.cboLoaidv.Texts = "";
            // 
            // GUI_SuaDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 390);
            this.Controls.Add(this.cboLoaidv);
            this.Controls.Add(this.panelThem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTendv);
            this.Controls.Add(this.txtMadv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_SuaDV";
            this.Text = "GUI_SuaDV";
            this.Load += new System.EventHandler(this.GUI_SuaDV_Load);
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJTextBox txtMadv;
        private System.Windows.Forms.Label label2;
        private RJTextBox txtTendv;
        private System.Windows.Forms.Label label3;
        private RJTextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private RJButton btnSave;
        private System.Windows.Forms.Panel panelThem;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private RJComboBox cboLoaidv;
    }
}