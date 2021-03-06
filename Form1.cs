using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha2
{
    public partial class Form1 : Form
    {
        bool xis = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            b11.Click += new EventHandler(Bclick);
            b21.Click += new EventHandler(Bclick);
            b31.Click += new EventHandler(Bclick);
            b12.Click += new EventHandler(Bclick);
            b22.Click += new EventHandler(Bclick);
            b32.Click += new EventHandler(Bclick);
            b13.Click += new EventHandler(Bclick);
            b23.Click += new EventHandler(Bclick);
            b33.Click += new EventHandler(Bclick);
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.TabStop = false;
                }
            }
        }

        private void Bclick(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.xis ? "x" : "o";
            ((Button)sender).Enabled = false;

            verificarGanhador();

            xis = !xis;
            label1.Text = string.Format("(0), é a sua vez ", this.xis ? "x" : "o");


        }

        private void verificarGanhador()
        {
            if (
            b11.Text != String.Empty && b11.Text == b21.Text && b21.Text == b31.Text ||
            b21.Text != String.Empty && b12.Text == b22.Text && b22.Text == b32.Text ||
            b31.Text != String.Empty && b13.Text == b23.Text && b23.Text == b33.Text ||

            b12.Text != String.Empty && b11.Text == b12.Text && b12.Text == b13.Text ||
            b22.Text != String.Empty && b21.Text == b22.Text && b22.Text == b23.Text ||
            b32.Text != String.Empty && b31.Text == b32.Text && b32.Text == b33.Text ||

            b13.Text != String.Empty && b11.Text == b22.Text && b22.Text == b33.Text ||
            b23.Text != String.Empty && b11.Text == b22.Text && b22.Text == b13.Text ||
            )
            {
                MessageBox.Show(String.Format("O ganhador é o {0}", xis ? "x" : "o"), "temos um vitorioso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reiniciar();
            }
            else
            {
                verificarEmpate();
            }
        }

        private void Reiniciar()
        {
            foreach(Control item in this.Controls)
                if(item is Button)
                {
                    item.Enabled = true;
                    item.Text = string.Empty;
                }
        }

        private void verificarEmpate()
        {

            bool todosDesabilitados = true;



            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Enabled)
                {
                    todosDesabilitados = false;
                    break;
                }
            }

            if (todosDesabilitados)
            {
                MessageBox.Show(String.Format("Deu empate"), "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reiniciar();
            }

        }
    }
}
