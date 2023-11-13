
namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class FormPuntos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaTransacciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoTarjetas = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblPuntosAcumulados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkDoblePuntos = new System.Windows.Forms.CheckBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoJuego = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTransacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaTransacciones
            // 
            this.dgvListaTransacciones.AllowUserToAddRows = false;
            this.dgvListaTransacciones.AllowUserToDeleteRows = false;
            this.dgvListaTransacciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTransacciones.GridColor = System.Drawing.Color.Purple;
            this.dgvListaTransacciones.Location = new System.Drawing.Point(28, 240);
            this.dgvListaTransacciones.Name = "dgvListaTransacciones";
            this.dgvListaTransacciones.ReadOnly = true;
            this.dgvListaTransacciones.Size = new System.Drawing.Size(563, 164);
            this.dgvListaTransacciones.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Seleccione un Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(218, 37);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(127, 21);
            this.cmbClientes.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Tipo de Tarjeta";
            // 
            // cmbTipoTarjetas
            // 
            this.cmbTipoTarjetas.FormattingEnabled = true;
            this.cmbTipoTarjetas.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Plus"});
            this.cmbTipoTarjetas.Location = new System.Drawing.Point(218, 86);
            this.cmbTipoTarjetas.Name = "cmbTipoTarjetas";
            this.cmbTipoTarjetas.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoTarjetas.TabIndex = 55;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Purple;
            this.btnRegistrar.Location = new System.Drawing.Point(407, 179);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 31);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "Registrar Transacción";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblPuntosAcumulados
            // 
            this.lblPuntosAcumulados.AutoSize = true;
            this.lblPuntosAcumulados.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblPuntosAcumulados.ForeColor = System.Drawing.Color.White;
            this.lblPuntosAcumulados.Location = new System.Drawing.Point(562, 40);
            this.lblPuntosAcumulados.Name = "lblPuntosAcumulados";
            this.lblPuntosAcumulados.Size = new System.Drawing.Size(12, 18);
            this.lblPuntosAcumulados.TabIndex = 60;
            this.lblPuntosAcumulados.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(392, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Puntos Acumulados";
            // 
            // checkDoblePuntos
            // 
            this.checkDoblePuntos.AutoSize = true;
            this.checkDoblePuntos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkDoblePuntos.ForeColor = System.Drawing.Color.White;
            this.checkDoblePuntos.Location = new System.Drawing.Point(183, 179);
            this.checkDoblePuntos.Name = "checkDoblePuntos";
            this.checkDoblePuntos.Size = new System.Drawing.Size(143, 23);
            this.checkDoblePuntos.TabIndex = 62;
            this.checkDoblePuntos.Text = "Doble de puntos";
            this.checkDoblePuntos.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.White;
            this.btnLista.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnLista.ForeColor = System.Drawing.Color.Purple;
            this.btnLista.Location = new System.Drawing.Point(490, 128);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(101, 31);
            this.btnLista.TabIndex = 63;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Modo de Juego";
            // 
            // cmbTipoJuego
            // 
            this.cmbTipoJuego.FormattingEnabled = true;
            this.cmbTipoJuego.Items.AddRange(new object[] {
            "Mecánico",
            "Electrónico"});
            this.cmbTipoJuego.Location = new System.Drawing.Point(218, 134);
            this.cmbTipoJuego.Name = "cmbTipoJuego";
            this.cmbTipoJuego.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoJuego.TabIndex = 64;
            // 
            // FormPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(624, 462);
            this.Controls.Add(this.cmbTipoJuego);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.checkDoblePuntos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPuntosAcumulados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoTarjetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.dgvListaTransacciones);
            this.Controls.Add(this.label1);
            this.Name = "FormPuntos";
            this.Text = "FormPuntos";
            this.Load += new System.EventHandler(this.FormPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTransacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaTransacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoTarjetas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblPuntosAcumulados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkDoblePuntos;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoJuego;
    }
}