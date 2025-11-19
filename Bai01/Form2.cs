using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form2 : Form
    {
        private ListBox listBox1;
        public Form2(ListBox lb)
        {
            InitializeComponent();
            this.listBox1 = lb;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Add("3.5. Activated: Form2_Activated - Form2 duoc kich hoat.");
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            listBox1.Items.Add("5.5 Deactivate: Form2_Deactivate - Form2 mat focus, chuyen ve form1.");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Add("6.5 Closing: Form2_FormClosing - Form2 dang dong.");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Add("7.5 Closed: Form2_FormClosed - Form2 da dong.");
        }
    }
}