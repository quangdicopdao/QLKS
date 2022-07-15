namespace Doancsn
{
    partial class GUI_TimDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TimDV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxFind = new FontAwesome.Sharp.IconPictureBox();
            this.txtFind = new Doancsn.RJTextBox();
            this.btnRefesh = new Doancsn.RJButton();
            this.btnAdd = new Doancsn.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvDichVu = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFind)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconPictureBoxFind);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 79);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBoxFind
            // 
            this.iconPictureBoxFind.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxFind.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxFind.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconPictureBoxFind.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconPictureBoxFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxFind.IconSize = 35;
            this.iconPictureBoxFind.Location = new System.Drawing.Point(322, 21);
            this.iconPictureBoxFind.Name = "iconPictureBoxFind";
            this.iconPictureBoxFind.Size = new System.Drawing.Size(44, 35);
            this.iconPictureBoxFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxFind.TabIndex = 2;
            this.iconPictureBoxFind.TabStop = false;
            this.iconPictureBoxFind.Click += new System.EventHandler(this.iconPictureBoxFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.SystemColors.Window;
            this.txtFind.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.txtFind.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFind.BorderRadius = 8;
            this.txtFind.BorderSize = 2;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFind.Location = new System.Drawing.Point(40, 21);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            this.txtFind.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFind.PasswordChar = false;
            this.txtFind.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFind.PlaceholderText = "Nhập tên dịch vụ";
            this.txtFind.Size = new System.Drawing.Size(275, 35);
            this.txtFind.TabIndex = 1;
            this.txtFind.Texts = "";
            this.txtFind.UnderlinedStyle = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefesh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefesh.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefesh.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnRefesh.BorderRadius = 20;
            this.btnRefesh.BorderSize = 0;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.Location = new System.Drawing.Point(923, 21);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(150, 40);
            this.btnRefesh.TabIndex = 0;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.TextColor = System.Drawing.Color.White;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1079, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm dịch vụ";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvDichVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 497);
            this.panel2.TabIndex = 1;
            // 
            // dtgvDichVu
            // 
            this.dtgvDichVu.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dtgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dtgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dtgvDichVu.Name = "dtgvDichVu";
            this.dtgvDichVu.RowHeadersWidth = 51;
            this.dtgvDichVu.RowTemplate.Height = 24;
            this.dtgvDichVu.Size = new System.Drawing.Size(1234, 497);
            this.dtgvDichVu.TabIndex = 0;
            this.dtgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDichVu_CellClick);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "MADV";
            this.Column1.HeaderText = "Mã dịch vụ ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDV";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LOAIDV";
            this.Column3.HeaderText = "Loại dịch vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DONGIA";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
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
            // GUI_TimDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TimDV";
            this.Text = "GUI_TimDV";
            this.Load += new System.EventHandler(this.GUI_TimDV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxFind)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvDichVu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxFind;
        private RJTextBox txtFind;
        private RJButton btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private RJButton btnRefesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}