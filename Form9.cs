using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zeus2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Random R = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;

            if (comboBox1.Text.Equals("") || comboBox2.Text.Equals("")) MessageBox.Show("ΣΥΜΠΛΗΡΩΣΕ ΤΑ ΣΤΟΙΧΕΙΑ ΠΟΥ ΛΕΙΠΟΥΝ!");
            else
            {
                if (comboBox2.Text.Equals("καρτα"))
                {
                    if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("")) MessageBox.Show("ΣΥΜΠΛΗΡΩΣΤΕ ΤΑ ΣΤΟΙΧΕΙΑ ΤΗΣ ΚΑΡΤΑΣ ΣΑΣ");
                    else { MessageBox.Show("Η ΠΑΡΑΓΓΕΛΕΙΑ ΕΓΙΝΕ ΜΕ ΕΠΙΤΥΧΙΑ");Form1.delete++; Form1.shop.Add(date1.ToString()); button1.Enabled = false;Form1.shop.Add(Form1.delete.ToString()) ; Form1.shop.Add(Form1.name); Form1.shop.Add(comboBox1.Text); };
                }
                else if ((comboBox2.Text.Equals("προσθηκη στον συν.λογαριασμό"))) { Form1.delete++; Form1.shop.Add(date1.ToString()); int x = R.Next(100, 1000); MessageBox.Show("OK,Ο συνολικος λογαριασμός σου είναι πλέον" + " " + x.ToString() + "$"); button1.Enabled = false;Form1.shop.Add(Form1.delete.ToString()); Form1.shop.Add(Form1.name); Form1.shop.Add(comboBox1.Text); }
                else { MessageBox.Show("Η ΠΑΡΑΓΓΕΛΕΙΑ ΕΓΙΝΕ ΜΕ ΕΠΙΤΥΧΙΑ");Form1.delete++;Form1.shop.Add(date1.ToString()) ; button1.Enabled = false;Form1.shop.Add(Form1.delete.ToString()); Form1.shop.Add(Form1.name); Form1.shop.Add(comboBox1.Text); };
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.Equals("καρτα")) groupBox1.Visible = true;
            else groupBox1.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int V = R.Next(1, 10);
            textBox4.Text = V.ToString() + "" + "$";
            button1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();f10.Show();
        }
    }
}
