using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9_WF_Ejemplo_boton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDynamicButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateDynamicButton()
        {
            //instancia nuevo objeto clase botón
            Button dynamicButton = new Button();

            //definir las propiedades del botón
            //altura y ancho
            dynamicButton.Height = 150;
            dynamicButton.Width = 300;

            //colores de fondo y fuente
            dynamicButton.BackColor = Color.Blue;
            dynamicButton.ForeColor = Color.Yellow;

            //definir la posición del botón
            dynamicButton.Location = new Point(20, 150);

            //texto del botón
            dynamicButton.Text = "I am a Dynamic button";

            //estilo y tamaño de la fuente del texto
            dynamicButton.Font = new Font("Georgia", 16);

            //nombre del botón
            dynamicButton.Name = "DynamicButton";

            //agregar una imagen dentro del botón
            dynamicButton.Image = Image.FromFile(@"C:\Users\ali_5\Pictures\dino.png");
            //C:\Users\ali_5\Pictures\dino.png

            //agregar un controlador 
            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            //añadir y colocar el botón en el formulario
            Controls.Add(dynamicButton);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dynamic Button is clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Static button is clicked");
            this.Close();
        }
    }
}
