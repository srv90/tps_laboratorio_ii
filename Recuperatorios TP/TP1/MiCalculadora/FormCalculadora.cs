using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Limpia los textbox, el label y setea los botones a false
        /// </summary>
        private void Limpiar()
        {

            txtNumero1.Text = "" ;
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Llama al metodo limpiar y pone el foco en el primer textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNumero1.Focus();
        }

        /// <summary>
        /// Hace la operacion correspondiente
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Devuelve el resultado de la operacion</param>
        /// <returns></returns>
        private static double Operar(string num1, string num2, string operador)
        {
            Operando numero1 = new Operando(num1);
            Operando numero2 = new Operando(num2);

            return Calculadora.Operar(numero1, numero2, operador.ToArray().First());
        }

        /// <summary>
        /// Cierra la aplicacion por medio del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cierra la aplicacion con la cruz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Salir",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {

                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Hace la operacion y la agrega al historial de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            String operador;
            String resultado;

            if (String.IsNullOrWhiteSpace(txtNumero1.Text) || String.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Debes ingresar ambos numeros", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!(Double.TryParse(txtNumero1.Text, out double num1) && Double.TryParse(txtNumero2.Text, out num1)) || Double.IsNaN(num1))
                {
                    MessageBox.Show("El valor ingresado es invalido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbOperador.SelectedItem is null)
                    {
                        cmbOperador.Text = "+";
                        operador = "+";
                    }
                    else
                    {
                        operador = cmbOperador.SelectedItem.ToString();
                    }
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = false;
                    resultado = Operar(txtNumero1.Text.Replace(".", ","), txtNumero2.Text.Replace(".", ","), operador).ToString();
                    lblResultado.Text = resultado;
                    lstOperaciones.Items.Add(txtNumero1.Text + operador + txtNumero2.Text + " = " + resultado );


                }
            }
        }

        /// <summary>
        /// Convierte en caso de existir, el resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando number = new Operando();

            lblResultado.Text = number.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Convierte en caso de existir, el resultado a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando number = new Operando();

            lblResultado.Text = number.BinarioDecimal(lblResultado.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

 

    }
}
