using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            int[] numeros = {0,50,100,200,250,200,450,500};

            for(int i = 0; i <= numeros.Length - 1; i++)
            {
                lblResultado.Text = "numeros[" + i + "] = " + numeros[i];
                lsBoxResultado.Items.Add("numeros[" + i + "] = " + numeros[i]);
            }
            foreach(int i in numeros)
            {
                lsBoxResultado.Items.Add("Número: " + i);
            }
            //array bidimensional 
            int[,] frutas = new int[3,5];

            lblResultado.Text = "frutas.length: " + frutas.Length;

            //array tridimensional
            int[,,] musica = new int[2, 3, 4];
            lblResultado.Text += "\n Músicas Dimensões= " + musica.Rank;
            lblResultado.Text += "\n Músicas tamanho array = " + musica.Length;

        }


    }
}
