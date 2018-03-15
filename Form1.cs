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
        /*
         * The global field denominator, the number ther numerator will be added to.
         */
        private int denominator;

        /*
         * The global field numerator, the number the denominator will add to.
         */
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

        /*
         * Invoked when the text box you input the demoniator changes.
         * This is the event definition, so when text in inputted, it is triggered and
         * then the trigger invoked this method every time a new characters is inputted 
         * into the box.
         * 
         * Within this event definition, it will check if the text inputted is parsable 
         * to an integer. If the text is not parsable, it will output a message to the console
         * otherwise it will assign the new value in the text box to the denominator and output
         * a message to the console saying it is an interger.
         *  
         */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            
            if (int.TryParse(box.Text, out denominator))
            {
                denominator = int.Parse(box.Text);
                Console.WriteLine("Input is an integer.");
            }
            else
            {
                Console.WriteLine("Is not an integer."); 
            }
        }

        /*
         * When the button to add the denominator and numerator is clicked, it will trigger the event provider
         * to invoke the event that the button is binded to. As this is the event definition for the button,
         * this method will be invoked.  
         * 
         * Within this method definiton, before it adds the numrator and denominator, it checks that both
         * fields are not zero (0). If they are it will not display the result. If it isn't it will
         * add the numerator and denominator together and assign that result to a local field named
         * 'result' It will then assign that value, while converting it into text, to the text box.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (numerator != 0 && denominator != 0)
            {
                int result = numerator + denominator;

                textBox3.Text = result.ToString();
                Controls.Add(textBox3);
            }
        }

        /*
         * Invoked when the text box you input the numerator changes.
         * This is the event definition, so when text in inputted, it is triggered and
         * then the trigger invoked this method every time a new characters is inputted 
         * into the box.
         * 
         * Within this event definition, it will check if the text inputted is parsable 
         * to an integer. If the text is not parsable, it will output a message to the console
         * otherwise it will assign the new value in the text box to the numerator and output
         * a message to the console saying it is an interger.
         *  
         */
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