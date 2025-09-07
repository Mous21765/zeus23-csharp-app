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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string p1, p2, t1, t2="";
        public static bool b1, b2 ,a1,a2= false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONLINE HELP" + Environment.NewLine + "ΠΑΤΑ ΤΟ ΚΟΥΜΠΊ ΠΙΣΊΝΑ ΓΙΑ ΝΑ ΔΕΙΣ ΤΙΣ ΛΕΙΤΟΥΡΓΙΕΣ ΤΗΣ " +
                "ΠΙΣΙΝΑΣ ή ΤΟ ΚΟΥΜΠΙ ΔΟΥΡΕΙΟΣ ΙΠΠΟΣ ΓΙΑ ΝΑ ΔΕΙΣ ΤΙΣ ΛΕΙΤΟΥΡΓΙΕΣ ΤΟΥ ΔΟΥΡΕΙΟΥ ΙΠΠΟΥ.ΕΧΙΤ ΓΙΑ ΕΞΟΔΟ!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();f7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form1.title.Equals("pel")) { Form9 f9 = new Form9(); f9.Show(); }
            else { Form12 f12 = new Form12(); f12.Show(); }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();f4.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
