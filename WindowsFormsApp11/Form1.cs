using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class InfoForm : Form
    {
        Tovar t;
        bool c;
        public InfoForm(Tovar t, bool c)
        {
            InitializeComponent();
            this.t = t;
            this.c = c;
            if (c == true)
            {
                textBox1.Text = t.Name;
                textBox2.Text = t.Сharacteristic;
                textBox3.Text = t.Info;
                textBox4.Text = t.Price.ToString();
            }
            else
            {
                textBox1.Text = t.Name;
                textBox2.Text = t.Сharacteristic;
                textBox3.Text = t.Info;
                textBox4.Text += t.Price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Ok button
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Сharacteristic field is empty");
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Info filed is empty");
                return;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Price field is empty");
                return;
            }
            if (t == null)
            {
                t = new Tovar();
            }
            t.Name = textBox1.Text;
            t.Сharacteristic = textBox2.Text;
            t.Info = textBox3.Text;
            if(Double.TryParse(textBox4.Text, out double d) && d > 0)
            {
                t.Price = d;
            }
            this.DialogResult = DialogResult.OK;
            
        }

        private void button2_Click(object sender, EventArgs e) // Cancel button
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
