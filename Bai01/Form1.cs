namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("1. Constructor: Form1() - Khoi tao form1.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("2. Load: Form1_Load - Nap du lieu cho form1.");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Add("3. Activated: Form1_Activated - Form1 duoc kich hoat.");  
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Add("4. Shown: Form1_Shown - Mo form lan dau.");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            listBox1.Items.Add("5. Deactivate: Form1_Deactivate - Form1 tam thoi mat focus.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Add("6. Closing: Form1_FormClosing - Form1 dang dong.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Add("7. Closed: Form1_FormClosed - Form1 da dong.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Click: Kich hoat form2.");
            Form f2 = new Form2(listBox1);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}