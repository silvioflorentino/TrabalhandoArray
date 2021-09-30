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
    }
}
