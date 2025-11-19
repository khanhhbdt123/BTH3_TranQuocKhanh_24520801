namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = rnd.Next(0, this.ClientSize.Width - 100);
            y = rnd.Next(0, this.ClientSize.Height - 50);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 16, FontStyle.Bold);
            Brush brush = Brushes.Blue;
            g.DrawString("Paint Event", font, brush, x, y);
        }
    }
}