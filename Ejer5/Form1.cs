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
        int cantidad;

        public Form1()
        {
            InitializeComponent();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIndices.Text = listBox1.SelectedIndex.ToString();

            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                
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
           
            ToolTip tooltip1 = new ToolTip();
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
            tooltip1.SetToolTip(this.listBox2,"Cant: "+listBox1.Items.Count);



        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            cantidad = listBox1.Items.Count;
            labelCantidad.Text = cantidad.ToString();
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
                    cantidad = listBox1.Items.Count;
                    labelCantidad.Text = cantidad.ToString();

                }
            }
        }

        private void TrasparAl2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indice = listBox1.SelectedIndices[i];
                string index = listBox1.SelectedItems[i].ToString();

                listBox2.Items.Insert(listBox1.SelectedIndex,index);
                listBox1.Items.RemoveAt(indice);
                labelCantidad.Text = listBox1.Items.Count.ToString();
            }
        }

        private void TraspasarAl1_Click(object sender, EventArgs e)
        {
            
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int indice = listBox2.SelectedIndices[i];
                string index = listBox2.SelectedItems[i].ToString();

                listBox1.Items.Insert(listBox2.SelectedIndex,index);
                listBox2.Items.RemoveAt(indice);
                labelCantidad.Text = listBox2.Items.Count.ToString();
               
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
