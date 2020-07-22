using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        private DataTable table; /*Criando a tabela de dados*/
        private string resultado;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            tboxValores.Text += a.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            table = new DataTable(); /*Instânciando o obj */

            var a = tboxValores.Text.Replace(',', '.'); //Trocando virgula por ponto

            resultado = table.Compute(a, string.Empty).ToString();
            /*Método Computer() -  Calcula os valores da string*/
            tboxValores.Text = resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tboxValores.Clear();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            var tamanho = tboxValores.Text.Length;
            if (tamanho > 0)
                tboxValores.Text = tboxValores.Text.Remove(tamanho - 1);
        }


        #region Teclado

        private void teclado( object sender,KeyEventArgs e)
        {
            //Numeros
            if (e.KeyCode == Keys.NumPad0)
                btn0.PerformClick();
            if (e.KeyCode == Keys.NumPad1)
                btn1.PerformClick();
            if (e.KeyCode == Keys.NumPad2)
                btn2.PerformClick();
            if (e.KeyCode == Keys.NumPad3)
                btn3.PerformClick();
            if (e.KeyCode == Keys.NumPad4)
                btn4.PerformClick();
            if (e.KeyCode == Keys.NumPad5)
                btn5.PerformClick();
            if (e.KeyCode == Keys.NumPad6)
                btn6.PerformClick();
            if (e.KeyCode == Keys.NumPad7)
                btn7.PerformClick();
            if (e.KeyCode == Keys.NumPad8)
                btn8.PerformClick();
            if (e.KeyCode == Keys.NumPad9)
                btn9.PerformClick();
            if (e.KeyCode == Keys.Decimal) //Keys.Decimal == ,
                btnVirgula.PerformClick();

            //funções
            if (e.KeyCode == Keys.Enter)
                btnIgual.PerformClick();
            if (e.KeyCode == Keys.Back)
                btnApagar.PerformClick();
            if (e.KeyCode == Keys.Delete)
                btnLimpar.PerformClick();
            if (e.KeyCode == Keys.Add)
                btnMais.PerformClick();
            if (e.KeyCode == Keys.Multiply)
                btnMultiplicacao.PerformClick();
            if (e.KeyCode == Keys.Multiply)
                btnMultiplicacao.PerformClick();
            if (e.KeyCode == Keys.Subtract)
                btnMenos.PerformClick();
            if (e.KeyCode == Keys.Divide)
                btnDivisao.PerformClick();
            if (e.KeyCode == Keys.Escape)
                this.Close();

        }

        #endregion

        /* Criar validações para a virgula e sinais*/

    }
}
