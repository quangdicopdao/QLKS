namespace Doancsn
{
    partial class GUI_UserThemDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_UserThemDV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvXoaDV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgvThemDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonPrevious = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton1 = new Doancsn.RJButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.cboLoaidv = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXoaDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemDV)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cboLoaidv);
            this.panel1.Controls.Add(this.dtgvXoaDV);
            this.panel1.Controls.Add(this.dtgvThemDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 400);
            this.panel1.TabIndex = 0;
            // 
            // dtgvXoaDV
            // 
            this.dtgvXoaDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXoaDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Soluong,
            this.ThanhTien,
            this.dataGridViewImageColumn1});
            this.dtgvXoaDV.Location = new System.Drawing.Point(583, 99);
            this.dtgvXoaDV.Name = "dtgvXoaDV";
            this.dtgvXoaDV.RowHeadersWidth = 51;
            this.dtgvXoaDV.RowTemplate.Height = 24;
            this.dtgvXoaDV.Size = new System.Drawing.Size(558, 280);
            this.dtgvXoaDV.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên dịch vụ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Add";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dtgvThemDV
            // 
            this.dtgvThemDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Add});
            this.dtgvThemDV.Location = new System.Drawing.Point(19, 99);
            this.dtgvThemDV.Name = "dtgvThemDV";
            this.dtgvThemDV.RowHeadersWidth = 51;
            this.dtgvThemDV.RowTemplate.Height = 24;
            this.dtgvThemDV.Size = new System.Drawing.Size(558, 280);
            this.dtgvThemDV.TabIndex = 4;
            this.dtgvThemDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThemDV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại dịch vụ";
            // 
            // iconButtonPrevious
            // 
            this.iconButtonPrevious.BackColor = System.Drawing.Color.White;
            this.iconButtonPrevious.FlatAppearance.BorderSize = 0;
            this.iconButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPrevious.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconButtonPrevious.IconColor = System.Drawing.Color.Black;
            this.iconButtonPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPrevious.Location = new System.Drawing.Point(3, 1);
            this.iconButtonPrevious.Name = "iconButtonPrevious";
            this.iconButtonPrevious.Size = new System.Drawing.Size(58, 44);
            this.iconButtonPrevious.TabIndex = 1;
            this.iconButtonPrevious.UseVisualStyleBackColor = false;
            this.iconButtonPrevious.Click += new System.EventHandler(this.iconButtonPrevious_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.iconButtonPrevious);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1211, 47);
            this.panelTitle.TabIndex = 3;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(523, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.rjButton1.BgColor = System.Drawing.Color.ForestGreen;
            this.rjButton1.BorderColor = System.Drawing.Color.DarkViolet;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1027, 562);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(172, 48);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Lưu";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LOAIDV";
            this.Column1.HeaderText = "Loại dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDV";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Width = 50;
            // 
            // cboLoaidv
            // 
            this.cboLoaidv.FormattingEnabled = true;
            this.cboLoaidv.Items.AddRange(new object[] {
            "TẤT CẢ",
            "ĐỒ ĂN",
            "NƯỚC UỐNG"});
            this.cboLoaidv.Location = new System.Drawing.Point(122, 26);
            this.cboLoaidv.Name = "cboLoaidv";
            this.cboLoaidv.Size = new System.Drawing.Size(175, 24);
            this.cboLoaidv.TabIndex = 5;
            this.cboLoaidv.SelectedIndexChanged += new System.EventHandler(this.cboLoaidv_SelectedIndexChanged);
            // 
            // GUI_UserThemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_UserThemDV";
            this.Text = "GUI_ThemDV";
            this.Load += new System.EventHandler(this.GUI_ThemDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXoaDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemDV)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonPrevious;
        private RJButton rjButton1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.DataGridView dtgvThemDV;
        private System.Windows.Forms.DataGridView dtgvXoaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Add;
        private System.Windows.Forms.ComboBox cboLoaidv;
    }
}