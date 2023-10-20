namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class mainMenu
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(92, 70);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(127, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Nuevo Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(92, 138);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(127, 23);
            this.btnTarjetas.TabIndex = 1;
            this.btnTarjetas.Text = "Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(92, 207);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(127, 23);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 380);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnTarjetas);
            this.Controls.Add(this.btnCrear);
            this.Name = "mainMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.Button btnConsultas;
    }
}