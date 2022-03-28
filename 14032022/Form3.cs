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
    
    public partial class Form3 : Form
    {
        public delegate void My_De(String s) ;
        public My_De d;
        public Form3()
        {
            InitializeComponent();
        }
         private void Load_Event_Button()
        {
            foreach(object i in this.Controls)
            {
                if( i is Button)
                {
                    ((Button)i).Click+=
                }
            }
        }
        private
        
    }
}
