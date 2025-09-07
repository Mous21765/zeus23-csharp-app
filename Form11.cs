using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zeus2
{
    public partial class Form11 : Form
    {
        public Form11()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) MessageBox.Show("ΓΡΕΨΕ ΠΡΩΤΑ ΤΟ ΜΗΝΥΜΑ ΠΟΥ ΘΕΣ ΝΑ ΣΤΕΙΛΕΙΣ");
            else
            {
                if (Form1.title.Equals("pel")) 
                {
                    if(textBox2.Text.Equals("") )textBox2.Text =Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine;
                    else textBox2.Text = textBox2.Text + Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine;
                    Form1.forum.Add(Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine);
                }
                else
                {
                    if (textBox2.Text.Equals("")) textBox2.Text = " Mr. " + Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine;
                    else  textBox2.Text = textBox2.Text +" Mr. "+ Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine;
                    Form1.forum.Add(" Mr. " + Form1.name.ToString() + " : " + textBox1.Text.ToString() + Environment.NewLine);
                }
                
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            for(int i=0;Form1.forum.Count>i;i++)
            {
                textBox2.Text += Form1.forum[i];
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ONLINE HELP" + Environment.NewLine + "Απο εδω γίνεται η εποικηνωνια μεταξη πρωσοπικού και υπαλληλων.Μπορεις " +
                "να στειλες οτι θες γραφωτας στο δευτερο κενο την απορια-απαντηση σου και επειτα το κουμπι send");
        }
    }
}
