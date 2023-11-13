
namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class FormInventario
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
            this.dgvInventarios = new System.Windows.Forms.DataGridView();
            this.lblExistenciasGold = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblTarjetaMenosVendida = new System.Windows.Forms.Label();
            this.lblTarjetaMasVendida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExistenciasPlus = new System.Windows.Forms.Label();
            this.lblExistenciaSilver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventarios
            // 
            this.dgvInventarios.AllowUserToAddRows = false;
            this.dgvInventarios.AllowUserToDeleteRows = false;
            this.dgvInventarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarios.GridColor = System.Drawing.Color.Purple;
            this.dgvInventarios.Location = new System.Drawing.Point(43, 206);
            this.dgvInventarios.Name = "dgvInventarios";
            this.dgvInventarios.ReadOnly = true;
            this.dgvInventarios.Size = new System.Drawing.Size(502, 141);
            this.dgvInventarios.TabIndex = 43;
            // 
            // lblExistenciasGold
            // 
            this.lblExistenciasGold.AutoSize = true;
            this.lblExistenciasGold.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblExistenciasGold.ForeColor = System.Drawing.Color.White;
            this.lblExistenciasGold.Location = new System.Drawing.Point(150, 78);
            this.lblExistenciasGold.Name = "lblExistenciasGold";
            this.lblExistenciasGold.Size = new System.Drawing.Size(31, 18);
            this.lblExistenciasGold.TabIndex = 51;
            this.lblExistenciasGold.Text = "no.";
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.White;
            this.btnLista.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnLista.ForeColor = System.Drawing.Color.Purple;
            this.btnLista.Location = new System.Drawing.Point(454, 44);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(91, 31);
            this.btnLista.TabIndex = 52;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // lblTarjetaMenosVendida
            // 
            this.lblTarjetaMenosVendida.AutoSize = true;
            this.lblTarjetaMenosVendida.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblTarjetaMenosVendida.ForeColor = System.Drawing.Color.White;
            this.lblTarjetaMenosVendida.Location = new System.Drawing.Point(434, 138);
            this.lblTarjetaMenosVendida.Name = "lblTarjetaMenosVendida";
            this.lblTarjetaMenosVendida.Size = new System.Drawing.Size(51, 18);
            this.lblTarjetaMenosVendida.TabIndex = 53;
            this.lblTarjetaMenosVendida.Text = "name";
            // 
            // lblTarjetaMasVendida
            // 
            this.lblTarjetaMasVendida.AutoSize = true;
            this.lblTarjetaMasVendida.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblTarjetaMasVendida.ForeColor = System.Drawing.Color.White;
            this.lblTarjetaMasVendida.Location = new System.Drawing.Point(434, 96);
            this.lblTarjetaMasVendida.Name = "lblTarjetaMasVendida";
            this.lblTarjetaMasVendida.Size = new System.Drawing.Size(51, 18);
            this.lblTarjetaMasVendida.TabIndex = 54;
            this.lblTarjetaMasVendida.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tarjeta Más Vendida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tarjeta Menos Vendida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tarjeta Silver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tarjeta Gold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tarjeta Plus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "EXISTENCIAS";
            // 
            // lblExistenciasPlus
            // 
            this.lblExistenciasPlus.AutoSize = true;
            this.lblExistenciasPlus.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblExistenciasPlus.ForeColor = System.Drawing.Color.White;
            this.lblExistenciasPlus.Location = new System.Drawing.Point(150, 158);
            this.lblExistenciasPlus.Name = "lblExistenciasPlus";
            this.lblExistenciasPlus.Size = new System.Drawing.Size(31, 18);
            this.lblExistenciasPlus.TabIndex = 62;
            this.lblExistenciasPlus.Text = "no.";
            // 
            // lblExistenciaSilver
            // 
            this.lblExistenciaSilver.AutoSize = true;
            this.lblExistenciaSilver.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblExistenciaSilver.ForeColor = System.Drawing.Color.White;
            this.lblExistenciaSilver.Location = new System.Drawing.Point(150, 116);
            this.lblExistenciaSilver.Name = "lblExistenciaSilver";
            this.lblExistenciaSilver.Size = new System.Drawing.Size(31, 18);
            this.lblExistenciaSilver.TabIndex = 63;
            this.lblExistenciaSilver.Text = "no.";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(592, 388);
            this.Controls.Add(this.lblExistenciaSilver);
            this.Controls.Add(this.lblExistenciasPlus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTarjetaMasVendida);
            this.Controls.Add(this.lblTarjetaMenosVendida);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lblExistenciasGold);
            this.Controls.Add(this.dgvInventarios);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventarios;
        private System.Windows.Forms.Label lblExistenciasGold;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblTarjetaMenosVendida;
        private System.Windows.Forms.Label lblTarjetaMasVendida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExistenciasPlus;
        private System.Windows.Forms.Label lblExistenciaSilver;
    }
}