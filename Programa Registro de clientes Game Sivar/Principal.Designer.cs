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
            this.menuTarjetas = new FontAwesome.Sharp.IconMenuItem();
            this.menuPuntos = new FontAwesome.Sharp.IconMenuItem();
            this.menuInventarios = new FontAwesome.Sharp.IconMenuItem();
            this.menucerrar = new FontAwesome.Sharp.IconMenuItem();
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
            this.menucerrar});
            this.menu.Location = new System.Drawing.Point(0, 55);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(723, 75);
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
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
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
            // menucerrar
            // 
            this.menucerrar.AutoSize = false;
            this.menucerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.menucerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucerrar.IconChar = FontAwesome.Sharp.IconChar.WindowCloseO;
            this.menucerrar.IconColor = System.Drawing.Color.Black;
            this.menucerrar.IconSize = 50;
            this.menucerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucerrar.Name = "menucerrar";
            this.menucerrar.Rotation = 0D;
            this.menucerrar.Size = new System.Drawing.Size(122, 71);
            this.menucerrar.Text = "Cerrar Sesión";
            this.menucerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Purple;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(723, 55);
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
            this.contenedor.Size = new System.Drawing.Size(723, 444);
            this.contenedor.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 574);
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
        private FontAwesome.Sharp.IconMenuItem menucerrar;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
    }
}