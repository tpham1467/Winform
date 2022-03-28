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
    public partial class MainForm : Form
    {
        public delegate void S(object o1, object o2);
        public DataClass dataclass = new DataClass();
        public DataSv datasv = null ;
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                comboBox_lopsinhhoat.Items.Add ("20TCLC_DT" + i.ToString());
            }
        }
        private void Sort(int i)
        {
            if(i==0)
            {
                DataView dv = datasv.Sv.DefaultView;
                dv.Sort = "Ho Va Ten Desc";
                dataGridView1.DataSource = dv.ToTable();
                dataGridView1.Refresh();
            }
            else
            {
                DataView dv = datasv.Sv.DefaultView;
                dv.Sort = "Ma Sinh Vien Desc";
                dataGridView1.DataSource = dv.ToTable();
                dataGridView1.Refresh();
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            if(comboBox_Sort.SelectedIndex>=0)
            {
                if (comboBox_Sort.SelectedItem.ToString() == "Ten")
                    Sort(0);
                else Sort(1);
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {

                    dataGridView1.Rows.Remove(i);
                }
                dataGridView1.Refresh();
                MessageBox.Show("Xoa Thanh Cong");
            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if(textBox_search.Text!=null)
            {
                string searchValue = textBox_search.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                            {
                                int rowIndex = row.Index;
                                dataGridView1.Rows[rowIndex].Selected = true;
                                valueResult = true;
                                break;
                            }
                        }

                    }
                    if (!valueResult)
                    {
                        MessageBox.Show("Khong Tin Thay ");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }   
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            if (comboBox_lopsinhhoat.SelectedIndex>=0 )
            {
                dataGridView1.DataSource = dataclass.ListClass[comboBox_lopsinhhoat.SelectedIndex].Sv;
                dataGridView1.Refresh();
                datasv = dataclass.ListClass[comboBox_lopsinhhoat.SelectedIndex];
            }
        }
        public void Update(object [] o ,int i)
        {
            String lop_cu = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            int so_lop_cu = Convert.ToInt32 ( lop_cu[9]);
            String lop_moi = o[2].ToString();
            int so_lop_moi = Convert.ToInt32(lop_moi[9]);
            if (so_lop_cu != so_lop_moi)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                dataclass.ListClass[so_lop_moi-48].Sv.Rows.Add(o);
            }
            else
            {
                i = dataGridView1.SelectedRows[0].Index;
                datasv.Sv.Rows[i].ItemArray = o;
            }
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                DentailForm dt = new DentailForm();
                dt.Show();
                dt.Load_Data(dataGridView1.SelectedRows[0]);
                dt.u = Update;
            }
        }
        public void Add(object [] o ,int i)
        {
            datasv = dataclass.ListClass[i];
            datasv.Sv.Rows.Add(o);
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            
                DentailForm dt = new DentailForm();
                dt.Show();
                dt.A = Add;
            
        }
    }
}
