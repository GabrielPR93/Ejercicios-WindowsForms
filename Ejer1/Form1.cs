#define CAMBIARCARACTER
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;


            this.Text = ("{X="+(e.X+b.Location.X)+",Y="+(e.Y+b.Location.Y)+"}").ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

#if CAMBIARCARACTER
            if (e.KeyValue != 27)
            {
                this.Text = e.KeyCode.ToString();
            }
            else
            {
                this.Text = "Mouse Tester";
            }
#endif

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mouse Tester",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
            button1.BackColor = default;

            }
            else if (e.Button == MouseButtons.Right)
            {
            button2.BackColor = default;
            }
            else
            {
                button1.BackColor = default;
                button2.BackColor = default;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !CAMBIARCARACTER
            if (e.KeyChar != 27)
            {
                this.Text = e.KeyChar.ToString();
            }
            else
            {
                this.Text = "Mouse Tester";
            }
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


