using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer5
{
    public partial class Form1 : Form
    {
        ToolTip tooltip1 = new ToolTip();
        string titulo = "Ejercicio5";
        int cont = 9;
        bool flag = true;
        bool entrada = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indices = "";

            if (listBox1.SelectedIndex != -1)
            {

                for (int i = 0; i <= listBox1.SelectedIndices.Count - 1; i++)
                {
                    indices += listBox1.SelectedIndices[i].ToString() + ",";

                }
                labelIndices.Text = indices;
            }
            else
            {
                labelIndices.Text = "Indices";

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Estas seguro de querer salir", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 1000;
            tooltip1.ReshowDelay = 500;
            tooltip1.ShowAlways = true;

            tooltip1.SetToolTip(this.btAñadir, "boton de añadir");
            tooltip1.SetToolTip(this.btQuitar, "boton de eliminar");
            tooltip1.SetToolTip(this.labelCantidad, "Cantida de elementos");
            tooltip1.SetToolTip(this.labelIndices, "Indices seleccionados");
            tooltip1.SetToolTip(this.TrasparAl2, "Se traspasa los elementos seleccionados al listbox2");
            tooltip1.SetToolTip(this.TraspasarAl1, "Se traspasa los elementos seleccionados al listbox1");
            tooltip1.SetToolTip(this.listBox1, "Lista de lementos del listbox1");
            tooltip1.SetToolTip(this.listBox2, "Cant: " + listBox2.Items.Count);
            tooltip1.SetToolTip(this.textBox1, "Introduce datos para añadir");



        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            labelCantidad.Text = listBox1.Items.Count.ToString();
            if (listBox1.SelectedIndices.Count == -1)
            {
                labelIndices.Text = "Indices";
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count != -1)
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int item = listBox1.SelectedIndices[i];
                    listBox1.Items.RemoveAt(item);
                    labelIndices.Text = "Indices";
                    labelCantidad.Text = listBox1.Items.Count.ToString();

                }
            }
        }

        private void TrasparAl2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indice = listBox1.SelectedIndices[i];
                string index = listBox1.SelectedItems[i].ToString();

                listBox2.Items.Insert(0, index);
                listBox1.Items.RemoveAt(indice);
                labelCantidad.Text = listBox1.Items.Count.ToString();
            }
            tooltip1.SetToolTip(listBox2, "Cant: " + listBox2.Items.Count);

        }

        private void TraspasarAl1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != -1)
            {

                for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int indice = listBox2.SelectedIndices[i];
                    string index = listBox2.SelectedItems[i].ToString();
                    listBox1.Items.Insert(0, index);
                    listBox2.Items.RemoveAt(indice);
                    labelCantidad.Text = listBox1.Items.Count.ToString();

                }
                tooltip1.SetToolTip(listBox2, "Cant: " + listBox2.Items.Count);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (cont < 0)
            {
                cont = 9;
                this.Text = "";
            }
            else
            {
                this.Text = this.Text.Insert(0, titulo[cont].ToString());
                cont--;
            }


            if (entrada)// entra una vez si y otra no 
            {
                entrada = false;

                if (flag)
                {
                    this.Icon = Icon.ExtractAssociatedIcon("mario.ico");
                    flag = false;
                }
                else
                {
                    this.Icon = Icon.ExtractAssociatedIcon("dragon.ico");
                    flag = true;
                }
            }
            else
            {
                entrada = true;
            }
        }
    }
}
