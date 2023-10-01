namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            grpSistema = new GroupBox();
            cmbOperacion = new ComboBox();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            lblResultado = new Label();
            txtPrimerOperando = new TextBox();
            txtBoxSegundoOperando = new TextBox();
            lblResultadoFinal = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(137, 301);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(110, 33);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(297, 301);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 33);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(471, 301);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(110, 33);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(18, 39);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 3;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(194, 39);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 4;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.ForeColor = Color.FromArgb(224, 224, 224);
            grpSistema.Location = new Point(208, 114);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(290, 73);
            grpSistema.TabIndex = 5;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(297, 250);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 6;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.ForeColor = Color.Silver;
            lblPrimerOperador.Location = new Point(136, 233);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(93, 15);
            lblPrimerOperador.TabIndex = 7;
            lblPrimerOperador.Text = "Primer operador";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.ForeColor = Color.Silver;
            lblOperacion.Location = new Point(297, 232);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(57, 15);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operador";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.ForeColor = Color.Silver;
            lblSegundoOperador.Location = new Point(471, 232);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(105, 15);
            lblSegundoOperador.TabIndex = 9;
            lblSegundoOperador.Text = "Segundo operador";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.FromArgb(224, 224, 224);
            lblResultado.Location = new Point(212, 69);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(112, 30);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(137, 250);
            txtPrimerOperando.Margin = new Padding(3, 2, 3, 2);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(110, 23);
            txtPrimerOperando.TabIndex = 14;
            txtPrimerOperando.TextChanged += txtPrimerOperando_TextChanged;
            // 
            // txtBoxSegundoOperando
            // 
            txtBoxSegundoOperando.Location = new Point(471, 250);
            txtBoxSegundoOperando.Margin = new Padding(3, 2, 3, 2);
            txtBoxSegundoOperando.Name = "txtBoxSegundoOperando";
            txtBoxSegundoOperando.Size = new Size(110, 23);
            txtBoxSegundoOperando.TabIndex = 15;
            txtBoxSegundoOperando.TextChanged += txtSegundoOperando_TextChanged;
            // 
            // lblResultadoFinal
            // 
            lblResultadoFinal.AutoSize = true;
            lblResultadoFinal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoFinal.ForeColor = Color.FromArgb(128, 255, 255);
            lblResultadoFinal.Location = new Point(330, 69);
            lblResultadoFinal.Name = "lblResultadoFinal";
            lblResultadoFinal.Size = new Size(0, 30);
            lblResultadoFinal.TabIndex = 16;
            lblResultadoFinal.Visible = false;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 57, 68);
            ClientSize = new Size(719, 406);
            Controls.Add(lblResultadoFinal);
            Controls.Add(txtBoxSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Nicolas Chirdo";
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private Label lblResultado;
        private TextBox txtPrimerOperando;
        private TextBox txtBoxSegundoOperando;
        private Label lblResultadoFinal;
    }
}