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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form1.title.Equals("ip"))
            {
                label4.Text = "ΠΙΣΙΝΑ ΠΕΛΑΤΗ";
                int x = r.Next(1,4);
                if (x.Equals(2))
                {
                    button4.Enabled = false;
                    label5.Visible = true;
                }
                x = r.Next(1,4);
                if (x.Equals(2))
                {
                    button5.Enabled = false;
                    label6.Visible = true;
                }
            }
            else
            {
                button4.Enabled = false;
                button1.Enabled = false;
            }
            if (Form2.b1)
            {
                comboBox1.Text = Form2.p1;
                comboBox2.Text = Form2.t1;
                if (Form2.p1.Equals("0%")) pictureBox3.Image = Properties.Resources.em;
            }
            if (Form2.b2)
            {
                comboBox4.Text = Form2.p2;
                comboBox3.Text = Form2.t2;
                if (Form2.p2.Equals("0%")) pictureBox4.Image = Properties.Resources.em;
            }
            if (Form2.a1)
            {
                button1.BackColor = Color.Green;
                button1.Text = "ALARM ON";
            }
            else
            {
                button1.BackColor = Color.Red;
                button1.Text = "ALARM OFF";
            }
            if (Form2.a2)
            {
                button3.BackColor = Color.Green;
                button3.Text = "ALARM ON";
            }
            else
            {
                button3.BackColor = Color.Red;
                button3.Text = "ALARM OFF";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if((comboBox1.Text.Equals("ΠΟΣΟΤΗΤΑ ΝΕΡΟΥ")) || (comboBox2.Text.Equals("ΘΕΡΜΟΚΡΑΣΙΑ ΝΕΡΟΥ")))               
            {
                MessageBox.Show("ΔΙΑΛΕΞΕ ΠΟΣΟΤΗΤΑ ΚΑΙ ΘΕΡΜΟΚΡΑΣΙΑ ΝΕΡΟΥ");
            }
            else
            {
                if (comboBox1.Text.Equals("0%")) pictureBox3.Image = Properties.Resources.em;
                else pictureBox3.Image = Properties.Resources.p2;
                MessageBox.Show("ΟΙ ΑΛΛΑΓΕΣ ΟΛΟΚΛΗΡΩΘΗΚΑΝ");
                Form2.b1 = true;
                Form2.p1 = comboBox1.Text.ToString();
                Form2.t1 = comboBox2.Text.ToString();

            }
                
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((comboBox4.Text.Equals("ΠΟΣΟΤΗΤΑ ΝΕΡΟΥ")) || (comboBox3.Text.Equals("ΘΕΡΜΟΚΡΑΣΙΑ ΝΕΡΟΥ")))
            {
                MessageBox.Show("ΔΙΑΛΕΞΕ ΠΟΣΟΤΗΤΑ ΚΑΙ ΘΕΡΜΟΚΡΑΣΙΑ ΝΕΡΟΥ");
            }
            else
            {
                if (comboBox4.Text.Equals("0%")) pictureBox4.Image = Properties.Resources.em;
                else pictureBox4.Image = Properties.Resources.p1;
                MessageBox.Show("ΟΙ ΑΛΛΑΓΕΣ ΟΛΟΚΛΗΡΩΘΗΚΑΝ");
                Form2.b2 = true;
                Form2.p2 = comboBox4.Text.ToString();
                Form2.t2 = comboBox3.Text.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("ALARM OFF"))
            {
                button1.BackColor = Color.Green;
                button1.Text ="ALARM ON";
                Form2.a1 = true;

            }
            else
            {
                Form2.a1 = false;
                button1.BackColor = Color.Red;
                button1.Text ="ALARM OFF";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Equals("ALARM OFF"))
            {
                button3.BackColor = Color.Green;
                button3.Text ="ALARM ON";
                Form2.a2 = true;

            }
            else
            {
                button3.BackColor = Color.Red;
                button3.Text ="ALARM OFF";
                Form2.a2 = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();f5.Show();
        }
    }
}
