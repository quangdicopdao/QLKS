namespace Doancsn
{
    partial class GUI_TimKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimKS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefesh = new Doancsn.RJButton();
            this.btnAdd = new Doancsn.RJButton();
            this.txtFind = new Doancsn.RJTextBox();
            this.iconPictureBoxFind = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvKhachSan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFind)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachSan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.iconPictureBoxFind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefesh.BackColor = System.Drawing.Color.Orange;
            this.btnRefesh.BgColor = System.Drawing.Color.Orange;
            this.btnRefesh.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnRefesh.BorderRadius = 20;
            this.btnRefesh.BorderSize = 0;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Location = new System.Drawing.Point(846, 16);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(112, 32);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Orange;
            this.btnAdd.BgColor = System.Drawing.Color.Orange;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(963, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm khách sạn";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.Window;
            this.txtFind.BorderColor = System.Drawing.Color.Orange;
            this.txtFind.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFind.BorderRadius = 8;
            this.txtFind.BorderSize = 2;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFind.Location = new System.Drawing.Point(37, 20);
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            this.txtFind.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtFind.PasswordChar = false;
            this.txtFind.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFind.PlaceholderText = "Nhập tên khách sạn";
            this.txtFind.Size = new System.Drawing.Size(206, 29);
            this.txtFind.TabIndex = 1;
            this.txtFind.Texts = "";
            this.txtFind.UnderlinedStyle = false;
            // 
            // iconPictureBoxFind
            // 
            this.iconPictureBoxFind.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFind.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBoxFind.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconPictureBoxFind.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBoxFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFind.IconSize = 28;
            this.iconPictureBoxFind.Location = new System.Drawing.Point(248, 20);
            this.iconPictureBoxFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBoxFind.Name = "iconPictureBoxFind";
            this.iconPictureBoxFind.Size = new System.Drawing.Size(34, 28);
            this.iconPictureBoxFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFind.TabIndex = 0;
            this.iconPictureBoxFind.TabStop = false;
            this.iconPictureBoxFind.Click += new System.EventHandler(this.iconPictureBoxFind_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvKhachSan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 404);
            this.panel2.TabIndex = 1;
            // 
            // dtgvKhachSan
            // 
            this.dtgvKhachSan.BackgroundColor = System.Drawing.Color.Orange;
            this.dtgvKhachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit,
            this.Delete});
            this.dtgvKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKhachSan.Location = new System.Drawing.Point(0, 0);
            this.dtgvKhachSan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvKhachSan.Name = "dtgvKhachSan";
            this.dtgvKhachSan.RowHeadersWidth = 51;
            this.dtgvKhachSan.RowTemplate.Height = 24;
            this.dtgvKhachSan.Size = new System.Drawing.Size(1085, 404);
            this.dtgvKhachSan.TabIndex = 0;
            this.dtgvKhachSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhachSan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKS";
            this.Column1.HeaderText = "Mã khách sạn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENKS";
            this.Column2.HeaderText = "Tên khách sạn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOPHONG";
            this.Column4.HeaderText = "Số phòng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAKV";
            this.Column5.HeaderText = "Mã khu vực";
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
            // GUI_TimKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI_TimKS";
            this.Text = "GUI_TimKS";
            this.Load += new System.EventHandler(this.GUI_TimKS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFind)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJButton btnAdd;
        private RJTextBox txtFind;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFind;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvKhachSan;
        private RJButton btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}