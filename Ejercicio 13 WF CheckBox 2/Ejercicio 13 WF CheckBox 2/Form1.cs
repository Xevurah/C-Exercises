using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13_WF_CheckBox_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDynamicCheckBox();
        }
        public void CreateDynamicCheckBox()
        {
            //Create Checkbox Object
            CheckBox dynamicCheckBox = new CheckBox();

            //Set properties
            dynamicCheckBox.Location = new Point(20, 150);
            dynamicCheckBox.Height = 150;
            dynamicCheckBox.Width = 300;

            //Set Background and Foreground
            dynamicCheckBox.BackColor = Color.Red;
            dynamicCheckBox.ForeColor = Color.Blue;

            //Set Name, Text, alignment
            dynamicCheckBox.Name = "DynamicCheckBox";
            dynamicCheckBox.Text = "I am a Dynamic CheckBox";
            dynamicCheckBox.TextAlign = ContentAlignment.MiddleCenter;

            //Set Check Mark Alignment
            dynamicCheckBox.CheckAlign = ContentAlignment.TopCenter;
            dynamicCheckBox.TextAlign = ContentAlignment.TopRight;

            //Set Font
            dynamicCheckBox.Font = new Font("Console", 16);

            //Assign an image to the CheckBox
            dynamicCheckBox.Image = Image.FromFile(@"C:\Users\ali_5\Pictures\dino.png");

            //Align image
            dynamicCheckBox.ImageAlign = ContentAlignment.BottomCenter;

            //Add
            Controls.Add(dynamicCheckBox);
        }
    }
}
