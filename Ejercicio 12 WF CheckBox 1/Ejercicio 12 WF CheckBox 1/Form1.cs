using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12_WF_CheckBox_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Checked";
                MessageBox.Show("Checkbox True");
            }
            else
            {
                checkBox1.Text = "Unchecked";
                MessageBox.Show("Checkbox False");
            }
        }
    }
}
