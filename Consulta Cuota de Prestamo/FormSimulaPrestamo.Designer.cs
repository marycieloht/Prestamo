namespace SimuladorPrestamo
{
    partial class FormSimulaPrestamo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos usados.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            lblTituloDatos = new Label();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblTasa = new Label();
            txtTasa = new TextBox();
            lblPlazo = new Label();
            txtPlazo = new TextBox();
            lblTituloResultado = new Label();
            lblCuota = new Label();
            txtCuota = new TextBox();
            btnConsultar = new Button();
            btnRestablecer = new Button();
            btnCerrar = new Button();
            lblMensajes = new Label();
            SuspendLayout();
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.AutoSize = true;
            lblTituloDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.Red;
            lblTituloDatos.Location = new Point(120, 20);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Size = new Size(178, 19);
            lblTituloDatos.TabIndex = 0;
            lblTituloDatos.Text = "[ DATOS DEL PRÉSTAMO ]";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(40, 60);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(150, 57);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 23);
            txtMonto.TabIndex = 2;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(40, 100);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(70, 15);
            lblTasa.TabIndex = 3;
            lblTasa.Text = "Tasa Interés:";
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(150, 97);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(150, 23);
            txtTasa.TabIndex = 4;
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.Location = new Point(40, 140);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(38, 15);
            lblPlazo.TabIndex = 5;
            lblPlazo.Text = "Plazo:";
            // 
            // txtPlazo
            // 
            txtPlazo.Location = new Point(150, 137);
            txtPlazo.Name = "txtPlazo";
            txtPlazo.Size = new Size(150, 23);
            txtPlazo.TabIndex = 6;
            // 
            // lblTituloResultado
            // 
            lblTituloResultado.AutoSize = true;
            lblTituloResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloResultado.ForeColor = Color.Blue;
            lblTituloResultado.Location = new Point(150, 180);
            lblTituloResultado.Name = "lblTituloResultado";
            lblTituloResultado.Size = new Size(105, 19);
            lblTituloResultado.TabIndex = 7;
            lblTituloResultado.Text = "[ RESULTADO ]";
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(40, 220);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(42, 15);
            lblCuota.TabIndex = 8;
            lblCuota.Text = "Cuota:";
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(150, 217);
            txtCuota.Name = "txtCuota";
            txtCuota.ReadOnly = true;
            txtCuota.Size = new Size(150, 23);
            txtCuota.TabIndex = 9;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 270);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 30);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(150, 270);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(90, 30);
            btnRestablecer.TabIndex = 11;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(260, 270);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 30);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMensajes
            // 
            lblMensajes.AutoSize = true;
            lblMensajes.ForeColor = Color.Red;
            lblMensajes.Location = new Point(40, 320);
            lblMensajes.Name = "lblMensajes";
            lblMensajes.Size = new Size(0, 15);
            lblMensajes.TabIndex = 13;
            // 
            // FormSimulaPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 370);
            Controls.Add(lblMensajes);
            Controls.Add(btnCerrar);
            Controls.Add(btnRestablecer);
            Controls.Add(btnConsultar);
            Controls.Add(txtCuota);
            Controls.Add(lblCuota);
            Controls.Add(lblTituloResultado);
            Controls.Add(txtPlazo);
            Controls.Add(lblPlazo);
            Controls.Add(txtTasa);
            Controls.Add(lblTasa);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblTituloDatos);
            Name = "FormSimulaPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simulador de Préstamo";
            Load += FormSimulaPrestamo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lblTituloResultado;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMensajes;
    }
}
