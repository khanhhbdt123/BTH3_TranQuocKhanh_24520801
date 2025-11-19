namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbNum1.Text);
            double b = double.Parse(tbNum2.Text);
            tbAns.Text = Math.Round(a + b, 2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbNum1.Text);
            double b = double.Parse(tbNum2.Text);
            tbAns.Text = Math.Round(a - b, 2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbNum1.Text);
            double b = double.Parse(tbNum2.Text);
            tbAns.Text = Math.Round(a * b, 2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbNum1.Text);
            double b = double.Parse(tbNum2.Text);
            if (b == 0) MessageBox.Show("Khong the thuc hien phep chia.");
            else tbAns.Text = Math.Round(a / b, 2).ToString();
        }
    }
}
