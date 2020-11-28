using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Tag = Color.Aqua;
            button2.Tag = Color.Cornsilk;
            button3.Tag = Color.ForestGreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        //private void Button1_KeyUp(object sender, KeyEventArgs e)
        //{
        //    this.Text = e.KeyCode.ToString(); // poniendo la propiedad key preview a true
        //}

        private void Button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = button1.Text.ToUpper();
        }
        private void click(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = b.Text.ToUpper();

            this.BackColor = (Color)b.Tag;
           
        }
    }
}
