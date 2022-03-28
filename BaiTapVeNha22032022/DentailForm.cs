using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap22032022
{
    public partial class DentailForm : Form
    {
       
        public delegate void _delegate(object [] o, int i);
        public _delegate u;
        public _delegate A;
        int c = 1;
        public DentailForm()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add("20TCLC_DT" + i.ToString());
            }
            
        }
        public void Load_Data(DataGridViewRow r)
        {
            textBox_mssv.Text = r.Cells[0].Value.ToString();
            textBox_name.Text = r.Cells[1].Value.ToString();
            String s1 = r.Cells[2].Value.ToString();
            int i = Convert.ToInt32(s1[9])-48;
            comboBox1.SelectedIndex = i;
            if (Convert.ToBoolean (r.Cells[3].Value)==true)
            {
                radioButton_male.Checked = true;
            }
            else
            {
                radioButton_female.Checked = true;
            }
            dateTimePicker1.Value = Convert.ToDateTime ( r.Cells[4].Value);
            textBox1.Text= r.Cells[5].Value.ToString();
            String[] s = r.Cells[6].Value.ToString().Split(' ');
            checkbox_anh.Checked = Convert.ToBoolean(s[0]);
            checkBox_hocba.Checked = Convert.ToBoolean(s[1]);
            checkBox_cc.Checked = Convert.ToBoolean(s[2]);
            c = 0;

        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length == 0)
            {
                MessageBox.Show("Chua Nhap Ho Va Ten");
            }
            else if (textBox_mssv.Text.Length == 0)
            {
                MessageBox.Show("Chua Nhap Ma Sinh Vien");
            }
            else if (radioButton_female.Checked == false && radioButton_male.Checked == false)
            {
                MessageBox.Show("Chua Chon Gioi Tinh");
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Chua Nhap Diem Trung Binh");
            }
            else
            {


                object[] value = new object[7];
                value[0] = Convert.ToInt32(textBox_mssv.Text);
                value[1] = textBox_name.Text;
                value[2] = comboBox1.SelectedItem.ToString();
                value[3] = (radioButton_female.Checked == false) ? radioButton_female.Checked : radioButton_male.Checked;
                value[4] = dateTimePicker1.Value;
                value[5] = Convert.ToDouble(textBox1.Text);
                value[6] = new HoSo()
                {

                    Anh = checkbox_anh.Checked,
                    hoc_ba = checkBox_hocba.Checked,
                    Cc_nn = checkBox_cc.Checked

                };
                
                if(c==0)
                {
                    u(value, 0);
                }
                else
                A(value , comboBox1.SelectedIndex);
                this.Close();

            }
             
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
