using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3
{
    public partial class frmInvertChar : Form
    {
        public frmInvertChar()
        {
            InitializeComponent();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            /** Desabilita o botão enquanto processa a frase */
            btnInverter.Enabled = false;

            /** Variável que recebe frase digitada */
            string fraseEntrada = txbFraseEntrada.Text;

            /** Variável que armazenará a frase de saída */
            string fraseSaida = "";

            /** Converte todo a frase digitada para minúsculas */
            fraseEntrada = fraseEntrada.ToLower();

            /** Verifica cada caráctere da frase de entrada */
            for (int i = fraseEntrada.ToCharArray().Length - 1; i >= 0; i--)
            {
                /** Se for letra, adiciona na variável de saída */
                if(char.IsLetter(fraseEntrada.ToCharArray()[i]))
                {
                    fraseSaida += fraseEntrada.ToCharArray()[i];
                }
            }

            /** Exibe frase de saída */
            txbFraseSaida.Text = fraseSaida;

            /** Habilita o botão */
            btnInverter.Enabled = true;
        }

        private void txbFraseEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            /** Se pressionada a Tecla Enter, Gera evento de click no botão */
            if(e.KeyCode == Keys.Enter)
            {
                btnInverter.PerformClick();
            }
        }
    }
}
