
namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class FormTarjetas
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoTarjetas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.BackgroundColor = System.Drawing.Color.White;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.GridColor = System.Drawing.Color.Purple;
            this.dgvTabla.Location = new System.Drawing.Point(44, 190);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(543, 180);
            this.dgvTabla.TabIndex = 42;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.White;
            this.btnLista.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnLista.ForeColor = System.Drawing.Color.Purple;
            this.btnLista.Location = new System.Drawing.Point(476, 142);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(111, 30);
            this.btnLista.TabIndex = 39;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Purple;
            this.btnAgregar.Location = new System.Drawing.Point(348, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 30);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtFechaVencimiento.Location = new System.Drawing.Point(185, 142);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(127, 25);
            this.txtFechaVencimiento.TabIndex = 37;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSaldoActual.Location = new System.Drawing.Point(460, 92);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(127, 25);
            this.txtSaldoActual.TabIndex = 36;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtLimiteCredito.Location = new System.Drawing.Point(185, 91);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(127, 25);
            this.txtLimiteCredito.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Saldo actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Limite de credito";
            // 
            // cmbTipoTarjetas
            // 
            this.cmbTipoTarjetas.FormattingEnabled = true;
            this.cmbTipoTarjetas.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Plus"});
            this.cmbTipoTarjetas.Location = new System.Drawing.Point(460, 38);
            this.cmbTipoTarjetas.Name = "cmbTipoTarjetas";
            this.cmbTipoTarjetas.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoTarjetas.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tipo de Tarjeta";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(185, 38);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(127, 21);
            this.cmbClientes.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Cliente asociado";
            // 
            // FormTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(639, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoTarjetas);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtSaldoActual);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTarjetas";
            this.Text = "FormTarjetas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoTarjetas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label4;
    }
}