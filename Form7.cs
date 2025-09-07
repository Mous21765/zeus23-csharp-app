using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zeus2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Form1.im1) { pictureBox3.Image = Properties.Resources.b2;Form1.im1 = false; }
            else { pictureBox3.Image = Properties.Resources.b1; Form1.im1 = true; }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Form1.im2) { pictureBox4.Image = Properties.Resources.lr2; Form1.im2 = false; }
            else { pictureBox4.Image = Properties.Resources.lr1; Form1.im2 = true; }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Form1.im3) { pictureBox5.Image = Properties.Resources.tr2; Form1.im3 = false; }
            else { pictureBox5.Image = Properties.Resources.tr1; Form1.im3 = true; }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {         
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible) groupBox1.Visible = false;
            else groupBox1.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible) groupBox3.Visible = false;
            else groupBox3.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible) groupBox2.Visible = false;
            else groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Βαθμοί")) MessageBox.Show("ΔΙΑΛΕΞΕ ΒΑΘΜΟΥΣ ΓΙΑ ΤΟ AIR-CODITION");
            else
            {
                Form1.t1 = comboBox1.Text;
                if (comboBox1.Text.Equals("0 C") || comboBox1.Text.Equals("10 C")) pictureBox14.Image = Properties.Resources.air3;
                else pictureBox14.Image = Properties.Resources.air2;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.t1 = "";
            pictureBox14.Image = Properties.Resources.air;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Equals("Βαθμοί")) MessageBox.Show("ΔΙΑΛΕΞΕ ΒΑΘΜΟΥΣ ΓΙΑ ΤΟ AIR-CODITION");
            else
            {
                Form1.t3 = comboBox3.Text;
                if (comboBox3.Text.Equals("0 C") || comboBox3.Text.Equals("10 C")) pictureBox13.Image = Properties.Resources.air3;
                else pictureBox13.Image = Properties.Resources.air2;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.t3 = "";
            pictureBox13.Image = Properties.Resources.air;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Equals("Βαθμοί")) MessageBox.Show("ΔΙΑΛΕΞΕ ΒΑΘΜΟΥΣ ΓΙΑ ΤΟ AIR-CODITION");
            else
            {
                Form1.t2 = comboBox2.Text;
                if (comboBox2.Text.Equals("0 C") || comboBox2.Text.Equals("10 C")) pictureBox12.Image = Properties.Resources.air3;
                else pictureBox12.Image = Properties.Resources.air2;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.t2 = "";
            pictureBox12.Image = Properties.Resources.air;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (Form1.title.Equals("pel")) { pictureBox13.Enabled = false; pictureBox6.Enabled = false; pictureBox4.Enabled = false; }

            //Για air-codition
            if ((Form1.t1.Equals("0 C"))||( Form1.t1.Equals("10 C"))) { pictureBox14.Image = Properties.Resources.air3; comboBox1.Text = Form1.t1; }
            else if (Form1.t1.Equals("")) pictureBox14.Image = Properties.Resources.air;
            else { pictureBox14.Image = Properties.Resources.air2; comboBox1.Text = Form1.t1; }

            if ((Form1.t2.Equals("0 C") )|| (Form1.t2.Equals("10 C"))) { pictureBox12.Image = Properties.Resources.air3; comboBox2.Text = Form1.t2; }
            else if (Form1.t2.Equals("")) pictureBox12.Image = Properties.Resources.air;
            else { pictureBox12.Image = Properties.Resources.air2; comboBox2.Text = Form1.t2; }

            if ((Form1.t3.Equals("0 C")) ||( Form1.t3.Equals("10 C"))) { pictureBox13.Image = Properties.Resources.air3; comboBox3.Text = Form1.t3; }
            else if (Form1.t3.Equals("")) pictureBox13.Image = Properties.Resources.air;
            else { pictureBox13.Image = Properties.Resources.air2; comboBox3.Text = Form1.t3; }

            //Για τα φωτα
            if (Form1.im1) { pictureBox3.Image = Properties.Resources.b1;}
            else { pictureBox3.Image = Properties.Resources.b2; }

            if (Form1.im2) { pictureBox4.Image = Properties.Resources.lr1; }
            else { pictureBox4.Image = Properties.Resources.lr2;}

            if (Form1.im3) { pictureBox5.Image = Properties.Resources.tr1; }
            else { pictureBox5.Image = Properties.Resources.tr2;}

            //Για την ΤV
            if (Form1.tv1) { pictureBox8.Image = Properties.Resources.tel2; }
            else { pictureBox8.Image = Properties.Resources.tel; }

            if (Form1.tv2) { pictureBox6.Image = Properties.Resources.tel2; }
            else { pictureBox6.Image = Properties.Resources.tel; }

            if (Form1.tv3) { pictureBox7.Image = Properties.Resources.tel2; }
            else { pictureBox7.Image = Properties.Resources.tel; }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form1.tv1) { pictureBox8.Image = Properties.Resources.tel; Form1.tv1 = false; }
            else { pictureBox8.Image = Properties.Resources.tel2; Form1.tv1 = true; }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form1.tv2) { pictureBox6.Image = Properties.Resources.tel; Form1.tv2 = false; }
            else { pictureBox6.Image = Properties.Resources.tel2; Form1.tv2 = true; }
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
         
            if (Form1.tv3) { pictureBox7.Image = Properties.Resources.tel; Form1.tv3 = false; }
            else { pictureBox7.Image = Properties.Resources.tel2; Form1.tv3 = true; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();f8.Show();
        }
    }
}
