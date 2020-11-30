using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Form1 : Form
    {
        public string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea salir ??","Salir",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult res;
            

            using (OpenFileDialog openFile=new OpenFileDialog())
            {

                openFile.InitialDirectory = "C:\\Users\\gabri\\Desktop";
                openFile.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
                openFile.FilterIndex = 2;
                openFile.RestoreDirectory = true;

                if (openFile.ShowDialog()==DialogResult.OK)
                {
                    path = openFile.FileName;
                    Form2 f2 = new Form2();
                    
                    if (checkBox1.Checked)
                    {
                        f2.Text = openFile.SafeFileName;
                        f2.pictureBox1.Image = new Bitmap(path);
                        res = f2.ShowDialog();
                        
                    }
                    else
                    {
                        f2.Show();
                        f2.Text=openFile.SafeFileName;
                        f2.pictureBox1.Image = new Bitmap(path);

                    }

                }

            }

        }

     
    }
}
