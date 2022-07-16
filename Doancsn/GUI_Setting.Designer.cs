namespace Doancsn
{
    partial class GUI_Setting
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new Doancsn.RJButton();
            this.btnEdit = new Doancsn.RJButton();
            this.btnDelete = new Doancsn.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboMaks = new Doancsn.RJComboBox();
            this.btnNV = new Doancsn.RJRadioButton();
            this.btnQL = new Doancsn.RJRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new Doancsn.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new Doancsn.RJTextBox();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtgvUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 576);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(511, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 103);
            this.panel3.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BgColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BgColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(159, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 52);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BgColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(315, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 52);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboMaks);
            this.panel4.Controls.Add(this.btnNV);
            this.panel4.Controls.Add(this.btnQL);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtPass);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtUserName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(511, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 473);
            this.panel4.TabIndex = 3;
            // 
            // cboMaks
            // 
            this.cboMaks.BackColor = System.Drawing.Color.White;
            this.cboMaks.BorderColor = System.Drawing.Color.SeaGreen;
            this.cboMaks.BorderSize = 1;
            this.cboMaks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaks.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaks.IconColor = System.Drawing.Color.SeaGreen;
            this.cboMaks.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaks.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaks.Location = new System.Drawing.Point(152, 245);
            this.cboMaks.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaks.Name = "cboMaks";
            this.cboMaks.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaks.Size = new System.Drawing.Size(200, 36);
            this.cboMaks.TabIndex = 3;
            this.cboMaks.Texts = "";
            // 
            // btnNV
            // 
            this.btnNV.AutoSize = true;
            this.btnNV.CheckedColor = System.Drawing.Color.SeaGreen;
            this.btnNV.Location = new System.Drawing.Point(304, 181);
            this.btnNV.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnNV.Name = "btnNV";
            this.btnNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNV.Size = new System.Drawing.Size(98, 21);
            this.btnNV.TabIndex = 2;
            this.btnNV.TabStop = true;
            this.btnNV.Text = "Nhân viên";
            this.btnNV.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnNV.UseVisualStyleBackColor = true;
            // 
            // btnQL
            // 
            this.btnQL.AutoSize = true;
            this.btnQL.CheckedColor = System.Drawing.Color.SeaGreen;
            this.btnQL.Location = new System.Drawing.Point(152, 183);
            this.btnQL.MinimumSize = new System.Drawing.Size(0, 21);
            this.btnQL.Name = "btnQL";
            this.btnQL.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQL.Size = new System.Drawing.Size(83, 21);
            this.btnQL.TabIndex = 2;
            this.btnQL.TabStop = true;
            this.btnQL.Text = "Quản lý";
            this.btnQL.UnCheckedColor = System.Drawing.Color.Gray;
            this.btnQL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách sạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phân quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPass.BorderRadius = 8;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(152, 96);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = false;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.Size = new System.Drawing.Size(250, 35);
            this.txtPass.TabIndex = 0;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserName.BorderRadius = 8;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(152, 43);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.Size = new System.Drawing.Size(250, 35);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // dtgvUser
            // 
            this.dtgvUser.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvUser.Location = new System.Drawing.Point(0, 0);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(511, 576);
            this.dtgvUser.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phân quyền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã khách sạn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // GUI_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 576);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_Setting";
            this.Text = "GUI_Setting";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private RJButton btnSave;
        private RJButton btnEdit;
        private RJButton btnDelete;
        private System.Windows.Forms.Label label2;
        private RJTextBox txtPass;
        private System.Windows.Forms.Label label1;
        private RJTextBox txtUserName;
        private RJComboBox cboMaks;
        private RJRadioButton btnNV;
        private RJRadioButton btnQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}