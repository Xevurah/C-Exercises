using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10_WF_Ejemplo_de_un_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDynamicLabel();
        }

        private void CreateDynamicLabel()
        {
            //instancia de un nuevo objeto tipo label o etiqueta
            Label dynamicLabel = new Label();
            dynamicLabel.Name = "DynamicLabel";

            //definir los colores de fondo y de fuente
            dynamicLabel.BackColor = Color.Black;
            dynamicLabel.ForeColor = Color.White;

            //definimos el texto dentro de la etiqueta
            dynamicLabel.Text = "I am a Dynamic Label";

            //definimos el estilo de la fuente
            dynamicLabel.Font = new Font("Console", 16);

            //definimos la posicion de la etiqueta
            dynamicLabel.Location = new Point(20, 150);

            //definimos alto y ancho de la etiqueta
            dynamicLabel.Height = 40;
            dynamicLabel.Width = 300;

            //añadir la etiqueta al formulario
            Controls.Add(dynamicLabel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
