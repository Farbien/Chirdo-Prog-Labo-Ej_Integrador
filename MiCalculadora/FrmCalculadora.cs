using Entidades;
using Entidades.Enums;
using System.Text.RegularExpressions;

namespace MiCalculadora
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="FrmCalculadora"/>.
    /// </summary>
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.setResultado();
        }

        /// <summary>
        /// Maneja el evento de cambio de texto en el cuadro de texto del primer operando.
        /// Actualiza el valor del primer operando en función del texto ingresado.
        /// </summary>
        private void txtPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(txtPrimerOperando.Text, ESistema.Decimal);
        }

        /// <summary>
        /// Maneja el evento de cambio de texto en el cuadro de texto del segundo operando.
        /// Actualiza el valor del segundo operando en función del texto ingresado.
        /// </summary>
        private void txtSegundoOperando_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(txtBoxSegundoOperando.Text, ESistema.Decimal);
        }

        /// <summary>
        /// Realiza la operación y muestra el resultado en la etiqueta correspondiente.
        /// </summary>
        private void setResultado()
        {
            // Verifica si ambos operandos han sido ingresados.
            if (string.IsNullOrEmpty(txtPrimerOperando.Text) || string.IsNullOrEmpty(txtBoxSegundoOperando.Text)) return;

            // Verifica si los operandos son números válidos en formato decimal.
            if (!Regex.IsMatch(txtPrimerOperando.Text, @"^-?\d+(\.\d+)?$") || !Regex.IsMatch(txtBoxSegundoOperando.Text, @"^-?\d+(\.\d+)?$")) return;

            // Determina el sistema numérico en el que se realizará la operación (decimal o binario).
            if (rdbBinario.Checked)
                if (rdbBinario.Checked)
                sistema = ESistema.Binario;
            else sistema = ESistema.Decimal;

            // Crea una instancia de la clase Operacion para realizar el cálculo.
            this.calculadora = new Operacion(primerOperando, segundoOperando);

            char charOperacion;

            // Obtiene el operador matemático seleccionado en el listBox.
            if (string.IsNullOrEmpty(cmbOperacion.Text))
                charOperacion = '+';
            else
                charOperacion = Convert.ToChar(cmbOperacion.Text);

            // Realiza la operación y obtiene el resultado como una instancia de Numeracion.
            this.resultado = this.calculadora.Operar(charOperacion);

            // Muestra el resultado en la etiqueta correspondiente según el sistema numérico seleccionado.
            if (this.sistema == ESistema.Binario)
            {
                lblResultadoFinal.Text = this.resultado.ConvertirA(ESistema.Binario);
            }
            else
            {
                lblResultadoFinal.Text = this.resultado.Valor;
            }

            // Hace visible la etiqueta de resultado.
            lblResultadoFinal.Visible = true;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Limpiar". Restablece los controles y elimina los valores ingresados.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbDecimal.Checked = true;
            rdbBinario.Checked = false;
            txtPrimerOperando.Text = null;
            txtBoxSegundoOperando.Text = null;
            cmbOperacion.SelectedValue = null;
            cmbOperacion.Text = null;
            lblResultadoFinal.Text = null;
        }

        /// <summary>
        /// Maneja el evento de cambio de selección en la opción "Binario". Actualiza el resultado si es necesario.
        /// </summary>
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.setResultado();
        }

        /// <summary>
        /// Maneja el evento de cambio de selección en la opción "Decimal". Actualiza el resultado si es necesario.
        /// </summary>
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.setResultado();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Cerrar". Muestra un cuadro de diálogo de confirmación y cierra la aplicación si el usuario confirma.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            Close();
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}