using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
namespace BaiTapVeNha
{
    public partial class Form1 : Form
    {
        string log = "1234" ;
        public Form1()
        {
            InitializeComponent();
            Read_File();
            Load_Event();
			Load_Event()
        }
        
        public void Read_File()
        {


            FileInfo theSourceFile = new FileInfo(@"..\..\Log.txt");
            StreamReader stream = theSourceFile.OpenText();
            string text;
            do
            {
                text = stream.ReadLine();
                if (text != null)
                    listBox_AccessLog.Items.Add(text);
            } while (text != null);
            stream.Close();
        }
        public void Write_File()
        {
            StreamWriter writer = new StreamWriter(@"..\..\Log.txt", false);

            for (int i=0;i<listBox_AccessLog.Items.Count;i++)
            {
                writer.WriteLine(listBox_AccessLog.Items[i].ToString());
            }
            
            writer.Close();
        }
        private void Load_Event()
        {
            // add button click event to all buttons
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }
        public void btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!button.Text.Equals("A")&&!button.Text.Equals("C"))
            {
                if(textBox_SecurityCode.Text.Length!=4)

                textBox_SecurityCode.Text += button.Text;
            }
            else
            {
                if(button.Text.Equals("A"))
                {
                    DateTime d = DateTime.Now;
                    if (string.Compare(log,textBox_SecurityCode.Text)==0)
                    {
                  
                        string tb =d.ToString()+"    "+ "Successful";
                        
                        this.listBox_AccessLog.Items.Add(tb);

                    }
                    else
                    {
                        string tb = d.ToString() + "    "+"Unsuccessful";
                        this.listBox_AccessLog.Items.Add(tb);
                    }
                }
                else
                {
                    textBox_SecurityCode.Text = null;
                }
            }
        }
    }
        
}
