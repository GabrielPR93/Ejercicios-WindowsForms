using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Tag = Color.Red;
            button2.Tag = Color.Blue;
            Imagen.Tag = Color.ForestGreen;
            

        }
        private void Button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                int color1 = Convert.ToInt32(textBox1.Text);
                int color2 = Convert.ToInt32(textBox2.Text);
                int color3 = Convert.ToInt32(textBox3.Text);
                error.Text = "";

                if (color1<0 || color1>255)
                {
                    throw new FormatException();
                }else if (color2<0 || color2>255)
                {
                    throw new FormatException();
                }
                else if(color3<0 || color3>255)
                {
                    throw new FormatException();
                }

                BackColor = Color.FromArgb(color1, color2, color3);
                
            }
            catch (FormatException)
            {
                error.Text = "Error de formato";
                  
            }
            catch (OverflowException)
            {
                error.Text = "Numero demasiado grande";
                
            }
           
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                string direccion = ruta.Text;
                labelImagen.BackgroundImage = new Bitmap(direccion);
                error.Text = "";
            }
            catch (FileNotFoundException)
            {
                error.Text = "Imagen no encontrada";
              
               
            }
            catch (ArgumentException)
            {
                error.Text = "Ruta no valida";
            }

        }
        private void CambiarColorBotones(object sender,System.EventArgs e)
        {
            ((Button)sender).BackColor = (Color)((Button)sender).Tag;
        }
        private void CambiarColorBotonesSalir(object sender, System.EventArgs e)
        {
            ((Button)sender).BackColor = DefaultBackColor;
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            AcceptButton = button2;
            button2.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Ejercicio 2",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
               == DialogResult.Cancel)
            {
                e.Cancel=true;
            }

        }

        private void ruta_Enter(object sender, EventArgs e)
        {
            AcceptButton = Imagen;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            AcceptButton = button2;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            AcceptButton = button2;
        }
    }
}
