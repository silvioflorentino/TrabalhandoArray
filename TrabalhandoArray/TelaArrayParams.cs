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
    public partial class TelaArrayParams : Form
    {
        public TelaArrayParams()
        {
            InitializeComponent();
        }

        private decimal UsandoArrayParams(params decimal[] numeros)
        {
            decimal soma = 0;

            for(int i=0;i<= numeros.GetLength(0) -1; i++)
            {
                soma += numeros[i];
            }

            return soma / numeros.Length;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lbResul.Items.Add("Média dos valores: 25,45,78,15,78 é " + UsandoArrayParams(25,45,78,15,78));
        }
    }
}
