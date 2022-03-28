using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14032022
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Show_Text(String s)
        {
            textBox1.Text = s;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.d = new Form3.My_De(Show_Text);

            f3.Show();

        }
    }
}
