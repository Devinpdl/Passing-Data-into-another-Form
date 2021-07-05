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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.setvaluetext1;
            textBox2.Text = Form1.setvaluetext2;
            textBox3.Text = Form1.setvaluetext3;
            textBox4.Text = Form1.setvaluetext4;
        }
    }
}
