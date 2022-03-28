using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap07032022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_tt_Click(object sender, EventArgs e)
        {
            if(TxtName.Text==string.Empty)
            {
                MessageBox.Show("Chua Nhap Ten");
            }
            else
            {
                int tt = 0;
                if(checkBox_caovoi.Checked == true )
                {
                    tt += 100000;
                }
                if(checkBox_taytrang.Checked==true)
                {
                    tt+=1200000;
                }
                if(checkBox_chaphinhrang.Checked==true)
                {
                    tt += 200000;
                }
                tt += Convert.ToInt32((comboBox_so_rang_chap.SelectedItem)) * 80000;
                label_total.Text=tt.ToString();
            }
        }

        private void button1_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
