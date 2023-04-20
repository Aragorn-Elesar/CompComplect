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
    public partial class Katagol : Form
    {
        Tovar t = new Tovar();
        bool c;
        public Katagol()
        {
            InitializeComponent();
            
        }

        private void AddPbutton_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm(t, false);
            if(form.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.Add(t);
            }
        }

        private void EditPbutton_Click(object sender, EventArgs e)
        {
            int poss = comboBox1.SelectedIndex;
            InfoForm infoForm = new InfoForm(t, true);
            if(infoForm.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Items.RemoveAt(poss);
                comboBox1.Items.Insert(poss, t);
            }
        }

        private void AddListbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void Totalpricebutton_Click(object sender, EventArgs e)
        {
            double totalprice = 0;
            foreach (var item in listBox1.Items)
            {
                var tovar = item as Tovar;
                totalprice += tovar.Price;
            }
            MessageBox.Show(totalprice.ToString());
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = (ComboBox)sender;
            var price = (Tovar)tmp.SelectedItem;
            if(price.Price > 0)
            {
                textBox1.Text = price.Price.ToString(); 
            }
            else
            {
                MessageBox.Show("dfsfgdf");
            }
        }
    }
}
