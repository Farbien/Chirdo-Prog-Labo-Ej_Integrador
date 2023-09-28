using Entidades;
using Entidades.Enums;
using System.Text.RegularExpressions;

namespace MiCalculadora
{
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


        private void txtPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            this.primerOperando = new Numeracion(txtPrimerOperando.Text, ESistema.Decimal);
        }

        private void txtSegundoOperando_TextChanged(object sender, EventArgs e)
        {
            this.segundoOperando = new Numeracion(txtBoxSegundoOperando.Text, ESistema.Decimal);
        }

        private void setResultado()
        {
            if (string.IsNullOrEmpty(txtPrimerOperando.Text) || string.IsNullOrEmpty(txtBoxSegundoOperando.Text)) return;
            if (!Regex.IsMatch(txtPrimerOperando.Text, @"^-?\d+(\.\d+)?$") || !Regex.IsMatch(txtBoxSegundoOperando.Text, @"^-?\d+(\.\d+)?$")) return;
            if (rdbBinario.Checked)
                sistema = ESistema.Binario;
            else sistema = ESistema.Decimal;

            this.calculadora = new Operacion(primerOperando, segundoOperando);

            char charOperacion;

            if (string.IsNullOrEmpty(cmbOperacion.Text))
                charOperacion = '+';
            else
                charOperacion = Convert.ToChar(cmbOperacion.Text);

            this.resultado = this.calculadora.Operar(charOperacion);

            if (this.sistema == ESistema.Binario)
            {
                lblResultadoFinal.Text = this.resultado.ConvertirA(ESistema.Binario);
            }
            else
            {
                lblResultadoFinal.Text = this.resultado.Valor;
            }

            lblResultadoFinal.Visible = true;
        }

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

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.setResultado();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.setResultado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            Close();
        }

    }
}