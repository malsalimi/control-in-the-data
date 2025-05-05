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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(textBox1.Text))
             MessageBox.Show("موجود بالكمبوبوكس");   
            else
            MessageBox.Show(" غير موجود بالكمبوبوكس");
            if (listBox1.Items.Contains(textBox1.Text))
                MessageBox.Show("موجود ب ليست بوكس");
            else
            MessageBox.Show("غير موجود ب ليست بوكس");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items[comboBox1.SelectedIndex] = textBox1.Text;
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
