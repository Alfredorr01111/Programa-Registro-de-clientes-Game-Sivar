
namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class FormCanjear
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
            this.lblAcumulados = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoTarjetas = new System.Windows.Forms.ComboBox();
            this.dgvProductosCanjeados = new System.Windows.Forms.DataGridView();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.lblPuntosTarjeta = new System.Windows.Forms.Label();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCanjearProductos = new System.Windows.Forms.ComboBox();
            this.checkBoxUnirPuntos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCanjeados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAcumulados
            // 
            this.lblAcumulados.AutoSize = true;
            this.lblAcumulados.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblAcumulados.ForeColor = System.Drawing.Color.White;
            this.lblAcumulados.Location = new System.Drawing.Point(386, 40);
            this.lblAcumulados.Name = "lblAcumulados";
            this.lblAcumulados.Size = new System.Drawing.Size(12, 18);
            this.lblAcumulados.TabIndex = 62;
            this.lblAcumulados.Text = ".";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(222, 50);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(127, 21);
            this.cmbClientes.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Seleccione un Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tipo de Tarjeta";
            // 
            // cmbTipoTarjetas
            // 
            this.cmbTipoTarjetas.FormattingEnabled = true;
            this.cmbTipoTarjetas.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Plus"});
            this.cmbTipoTarjetas.Location = new System.Drawing.Point(222, 96);
            this.cmbTipoTarjetas.Name = "cmbTipoTarjetas";
            this.cmbTipoTarjetas.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoTarjetas.TabIndex = 66;
            // 
            // dgvProductosCanjeados
            // 
            this.dgvProductosCanjeados.AllowUserToAddRows = false;
            this.dgvProductosCanjeados.AllowUserToDeleteRows = false;
            this.dgvProductosCanjeados.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosCanjeados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosCanjeados.GridColor = System.Drawing.Color.Purple;
            this.dgvProductosCanjeados.Location = new System.Drawing.Point(32, 281);
            this.dgvProductosCanjeados.Name = "dgvProductosCanjeados";
            this.dgvProductosCanjeados.ReadOnly = true;
            this.dgvProductosCanjeados.Size = new System.Drawing.Size(526, 142);
            this.dgvProductosCanjeados.TabIndex = 68;
            // 
            // btnCanjear
            // 
            this.btnCanjear.BackColor = System.Drawing.Color.White;
            this.btnCanjear.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnCanjear.ForeColor = System.Drawing.Color.Purple;
            this.btnCanjear.Location = new System.Drawing.Point(210, 225);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(95, 31);
            this.btnCanjear.TabIndex = 69;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = false;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // lblPuntosTarjeta
            // 
            this.lblPuntosTarjeta.AutoSize = true;
            this.lblPuntosTarjeta.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblPuntosTarjeta.ForeColor = System.Drawing.Color.White;
            this.lblPuntosTarjeta.Location = new System.Drawing.Point(386, 101);
            this.lblPuntosTarjeta.Name = "lblPuntosTarjeta";
            this.lblPuntosTarjeta.Size = new System.Drawing.Size(12, 18);
            this.lblPuntosTarjeta.TabIndex = 70;
            this.lblPuntosTarjeta.Text = ".";
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.BackColor = System.Drawing.Color.White;
            this.btnTransacciones.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnTransacciones.ForeColor = System.Drawing.Color.Purple;
            this.btnTransacciones.Location = new System.Drawing.Point(329, 225);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(134, 31);
            this.btnTransacciones.TabIndex = 71;
            this.btnTransacciones.Text = "Transacciones";
            this.btnTransacciones.UseVisualStyleBackColor = false;
            this.btnTransacciones.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Canjear Productos";
            // 
            // cmbCanjearProductos
            // 
            this.cmbCanjearProductos.FormattingEnabled = true;
            this.cmbCanjearProductos.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Plus"});
            this.cmbCanjearProductos.Location = new System.Drawing.Point(222, 139);
            this.cmbCanjearProductos.Name = "cmbCanjearProductos";
            this.cmbCanjearProductos.Size = new System.Drawing.Size(127, 21);
            this.cmbCanjearProductos.TabIndex = 72;
            // 
            // checkBoxUnirPuntos
            // 
            this.checkBoxUnirPuntos.AutoSize = true;
            this.checkBoxUnirPuntos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBoxUnirPuntos.ForeColor = System.Drawing.Color.White;
            this.checkBoxUnirPuntos.Location = new System.Drawing.Point(139, 182);
            this.checkBoxUnirPuntos.Name = "checkBoxUnirPuntos";
            this.checkBoxUnirPuntos.Size = new System.Drawing.Size(405, 23);
            this.checkBoxUnirPuntos.TabIndex = 74;
            this.checkBoxUnirPuntos.Text = "¿Desea unir los puntos obtenidos de todas sus tarjetas?";
            this.checkBoxUnirPuntos.UseVisualStyleBackColor = true;
            // 
            // FormCanjear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(583, 473);
            this.Controls.Add(this.checkBoxUnirPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCanjearProductos);
            this.Controls.Add(this.btnTransacciones);
            this.Controls.Add(this.lblPuntosTarjeta);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.dgvProductosCanjeados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoTarjetas);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAcumulados);
            this.Name = "FormCanjear";
            this.Text = "FormCanjear";
            this.Load += new System.EventHandler(this.FormCanjear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCanjeados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAcumulados;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoTarjetas;
        private System.Windows.Forms.DataGridView dgvProductosCanjeados;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Label lblPuntosTarjeta;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCanjearProductos;
        private System.Windows.Forms.CheckBox checkBoxUnirPuntos;
    }
}