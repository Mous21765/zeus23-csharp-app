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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int front, left = 0;
        public static string p, s = "";
        public static bool b = false;

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

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            front++;
            if (front==5)
            {
                pictureBox9.Visible = false;
                pictureBox8.Visible = true;
                pictureBox5.Visible = false;
                MessageBox.Show("ΜΟΛΙΣ ΕΦΤΑΣΕΣ ΣΤΟ ΠΡΟΑΥΛΙΟ ΤΟΥ ΝΑΟΥ");
                front = 0;
                left = 0;
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            left++;
            if((left==2) && (front > 2))
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox5.Visible = false;
                MessageBox.Show("ΜΟΛΙΣ ΕΦΤΑΣΕΣ ΣΤΟ ΚΥΠΟ ΤΟΥ ΟΛΥΜΠΟΥ");
                front = 0;
                left = 0;
            }
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();f6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΠΡΟΑΥΛΙΟ ΝΑΟΥ ΔΙΑ" + "\n" + "ΠΑΤΑ 5 ΦΟΡΕΣ ΤΟ ΚΟΥΜΠΙ ΜΠΡΟΣΤΑ ΕΤΣΙ ΩΣΤΕ ΝΑ ΠΑΣ ΣΤΟ ΠΡΟΑΥΛΙΟ ΤΟΥ ΝΑΟΥ" + "\n"+ "\n" + "ΚΥΠΟΣ ΟΛΥΜΠΟΥ" + "\n" + "ΠΑΤΑ" +
                "3 ΦΟΡΕΣ ΤΟ ΚΟΥΜΠΙ ΜΠΡΟΣΤΑ ΚΑΙ 2 ΤΟ ΔΕΞΙΑ ΓΙΑ ΝΑ ΠΑΣ ΣΤΟΝ ΚΥΠΟ ΤΟΥ ΟΛΥΜΠΟΥ");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("ΠΟΡΤΕΣ") || comboBox2.Text.Equals("ΣΚΑΛΑ"))
            {
                MessageBox.Show("ΣΥΜΠΛΗΡΩΣΕ ΤΑ ΣΤΟΙΧΕΙΑ");
            
            }
            else
            {
                b = true;
                p = comboBox1.SelectedItem.ToString();
                s = comboBox2.SelectedItem.ToString();
                MessageBox.Show("OI ΑΛΛΑΓΕΣ ΕΓΙΝΑΝ ΜΕ ΕΠΙΤΥΧΙΑ");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            front = 0; left = 0;
            if (b==true) { comboBox1.Text = p;comboBox2.Text = s; }
        }
    }
}
