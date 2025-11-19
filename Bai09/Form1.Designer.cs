namespace Bai09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnLuu = new Button();
            btnGo = new Button();
            btnThem = new Button();
            lbDaChon = new ListBox();
            lbCanChon = new ListBox();
            chbGT2 = new CheckBox();
            chbGT1 = new CheckBox();
            cbCN = new ComboBox();
            tbHT = new TextBox();
            tbMSV = new TextBox();
            lblChonMH = new Label();
            lblGT = new Label();
            lblCN = new Label();
            lblHT = new Label();
            lblMSV = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnGo);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lbDaChon);
            groupBox1.Controls.Add(lbCanChon);
            groupBox1.Controls.Add(chbGT2);
            groupBox1.Controls.Add(chbGT1);
            groupBox1.Controls.Add(cbCN);
            groupBox1.Controls.Add(tbHT);
            groupBox1.Controls.Add(tbMSV);
            groupBox1.Controls.Add(lblChonMH);
            groupBox1.Controls.Add(lblGT);
            groupBox1.Controls.Add(lblCN);
            groupBox1.Controls.Add(lblHT);
            groupBox1.Controls.Add(lblMSV);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(850, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(381, 303);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa Chọn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(252, 303);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(117, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(388, 240);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(49, 34);
            btnGo.TabIndex = 13;
            btnGo.Text = "<";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(388, 198);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(49, 36);
            btnThem.TabIndex = 12;
            btnThem.Text = ">";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lbDaChon
            // 
            lbDaChon.FormattingEnabled = true;
            lbDaChon.Location = new Point(458, 189);
            lbDaChon.Name = "lbDaChon";
            lbDaChon.Size = new Size(194, 104);
            lbDaChon.TabIndex = 11;
            // 
            // lbCanChon
            // 
            lbCanChon.FormattingEnabled = true;
            lbCanChon.Items.AddRange(new object[] { "Cơ Sở Dữ Liệu", "Cơ Sở DL NC", "PTTK Hệ Thống thông tin", "Cấu Trúc DL và GT", "Lập Trình Trực quan" });
            lbCanChon.Location = new Point(166, 189);
            lbCanChon.Name = "lbCanChon";
            lbCanChon.Size = new Size(202, 104);
            lbCanChon.TabIndex = 10;
            // 
            // chbGT2
            // 
            chbGT2.AutoSize = true;
            chbGT2.Location = new Point(443, 139);
            chbGT2.Name = "chbGT2";
            chbGT2.Size = new Size(51, 24);
            chbGT2.TabIndex = 9;
            chbGT2.Text = "Nữ";
            chbGT2.UseVisualStyleBackColor = true;
            chbGT2.CheckedChanged += chbGT2_CheckedChanged;
            // 
            // chbGT1
            // 
            chbGT1.AutoSize = true;
            chbGT1.Location = new Point(334, 139);
            chbGT1.Name = "chbGT1";
            chbGT1.Size = new Size(63, 24);
            chbGT1.TabIndex = 8;
            chbGT1.Text = "Nam";
            chbGT1.UseVisualStyleBackColor = true;
            chbGT1.CheckedChanged += chbGT1_CheckedChanged;
            // 
            // cbCN
            // 
            cbCN.FormattingEnabled = true;
            cbCN.Items.AddRange(new object[] { "Hệ Thống Thông Tin", "Kỹ Thuật Phần Mềm", "Khoa Học Máy Tính", "Kỹ Thuật Máy Tính" });
            cbCN.Location = new Point(334, 101);
            cbCN.Name = "cbCN";
            cbCN.Size = new Size(265, 28);
            cbCN.TabIndex = 7;
            // 
            // tbHT
            // 
            tbHT.Location = new Point(334, 65);
            tbHT.Name = "tbHT";
            tbHT.Size = new Size(265, 27);
            tbHT.TabIndex = 6;
            // 
            // tbMSV
            // 
            tbMSV.Location = new Point(334, 32);
            tbMSV.Name = "tbMSV";
            tbMSV.Size = new Size(141, 27);
            tbMSV.TabIndex = 5;
            // 
            // lblChonMH
            // 
            lblChonMH.AutoSize = true;
            lblChonMH.Location = new Point(166, 166);
            lblChonMH.Name = "lblChonMH";
            lblChonMH.Size = new Size(203, 20);
            lblChonMH.TabIndex = 4;
            lblChonMH.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // lblGT
            // 
            lblGT.AutoSize = true;
            lblGT.Location = new Point(166, 139);
            lblGT.Name = "lblGT";
            lblGT.Size = new Size(68, 20);
            lblGT.TabIndex = 3;
            lblGT.Text = "Giới Tính";
            // 
            // lblCN
            // 
            lblCN.AutoSize = true;
            lblCN.Location = new Point(166, 109);
            lblCN.Name = "lblCN";
            lblCN.Size = new Size(105, 20);
            lblCN.TabIndex = 2;
            lblCN.Text = "Chuyên Ngành";
            // 
            // lblHT
            // 
            lblHT.AutoSize = true;
            lblHT.Location = new Point(166, 68);
            lblHT.Name = "lblHT";
            lblHT.Size = new Size(56, 20);
            lblHT.TabIndex = 1;
            lblHT.Text = "Họ Tên";
            // 
            // lblMSV
            // 
            lblMSV.AutoSize = true;
            lblMSV.Location = new Point(166, 35);
            lblMSV.Name = "lblMSV";
            lblMSV.Size = new Size(95, 20);
            lblMSV.TabIndex = 0;
            lblMSV.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 285);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MSSV";
            Column1.HeaderText = "MSSV";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTen";
            Column2.HeaderText = "Họ Tên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ChuyenNganh";
            Column3.HeaderText = "Chuyên Ngành";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "GioiTinh";
            Column4.HeaderText = "Giới Tính";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoMon";
            Column5.HeaderText = "Số Môn";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(874, 668);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblChonMH;
        private Label lblGT;
        private Label lblCN;
        private Label lblHT;
        private Label lblMSV;
        private ListBox lbDaChon;
        private ListBox lbCanChon;
        private CheckBox chbGT2;
        private CheckBox chbGT1;
        private ComboBox cbCN;
        private TextBox tbHT;
        private TextBox tbMSV;
        private Button btnGo;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLuu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
