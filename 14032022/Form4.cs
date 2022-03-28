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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Data_view();
        }
        public void Data_view()
        {
            List<Sv> data = new List<Sv>();
            data.AddRange(new Sv[]
            {
                new Sv { _Name = "A",_Mssv="1", _Gender ="1", _Name_Class= "Z"},
                new Sv { _Name = "B",_Mssv="2", _Gender ="2", _Name_Class= "Y"}
            }
                );
            listView1.Columns.AddRange(new ColumnHeader[]
            {
                new ColumnHeader { Text ="Ten "},
                 new ColumnHeader { Text ="Ma Sinh Vien"},
                  new ColumnHeader { Text ="Gioi Tinh"},
                   new ColumnHeader { Text ="Ten Lop"}
            }
                );
            // foreach(Sv i in data)
            //{
            //    ListViewItem j = new ListViewItem(i._Name);
            //    j.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            //    {
            //      //  new ListViewItem.ListViewSubItem{ Text = i._Name},
            //        new ListViewItem.ListViewSubItem{ Text = i._Mssv},
            //        new ListViewItem.ListViewSubItem{ Text = i._Gender},
            //        new ListViewItem.ListViewSubItem{ Text = i._Name_Class}
            //    });
            //    listView1.Items.Add(j);
            //}
            dataGridView1.DataSource = data;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = "";

            if (listView1.SelectedItems.Count > 0)
            {
               
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    data += i.Text + " " + i.SubItems[1].Text+"\n";
                }
                MessageBox.Show(data);
            }
        }
    }
}
