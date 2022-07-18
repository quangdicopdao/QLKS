namespace Doancsn
{
    partial class GUI_DoiMatKhau
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.cbxShowPass = new System.Windows.Forms.CheckBox();
            this.iconPictureBoxChangPass = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new Doancsn.RJButton();
            this.txtPassNewAgain = new Doancsn.RJTextBox();
            this.txtPassNew = new Doancsn.RJTextBox();
            this.txtPassOld = new Doancsn.RJTextBox();
            this.txtUserName = new Doancsn.RJTextBox();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxChangPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.iconButtonClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(418, 47);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.Location = new System.Drawing.Point(365, 2);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(52, 44);
            this.iconButtonClose.TabIndex = 5;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // cbxShowPass
            // 
            this.cbxShowPass.AutoSize = true;
            this.cbxShowPass.ForeColor = System.Drawing.Color.White;
            this.cbxShowPass.Location = new System.Drawing.Point(70, 519);
            this.cbxShowPass.Name = "cbxShowPass";
            this.cbxShowPass.Size = new System.Drawing.Size(114, 20);
            this.cbxShowPass.TabIndex = 3;
            this.cbxShowPass.Text = "Hiện mật khẩu";
            this.cbxShowPass.UseVisualStyleBackColor = true;
            this.cbxShowPass.CheckedChanged += new System.EventHandler(this.cbxShowPass_CheckedChanged);
            // 
            // iconPictureBoxChangPass
            // 
            this.iconPictureBoxChangPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBoxChangPass.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconPictureBoxChangPass.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxChangPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxChangPass.IconSize = 106;
            this.iconPictureBoxChangPass.Location = new System.Drawing.Point(116, 53);
            this.iconPictureBoxChangPass.Name = "iconPictureBoxChangPass";
            this.iconPictureBoxChangPass.Size = new System.Drawing.Size(182, 106);
            this.iconPictureBoxChangPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxChangPass.TabIndex = 4;
            this.iconPictureBoxChangPass.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BgColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSave.Location = new System.Drawing.Point(70, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Đổi mật khẩu";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassNewAgain
            // 
            this.txtPassNewAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtPassNewAgain.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassNewAgain.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassNewAgain.BorderRadius = 8;
            this.txtPassNewAgain.BorderSize = 2;
            this.txtPassNewAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNewAgain.ForeColor = System.Drawing.Color.White;
            this.txtPassNewAgain.Location = new System.Drawing.Point(70, 454);
            this.txtPassNewAgain.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNewAgain.Multiline = false;
            this.txtPassNewAgain.Name = "txtPassNewAgain";
            this.txtPassNewAgain.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassNewAgain.PasswordChar = true;
            this.txtPassNewAgain.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassNewAgain.PlaceholderText = "";
            this.txtPassNewAgain.Size = new System.Drawing.Size(273, 35);
            this.txtPassNewAgain.TabIndex = 3;
            this.txtPassNewAgain.Texts = "";
            this.txtPassNewAgain.UnderlinedStyle = false;
            // 
            // txtPassNew
            // 
            this.txtPassNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtPassNew.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassNew.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassNew.BorderRadius = 8;
            this.txtPassNew.BorderSize = 2;
            this.txtPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.ForeColor = System.Drawing.Color.White;
            this.txtPassNew.Location = new System.Drawing.Point(70, 369);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNew.Multiline = false;
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassNew.PasswordChar = true;
            this.txtPassNew.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassNew.PlaceholderText = "";
            this.txtPassNew.Size = new System.Drawing.Size(273, 35);
            this.txtPassNew.TabIndex = 2;
            this.txtPassNew.Texts = "";
            this.txtPassNew.UnderlinedStyle = false;
            // 
            // txtPassOld
            // 
            this.txtPassOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtPassOld.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassOld.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassOld.BorderRadius = 8;
            this.txtPassOld.BorderSize = 2;
            this.txtPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassOld.ForeColor = System.Drawing.Color.White;
            this.txtPassOld.Location = new System.Drawing.Point(68, 286);
            this.txtPassOld.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassOld.Multiline = false;
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassOld.PasswordChar = true;
            this.txtPassOld.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassOld.PlaceholderText = "";
            this.txtPassOld.Size = new System.Drawing.Size(273, 35);
            this.txtPassOld.TabIndex = 1;
            this.txtPassOld.Texts = "";
            this.txtPassOld.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUserName.BorderRadius = 8;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(68, 210);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.Size = new System.Drawing.Size(273, 35);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = false;
            // 
            // GUI_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(418, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBoxChangPass);
            this.Controls.Add(this.cbxShowPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassNewAgain);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panelTitle);
            this.Name = "GUI_DoiMatKhau";
            this.Text = "GUI_DoiMatKhau";
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxChangPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private RJTextBox txtUserName;
        private RJButton btnSave;
        private RJTextBox txtPassOld;
        private RJTextBox txtPassNewAgain;
        private System.Windows.Forms.CheckBox cbxShowPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxChangPass;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private RJTextBox txtPassNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}