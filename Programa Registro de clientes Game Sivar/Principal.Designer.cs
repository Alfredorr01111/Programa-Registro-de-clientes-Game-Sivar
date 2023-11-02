namespace Programa_Registro_de_clientes_Game_Sivar
{
    partial class Principal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarCliente = new FontAwesome.Sharp.IconMenuItem();
            this.submenuListaCliente = new FontAwesome.Sharp.IconMenuItem();
            this.menuTarjetas = new FontAwesome.Sharp.IconMenuItem();
            this.menuPuntos = new FontAwesome.Sharp.IconMenuItem();
            this.menuInventarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuInformes = new FontAwesome.Sharp.IconMenuItem();
            this.submenuHistorial = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menUsuarios,
            this.menuClientes,
            this.menuTarjetas,
            this.menuPuntos,
            this.menuInventarios,
            this.menuInformes});
            this.menu.Location = new System.Drawing.Point(0, 55);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(791, 75);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // menUsuarios
            // 
            this.menUsuarios.AutoSize = false;
            this.menUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menUsuarios.IconColor = System.Drawing.Color.Black;
            this.menUsuarios.IconSize = 50;
            this.menUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menUsuarios.Name = "menUsuarios";
            this.menUsuarios.Rotation = 0D;
            this.menUsuarios.Size = new System.Drawing.Size(122, 71);
            this.menUsuarios.Text = "Usuarios";
            this.menUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menUsuarios.Click += new System.EventHandler(this.menUsuarios_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarCliente,
            this.submenuListaCliente});
            this.menuClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menuClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Rotation = 0D;
            this.menuClientes.Size = new System.Drawing.Size(80, 71);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarCliente
            // 
            this.submenuRegistrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.submenuRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.submenuRegistrarCliente.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarCliente.IconSize = 18;
            this.submenuRegistrarCliente.Name = "submenuRegistrarCliente";
            this.submenuRegistrarCliente.Rotation = 0D;
            this.submenuRegistrarCliente.Size = new System.Drawing.Size(181, 22);
            this.submenuRegistrarCliente.Text = "Registrar Cliente";
            this.submenuRegistrarCliente.Click += new System.EventHandler(this.submenuRegistrarCliente_Click);
            // 
            // submenuListaCliente
            // 
            this.submenuListaCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.submenuListaCliente.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.submenuListaCliente.IconColor = System.Drawing.Color.Black;
            this.submenuListaCliente.IconSize = 16;
            this.submenuListaCliente.Name = "submenuListaCliente";
            this.submenuListaCliente.Rotation = 0D;
            this.submenuListaCliente.Size = new System.Drawing.Size(181, 22);
            this.submenuListaCliente.Text = "Lista de Clientes";
            this.submenuListaCliente.Click += new System.EventHandler(this.submenuListaCliente_Click_1);
            // 
            // menuTarjetas
            // 
            this.menuTarjetas.AutoSize = false;
            this.menuTarjetas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menuTarjetas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTarjetas.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.menuTarjetas.IconColor = System.Drawing.Color.Black;
            this.menuTarjetas.IconSize = 50;
            this.menuTarjetas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuTarjetas.Name = "menuTarjetas";
            this.menuTarjetas.Rotation = 0D;
            this.menuTarjetas.Size = new System.Drawing.Size(80, 71);
            this.menuTarjetas.Text = "Tarjetas";
            this.menuTarjetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuTarjetas.Click += new System.EventHandler(this.menuTarjetas_Click);
            // 
            // menuPuntos
            // 
            this.menuPuntos.AutoSize = false;
            this.menuPuntos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menuPuntos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPuntos.IconChar = FontAwesome.Sharp.IconChar.HandPointerO;
            this.menuPuntos.IconColor = System.Drawing.Color.Black;
            this.menuPuntos.IconSize = 50;
            this.menuPuntos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPuntos.Name = "menuPuntos";
            this.menuPuntos.Rotation = 0D;
            this.menuPuntos.Size = new System.Drawing.Size(80, 71);
            this.menuPuntos.Text = "Puntos";
            this.menuPuntos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPuntos.Click += new System.EventHandler(this.menuPuntos_Click);
            // 
            // menuInventarios
            // 
            this.menuInventarios.AutoSize = false;
            this.menuInventarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menuInventarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInventarios.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuInventarios.IconColor = System.Drawing.Color.Black;
            this.menuInventarios.IconSize = 50;
            this.menuInventarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventarios.Name = "menuInventarios";
            this.menuInventarios.Rotation = 0D;
            this.menuInventarios.Size = new System.Drawing.Size(122, 71);
            this.menuInventarios.Text = "Inventarios";
            this.menuInventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInventarios.Click += new System.EventHandler(this.menuInventarios_Click);
            // 
            // menuInformes
            // 
            this.menuInformes.AutoSize = false;
            this.menuInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuHistorial});
            this.menuInformes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menuInformes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInformes.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuInformes.IconColor = System.Drawing.Color.Black;
            this.menuInformes.IconSize = 50;
            this.menuInformes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Rotation = 0D;
            this.menuInformes.Size = new System.Drawing.Size(80, 71);
            this.menuInformes.Text = "Informes";
            this.menuInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuHistorial
            // 
            this.submenuHistorial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.submenuHistorial.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.submenuHistorial.IconColor = System.Drawing.Color.Black;
            this.submenuHistorial.IconSize = 16;
            this.submenuHistorial.Name = "submenuHistorial";
            this.submenuHistorial.Rotation = 0D;
            this.submenuHistorial.Size = new System.Drawing.Size(195, 22);
            this.submenuHistorial.Text = "Historial de Canjes";
   
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Purple;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(791, 55);
            this.menuTitulo.TabIndex = 4;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "SISTEMA DE VENTAS DE GAMESIVAR";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 130);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(791, 379);
            this.contenedor.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 509);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuTarjetas;
        private FontAwesome.Sharp.IconMenuItem menuInventarios;
        private FontAwesome.Sharp.IconMenuItem menuPuntos;
        private FontAwesome.Sharp.IconMenuItem menuInformes;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarCliente;
        private FontAwesome.Sharp.IconMenuItem submenuHistorial;
        private FontAwesome.Sharp.IconMenuItem submenuListaCliente;
    }
}