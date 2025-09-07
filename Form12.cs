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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

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

        private void Form12_Load(object sender, EventArgs e)
        {
            
            for(int i = 0; Form1.shop.Count > i; i+=4)
            {
                textBox2.Text = textBox2.Text + "HMEΡΟΜΗΝΙΑ  :" + Form1.shop[i] + Environment.NewLine + "KΩΔΙΚΟΣ  :" + Form1.shop[i+1] + Environment.NewLine + "ONOMA :"+ Form1.shop[i+2] + Environment.NewLine + "ΠΡΟΪΟΝ :"+ Form1.shop[i+3]+Environment.NewLine + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            if (textBox1.Text.Equals("")) MessageBox.Show("ΠΑΡΑΚΑΛΩ ΓΡΑΨΤΕ ΤΟΝ ΚΩΔΙΚΟ ΤΗΣ ΠΑΡΑΓΓΕΛΙΑΣ");
            else
            {
                for (int i = 1; Form1.shop.Count > i; i += 4)
                {
                    if (Form1.shop[i].Equals(textBox1.Text))
                    {
                        x = true;
                        Form1.shop[i] = Form1.shop[i] +" : " +"(ΟΛΟΚΛΗΡΩΜΕΝΗ)";
                        break;
                    }
                }
                if (x) MessageBox.Show("OK,O ΠΙΝΑΚΑΣ ΠΑΡΑΓΓΕΛΙΩΝ ΕΝΗΜΕΡΩΘΗΚΕ");
                else MessageBox.Show("ΔΕΝ ΥΠΑΡΧΕΙ ΠΑΡΑΓΓΕΛΙΑ ΜΕ ΑΥΤΟΝ ΤΩΝ ΚΩΔΙΚΟ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();f13.Show();
        }
    }
    
}


