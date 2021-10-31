using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(textBox1.Text);
            int secondNumber = Convert.ToInt32(textBox2.Text);

            int result = firstNumber + secondNumber;

            textBox3.Text = Convert.ToString(result);
        }
    }
}
