using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wf07032022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(textBox1.Text);
            if(listBox1.Items.IndexOf(textBox1.Text)>=0)
            {
                MessageBox.Show("TT");
            }
            else
            {
                comboBox1.Items.Add(textBox1.Text);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listBox1.SelectedItems.Count==1)
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);   
            //listBox1.SelectedItems.Remove(listBox1.SelectedItem);
            
        }
    }
}
