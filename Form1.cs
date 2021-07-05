using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassDataToAnotherForm1
{
    public partial class Form1 : Form
    {
        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setvaluetext1 = textBox1.Text;
            setvaluetext2 = textBox2.Text;
            setvaluetext3 = textBox3.Text;
            setvaluetext4 = textBox4.Text;

            //Now for displaying a input records into the next form

            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
