using System.Globalization;
namespace Bai06
{
    public partial class Form1 : Form
    {
        double soHienTai = 0;
        double soLuu = 0;
        string phepTinh = "";
        bool vuaBamBang = false;
        public Form1()
        {
            InitializeComponent();
            tbHien.Text = "";
        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (vuaBamBang)
            {
                tbHien.Text = btn.Text;
                soLuu = 0;
                phepTinh = "";
            }
            else if (string.IsNullOrEmpty(tbHien.Text) || tbHien.Text == "0")
            {
                tbHien.Text = btn.Text;
            }
            else
            {
                tbHien.Text += btn.Text;
            }
            vuaBamBang = false;
        }
        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!tbHien.Text.Contains("."))
                tbHien.Text += ".";
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            if (tbHien.Text.StartsWith("-"))
            {
                tbHien.Text = tbHien.Text.Substring(1);
            }
            else if (tbHien.Text != "0")
            {
                tbHien.Text = "-" + tbHien.Text;
            }
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(phepTinh))
            {
                soHienTai = double.Parse(string.IsNullOrEmpty(tbHien.Text) ? "0" : tbHien.Text, CultureInfo.InvariantCulture);
                double kq = 0;
                try
                {
                    switch (phepTinh)
                    {
                        case "+":
                            kq = soLuu + soHienTai;
                            break;
                        case "-":
                            kq = soLuu - soHienTai;
                            break;
                        case "*":
                            kq = soLuu * soHienTai;
                            break;
                        case "/":
                            if (soHienTai == 0)
                            {
                                MessageBox.Show("Lỗi: Không thể chia cho 0!");
                                soLuu = 0;
                                phepTinh = "";
                                tbHien.Text = "";
                                return;
                            }
                            kq = soLuu / soHienTai;
                            break;
                    }
                    soLuu = kq;
                    tbHien.Text = kq.ToString(CultureInfo.InvariantCulture);
                }
                catch
                {
                    MessageBox.Show("Lỗi: Đầu vào không hợp lệ!");
                    soLuu = 0;
                    phepTinh = "";
                    tbHien.Text = "";
                    return;
                }
            }
            else
            {
                soLuu = double.Parse(string.IsNullOrEmpty(tbHien.Text) ? "0" : tbHien.Text, CultureInfo.InvariantCulture);
            }
            phepTinh = btn.Text;
            tbHien.Text = "";
            vuaBamBang = false;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            soHienTai = double.Parse(string.IsNullOrEmpty(tbHien.Text) ? "0" : tbHien.Text, CultureInfo.InvariantCulture);
            double kq = soHienTai;
            try
            {
                switch (phepTinh)
                {
                    case "+":
                        kq = soLuu + soHienTai;
                        break;
                    case "-":
                        kq = soLuu - soHienTai;
                        break;
                    case "*":
                        kq = soLuu * soHienTai;
                        break;
                    case "/":
                        if (soHienTai == 0)
                        {
                            MessageBox.Show("Lỗi: Không thể chia cho 0!");
                            return;
                        }
                        kq = soLuu / soHienTai;
                        break;
                }
                tbHien.Text = kq.ToString(CultureInfo.InvariantCulture);
                soLuu = kq;
                phepTinh = "";
                vuaBamBang = true;
            }
            catch
            {
                MessageBox.Show("Đầu vào không hợp lệ!");
            }

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (tbHien.Text.Length > 1)
            {
                tbHien.Text = tbHien.Text.Substring(0, tbHien.Text.Length - 1);
            }
            else
            {
                tbHien.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbHien.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbHien.Text = "";
            soHienTai = 0;
            soLuu = 0;
            phepTinh = "";
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            double x = double.Parse(tbHien.Text, CultureInfo.InvariantCulture);
            if (x < 0)
            {
                MessageBox.Show("Lỗi: Không thể căn bậc 2 số âm!");
                return;
            }
            double kq = Math.Sqrt(x);
            tbHien.Text = kq.ToString(CultureInfo.InvariantCulture);
            vuaBamBang = true;
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbHien.Text, CultureInfo.InvariantCulture);
                if (phepTinh != "")
                {
                    x = soLuu * x / 100.0;
                }
                else
                {
                    x = x / 100.0;
                }
                tbHien.Text = x.ToString(CultureInfo.InvariantCulture);
                vuaBamBang = false;
            }
            catch
            {
                MessageBox.Show("Lỗi: Đầu vào không hợp lệ!");
            }
        }
        private void btnND_Click(object sender, EventArgs e)
        {
            double x = double.Parse(tbHien.Text, CultureInfo.InvariantCulture);
            if (x == 0)
            {
                MessageBox.Show("Lỗi: Không thể chia 1 cho 0!");
                return;
            }
            double kq = 1 / x;
            tbHien.Text = kq.ToString(CultureInfo.InvariantCulture);
            vuaBamBang = true;
        }
    }
}