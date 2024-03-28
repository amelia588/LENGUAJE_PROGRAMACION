namespace SISTEMA_ALMACEN
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 16);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeProductoToolStripMenuItem,
            this.gestionDeProToolStripMenuItem,
            this.entradasDeInventarioToolStripMenuItem,
            this.salidasDeInventarioToolStripMenuItem,
            this.movimientosDeInventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductoToolStripMenuItem
            // 
            this.gestionDeProductoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionDeProductoToolStripMenuItem.Image")));
            this.gestionDeProductoToolStripMenuItem.Name = "gestionDeProductoToolStripMenuItem";
            this.gestionDeProductoToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.gestionDeProductoToolStripMenuItem.Text = "Producto";
            // 
            // gestionDeProToolStripMenuItem
            // 
            this.gestionDeProToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeProToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionDeProToolStripMenuItem.Image")));
            this.gestionDeProToolStripMenuItem.Name = "gestionDeProToolStripMenuItem";
            this.gestionDeProToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.gestionDeProToolStripMenuItem.Text = " Proveedores";
            // 
            // entradasDeInventarioToolStripMenuItem
            // 
            this.entradasDeInventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradasDeInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradasDeInventarioToolStripMenuItem.Image")));
            this.entradasDeInventarioToolStripMenuItem.Name = "entradasDeInventarioToolStripMenuItem";
            this.entradasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(183, 21);
            this.entradasDeInventarioToolStripMenuItem.Text = "Entradas de inventario";
            // 
            // salidasDeInventarioToolStripMenuItem
            // 
            this.salidasDeInventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidasDeInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salidasDeInventarioToolStripMenuItem.Image")));
            this.salidasDeInventarioToolStripMenuItem.Name = "salidasDeInventarioToolStripMenuItem";
            this.salidasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(173, 21);
            this.salidasDeInventarioToolStripMenuItem.Text = "Salidas de inventario";
            // 
            // movimientosDeInventarioToolStripMenuItem
            // 
            this.movimientosDeInventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosDeInventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimientosDeInventarioToolStripMenuItem.Image")));
            this.movimientosDeInventarioToolStripMenuItem.Name = "movimientosDeInventarioToolStripMenuItem";
            this.movimientosDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(215, 21);
            this.movimientosDeInventarioToolStripMenuItem.Text = " Movimientos de inventario";
            // 
            // timTiempo
            // 
            this.timTiempo.Tick += new System.EventHandler(this.timTiempo_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(398, 146);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(172, 32);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "4:08:00 p.m.";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Cyan;
            this.lblFecha.Location = new System.Drawing.Point(425, 201);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 24);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "24/03/24";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de almacen";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeInventarioToolStripMenuItem;
        private System.Windows.Forms.Timer timTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}

