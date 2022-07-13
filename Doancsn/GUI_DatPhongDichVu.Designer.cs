namespace Doancsn
{
    partial class GUI_DatPhongDichVu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBoxCount = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxTime = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxDate = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.lbRoom = new System.Windows.Forms.Label();
            this.iconButtonPrevious = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.rjButton2 = new Doancsn.RJButton();
            this.btnNhanPhongThanhToan = new Doancsn.RJButton();
            this.btnThemDV = new Doancsn.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnThemDV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBoxCount);
            this.panel1.Controls.Add(this.iconPictureBoxTime);
            this.panel1.Controls.Add(this.iconPictureBoxDate);
            this.panel1.Controls.Add(this.iconPictureBoxUser);
            this.panel1.Location = new System.Drawing.Point(56, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 481);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(23, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 353);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Loại dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số người";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đặt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // iconPictureBoxCount
            // 
            this.iconPictureBoxCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCount.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBoxCount.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxCount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCount.IconSize = 31;
            this.iconPictureBoxCount.Location = new System.Drawing.Point(670, 22);
            this.iconPictureBoxCount.Name = "iconPictureBoxCount";
            this.iconPictureBoxCount.Size = new System.Drawing.Size(34, 31);
            this.iconPictureBoxCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxCount.TabIndex = 0;
            this.iconPictureBoxCount.TabStop = false;
            // 
            // iconPictureBoxTime
            // 
            this.iconPictureBoxTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxTime.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconPictureBoxTime.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxTime.IconSize = 31;
            this.iconPictureBoxTime.Location = new System.Drawing.Point(450, 22);
            this.iconPictureBoxTime.Name = "iconPictureBoxTime";
            this.iconPictureBoxTime.Size = new System.Drawing.Size(34, 31);
            this.iconPictureBoxTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxTime.TabIndex = 0;
            this.iconPictureBoxTime.TabStop = false;
            // 
            // iconPictureBoxDate
            // 
            this.iconPictureBoxDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxDate.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconPictureBoxDate.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxDate.IconSize = 31;
            this.iconPictureBoxDate.Location = new System.Drawing.Point(240, 22);
            this.iconPictureBoxDate.Name = "iconPictureBoxDate";
            this.iconPictureBoxDate.Size = new System.Drawing.Size(34, 31);
            this.iconPictureBoxDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxDate.TabIndex = 0;
            this.iconPictureBoxDate.TabStop = false;
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBoxUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBoxUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUser.IconSize = 31;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(23, 22);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(34, 31);
            this.iconPictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxUser.TabIndex = 0;
            this.iconPictureBoxUser.TabStop = false;
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRoom.ForeColor = System.Drawing.Color.White;
            this.lbRoom.Location = new System.Drawing.Point(412, 0);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(152, 54);
            this.lbRoom.TabIndex = 2;
            this.lbRoom.Text = "Room";
            // 
            // iconButtonPrevious
            // 
            this.iconButtonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonPrevious.FlatAppearance.BorderSize = 0;
            this.iconButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPrevious.ForeColor = System.Drawing.Color.White;
            this.iconButtonPrevious.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButtonPrevious.IconColor = System.Drawing.Color.White;
            this.iconButtonPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPrevious.Location = new System.Drawing.Point(3, 3);
            this.iconButtonPrevious.Name = "iconButtonPrevious";
            this.iconButtonPrevious.Size = new System.Drawing.Size(53, 39);
            this.iconButtonPrevious.TabIndex = 3;
            this.iconButtonPrevious.UseVisualStyleBackColor = false;
            this.iconButtonPrevious.Click += new System.EventHandler(this.iconButtonPrevious_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.iconButtonPrevious);
            this.panelTitle.Controls.Add(this.lbRoom);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(978, 52);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BgColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.DarkViolet;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(803, 614);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(162, 45);
            this.rjButton2.TabIndex = 1;
            this.rjButton2.Text = "Lưu";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // btnNhanPhongThanhToan
            // 
            this.btnNhanPhongThanhToan.BackColor = System.Drawing.Color.White;
            this.btnNhanPhongThanhToan.BgColor = System.Drawing.Color.White;
            this.btnNhanPhongThanhToan.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnNhanPhongThanhToan.BorderRadius = 20;
            this.btnNhanPhongThanhToan.BorderSize = 0;
            this.btnNhanPhongThanhToan.FlatAppearance.BorderSize = 0;
            this.btnNhanPhongThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhongThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnNhanPhongThanhToan.Location = new System.Drawing.Point(617, 614);
            this.btnNhanPhongThanhToan.Name = "btnNhanPhongThanhToan";
            this.btnNhanPhongThanhToan.Size = new System.Drawing.Size(162, 45);
            this.btnNhanPhongThanhToan.TabIndex = 1;
            this.btnNhanPhongThanhToan.Text = "Nhận phòng";
            this.btnNhanPhongThanhToan.TextColor = System.Drawing.Color.Black;
            this.btnNhanPhongThanhToan.UseVisualStyleBackColor = false;
            this.btnNhanPhongThanhToan.Click += new System.EventHandler(this.btnNhanPhongThanhToan_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemDV.BgColor = System.Drawing.Color.ForestGreen;
            this.btnThemDV.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnThemDV.BorderRadius = 20;
            this.btnThemDV.BorderSize = 0;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(713, 68);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(146, 41);
            this.btnThemDV.TabIndex = 1;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.TextColor = System.Drawing.Color.White;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Visible = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // GUI_DatPhongDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(978, 679);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btnNhanPhongThanhToan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_DatPhongDichVu";
            this.Text = "GUI_DatPhongDichVu";
            this.Load += new System.EventHandler(this.GUI_DatPhongDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJButton btnNhanPhongThanhToan;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private RJButton rjButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCount;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxTime;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxDate;
        private RJButton btnThemDV;
        private System.Windows.Forms.Label lbRoom;
        private FontAwesome.Sharp.IconButton iconButtonPrevious;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}