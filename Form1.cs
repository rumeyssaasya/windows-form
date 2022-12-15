using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1odev2
{
    public partial class Form1 : Form

    {
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string harf = textBox1.Text; 

            if(harf == "a"|| harf == "e" || harf == "ı" || harf == "i" || harf == "u" || harf == "ü" || harf == "o" || harf == "ö")

            {
                listBox1.Items.Clear();

                textBox2.Text = "Sesli harf girdiniz...";

                listBox1.Items.Add(harf);

                textBox1.Clear();

            }

            else if(harf.Length > 1)

            {
                listBox1.Items.Clear();

                listBox1.Items.Add(harf);

                textBox1.Clear();

                textBox2.Text = "Lütfen harf giriniz...";

            }

            else

            {
                listBox1.Items.Clear();

                listBox1.Items.Add(harf);

                textBox2.Text = "Sessiz harf girdiniz...";

                textBox1.Clear();
            }
        }
    }
}
