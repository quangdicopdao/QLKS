namespace Doancsn
{
    partial class GUI_TimP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxFInd = new FontAwesome.Sharp.IconPictureBox();
            this.btnRefesh = new Doancsn.RJButton();
            this.btnAdd = new Doancsn.RJButton();
            this.rjTextBox1 = new Doancsn.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFInd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconPictureBoxFInd);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 79);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBoxFInd
            // 
            this.iconPictureBoxFInd.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFInd.ForeColor = System.Drawing.Color.Pink;
            this.iconPictureBoxFInd.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconPictureBoxFInd.IconColor = System.Drawing.Color.Pink;
            this.iconPictureBoxFInd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFInd.IconSize = 37;
            this.iconPictureBoxFInd.Location = new System.Drawing.Point(297, 22);
            this.iconPictureBoxFInd.Name = "iconPictureBoxFInd";
            this.iconPictureBoxFInd.Size = new System.Drawing.Size(45, 37);
            this.iconPictureBoxFInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFInd.TabIndex = 2;
            this.iconPictureBoxFInd.TabStop = false;
            this.iconPictureBoxFInd.Click += new System.EventHandler(this.iconPictureBoxFInd_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefesh.BackColor = System.Drawing.Color.Pink;
            this.btnRefesh.BgColor = System.Drawing.Color.Pink;
            this.btnRefesh.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnRefesh.BorderRadius = 20;
            this.btnRefesh.BorderSize = 0;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Location = new System.Drawing.Point(916, 22);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(150, 40);
            this.btnRefesh.TabIndex = 1;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.BgColor = System.Drawing.Color.Pink;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1072, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm phòng";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.Pink;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 8;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(35, 24);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Nhập mã phòng";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 497);
            this.panel2.TabIndex = 1;
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.BackgroundColor = System.Drawing.Color.Pink;
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit,
            this.Delete});
            this.dtgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.RowHeadersWidth = 51;
            this.dtgvPhong.RowTemplate.Height = 24;
            this.dtgvPhong.Size = new System.Drawing.Size(1234, 497);
            this.dtgvPhong.TabIndex = 0;
            this.dtgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPhong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPHONG";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LOAIPHONG";
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TRANGTHAI";
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAKS";
            this.Column5.HeaderText = "Mã khách sạn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Sửa";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sửa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // GUI_TimP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TimP";
            this.Text = "GUI_TimP";
            this.Load += new System.EventHandler(this.GUI_TimP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFInd)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvPhong;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFInd;
        private RJButton btnAdd;
        private RJTextBox rjTextBox1;
        private RJButton btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}