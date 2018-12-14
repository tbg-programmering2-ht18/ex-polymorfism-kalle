using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_polymorfism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            A obj;
            if (rbA.Checked)
            {
                obj = new A(); 
            }
            else
            {
                obj = new B();
            }

            if (obj is B)
            {
                textBox1.Text = (obj as B).Description();
            }
            else
            {
                textBox1.Text = obj.Description();
            }
        }
    }
}
