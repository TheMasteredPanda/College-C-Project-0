using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        private int denominator;
        private int numerator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            
            if (int.TryParse(box.Text, out denominator))
            {
                Console.WriteLine("Input is an integer.");
                denominator = int.Parse(box.Text);
            } else
            {
                Console.WriteLine("Is not an integer."); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numerator != 0 && denominator != 0)
            {
                int result = numerator + denominator;

                textBox3.Text = result.ToString();
                Controls.Add(textBox3);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;

            if (int.TryParse(box.Text, out numerator))
            {
                Console.WriteLine("Input is an integer.");
                numerator = int.Parse(box.Text);
            }
            else
            {
                Console.WriteLine("Is not an integer.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
