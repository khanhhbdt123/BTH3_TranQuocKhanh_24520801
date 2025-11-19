namespace Bai08
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbSTK = new TextBox();
            tbTenKH = new TextBox();
            tbDC = new TextBox();
            tbTien = new TextBox();
            btnTvCN = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lblTongTien = new Label();
            lblTongTien1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(916, 80);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(167, 98);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 136);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 175);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 211);
            label5.Name = "label5";
            label5.Size = new Size(186, 23);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // tbSTK
            // 
            tbSTK.Location = new Point(278, 94);
            tbSTK.Name = "tbSTK";
            tbSTK.Size = new Size(439, 27);
            tbSTK.TabIndex = 5;
            // 
            // tbTenKH
            // 
            tbTenKH.Location = new Point(278, 132);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(439, 27);
            tbTenKH.TabIndex = 6;
            // 
            // tbDC
            // 
            tbDC.Location = new Point(278, 171);
            tbDC.Name = "tbDC";
            tbDC.Size = new Size(439, 27);
            tbDC.TabIndex = 7;
            // 
            // tbTien
            // 
            tbTien.Location = new Point(278, 207);
            tbTien.Name = "tbTien";
            tbTien.Size = new Size(439, 27);
            tbTien.TabIndex = 8;
            // 
            // btnTvCN
            // 
            btnTvCN.Location = new Point(346, 248);
            btnTvCN.Name = "btnTvCN";
            btnTvCN.Size = new Size(135, 29);
            btnTvCN.TabIndex = 9;
            btnTvCN.Text = "Thêm/Cập nhật";
            btnTvCN.UseVisualStyleBackColor = true;
            btnTvCN.Click += btnTvCN_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(501, 248);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(623, 248);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 283);
            listView1.Name = "listView1";
            listView1.Size = new Size(892, 387);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 350;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 160;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(520, 675);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(78, 20);
            lblTongTien.TabIndex = 13;
            lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTongTien1
            // 
            lblTongTien1.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien1.Location = new Point(623, 675);
            lblTongTien1.Name = "lblTongTien1";
            lblTongTien1.Size = new Size(281, 22);
            lblTongTien1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 704);
            Controls.Add(lblTongTien1);
            Controls.Add(lblTongTien);
            Controls.Add(listView1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTvCN);
            Controls.Add(tbTien);
            Controls.Add(tbDC);
            Controls.Add(tbTenKH);
            Controls.Add(tbSTK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbSTK;
        private TextBox tbTenKH;
        private TextBox tbDC;
        private TextBox tbTien;
        private Button btnTvCN;
        private Button btnXoa;
        private Button btnThoat;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblTongTien;
        private Label lblTongTien1;
    }
}
