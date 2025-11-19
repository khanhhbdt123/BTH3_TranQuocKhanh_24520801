namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterButton();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color newColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            this.BackColor = newColor;
        }
        private void CenterButton()
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
        }
    }
}