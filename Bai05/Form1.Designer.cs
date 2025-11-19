namespace Bai05
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            lblAns = new Label();
            tbAns = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(204, 86);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(75, 20);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Number 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(204, 134);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(75, 20);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Number 2";
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(285, 79);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(350, 27);
            tbNum1.TabIndex = 2;
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(285, 127);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(350, 27);
            tbNum2.TabIndex = 3;
            // 
            // lblAns
            // 
            lblAns.AutoSize = true;
            lblAns.Location = new Point(222, 273);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(57, 20);
            lblAns.TabIndex = 4;
            lblAns.Text = "Answer";
            // 
            // tbAns
            // 
            tbAns.Location = new Point(285, 266);
            tbAns.Name = "tbAns";
            tbAns.Size = new Size(350, 27);
            tbAns.TabIndex = 5;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(316, 189);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(60, 50);
            btnCong.TabIndex = 6;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(403, 189);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(60, 50);
            btnTru.TabIndex = 7;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(489, 189);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(60, 50);
            btnNhan.TabIndex = 8;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(575, 189);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(60, 50);
            btnChia.TabIndex = 9;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(tbAns);
            Controls.Add(lblAns);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private Label lblAns;
        private TextBox tbAns;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
    }
}
