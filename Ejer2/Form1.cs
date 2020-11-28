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
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
             == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
                {
                    this.Close();
                }  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form form1 = new Form();
                int color1 = Convert.ToInt32(textBox1.Text);
                int color2 = Convert.ToInt32(textBox2.Text);
                int color3 = Convert.ToInt32(textBox3.Text);

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
                form1.AcceptButton = button2;

            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");
               
            } 
           
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                string direccion = ruta.Text;
                labelImagen.BackgroundImage = new Bitmap(direccion);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Imagen no encontrada");
               
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Imagen no encontrada");
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

        private void ruta_Enter(object sender, EventArgs e)
        {
            Imagen.PerformClick();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
    }
}
