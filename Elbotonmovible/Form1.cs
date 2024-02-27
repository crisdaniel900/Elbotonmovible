using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elbotonmovible
{
    public partial class Form1 : Form
    {
        private int velocidadX = 5; // Velocidad horizontal del botón
        private int velocidadY = 5; // Velocidad vertical del botón
        private int velocidadX1 = 5;
        private int velocidadY1 = 5;


        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicia el temporizador cuando se carga el formulario
            timer1.Start();
            label1.Visible = false; // Etiqueta Inicia como Falso para que no se vea

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mueve el botón
            button1.Left += velocidadX;
            button1.Top += velocidadY;
            

            // Derecha
            if (button1.Right >= ClientSize.Width)
            {
                velocidadX = -velocidadX; // Cambia la dirección horizontal para rebote
            }

            //Izquierda
            else if (button1.Left <= 0)
            {
                velocidadX = -velocidadX; // Cambia la dirección horizontal para rebote
            }

            // Abajo
            if (button1.Bottom >= ClientSize.Height)
            {
                velocidadY = -velocidadY; // Cambia la dirección vertical para rebote
            }


            

            //Arriba
            else if (button1.Top <= 0)
            {
                velocidadY = -velocidadY; // Cambia la dirección vertical para rebote
                
                    label1.Visible = true;
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            // Boton 2

            button2.Left += velocidadX1;
            button2.Top += velocidadY1;

            // Derecha
            if (button2.Right >= ClientSize.Width)
            {
                velocidadX1 = -velocidadX1; // Cambia la dirección horizontal para rebote
            }

            //Izquierda
            else if (button2.Left <= 0)
            {
                velocidadX1 = -velocidadX1; // Cambia la dirección horizontal para rebote
            }

            // Abajo
            if (button2.Bottom >= ClientSize.Height)
            {
                velocidadY1 = -velocidadY1; // Cambia la dirección vertical para rebote
                BackColor = Color.DarkBlue;
            }

            //Arriba
            else if (button2.Top <= 0)
            {
                velocidadY1 = -velocidadY1; // Cambia la dirección vertical para rebote
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}