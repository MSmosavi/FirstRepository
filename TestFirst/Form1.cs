using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool i = true;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (i)
            {
                i = false;
                txtName.Text = txtName.Text +"  "+ txtName.Text;
                
                return;
            }
            i = true;
        }
    }
}
