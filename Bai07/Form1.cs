namespace Bai07
{
    public partial class Form1 : Form
    {
        private int[] trangThaiGhe = new int[16];
        private int[] giaVe = new int[16];
        private Button[] danhSachGhe = new Button[16];
        public Form1()
        {
            InitializeComponent();
            lblTT.Text = "0";
            for (int i = 1; i <= 15; i++)
            {
                trangThaiGhe[i] = 0;
            }
            for (int i = 1; i <= 5; i++) giaVe[i] = 5000;
            for (int i = 6; i <= 10; i++) giaVe[i] = 6500;
            for (int i = 11; i <= 15; i++) giaVe[i] = 8000;
            danhSachGhe[1] = btn1;
            danhSachGhe[2] = btn2;
            danhSachGhe[3] = btn3;
            danhSachGhe[4] = btn4;
            danhSachGhe[5] = btn5;
            danhSachGhe[6] = btn6;
            danhSachGhe[7] = btn7;
            danhSachGhe[8] = btn8;
            danhSachGhe[9] = btn9;
            danhSachGhe[10] = btn10;
            danhSachGhe[11] = btn11;
            danhSachGhe[12] = btn12;
            danhSachGhe[13] = btn13;
            danhSachGhe[14] = btn14;
            danhSachGhe[15] = btn15;
            for (int i = 1; i <= 15; i++)
            {
                danhSachGhe[i].BackColor = System.Drawing.Color.White;
            }
        }
        private void btnKT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == null) return;
            int soGhe = int.Parse(btn.Text);
            if (trangThaiGhe[soGhe] == 0)
            {
                trangThaiGhe[soGhe] = 1;
                btn.BackColor = System.Drawing.Color.Blue;
            }
            else if (trangThaiGhe[soGhe] == 1)
            {
                trangThaiGhe[soGhe] = 0;
                btn.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MessageBox.Show("Ghế số " + soGhe + " đã được bán. Vui lòng chọn ghế khác.");
                return;
            }
            long tongTien = 0;
            for (int i = 1; i <= 15; i++)
            {
                if (trangThaiGhe[i] == 1)
                {
                    tongTien += giaVe[i];
                }
            }
            lblTT.Text = tongTien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (trangThaiGhe[i] == 1)
                {
                    trangThaiGhe[i] = 0;
                    danhSachGhe[i].BackColor = System.Drawing.Color.White;
                }
            }
            lblTT.Text = "0";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (trangThaiGhe[i] == 1)
                {
                    trangThaiGhe[i] = 2;
                    danhSachGhe[i].BackColor= System.Drawing.Color.Yellow;
                }
            }
            lblTT.Text = "0";
            MessageBox.Show("Đã mua vé thành công!");
        }
    }
}
