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
    public partial class Form1 : Form
    {
        public static string title;
        public Form1()
        {
            InitializeComponent();
        }
        public static bool im1, im2, im3,tv1,tv2,tv3;
        public static int delete;
        public static string t1, t2, t3,name;
        public static List<string> shop = new List<string>();
        public static List<string> forum = new List<string>();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) MessageBox.Show("ΠΑΡΑΚΑΛΩ ΠΡΟΣΘΕΣΤΕ ΟΝΟΜΑ!");
            else if ((checkBox1.Checked == false) && (checkBox2.Checked == false)) MessageBox.Show("ΔΙΑΛΕΞΤΕ ΤΗΝ ΙΔΙΚΟΤΗΤΑ ΣΑΣ");
            else
            {
                name = textBox1.Text;
                if (checkBox1.Checked == true) { title = "pel"; Form2 f2 = new Form2(); f2.Show(); }
                else
                {
                    title = "ip";
                    if( (textBox1.Text.Equals("Tasos"))|| (textBox1.Text.Equals("Grigoris"))) { Form2 f3 = new Form2(); f3.Show(); }
                    else MessageBox.Show("ΛΑΘΟΣ ΟΝΟΜΑ ΥΠΑΛΛΗΛΟΥ");

                }
            }
        }

        private void checkBox2_MouseDown(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        {
            checkBox2.Checked = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            im1 = false;
            im2 = false;
            im3 = false;
            tv1 = false;
            tv2 = false;
            tv3 = false;
            t1 = "";
            t2 = "";
            t3 = "";
            delete = 0;
        }
    }
}
