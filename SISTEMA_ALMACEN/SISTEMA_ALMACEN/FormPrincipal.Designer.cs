﻿namespace SISTEMA_ALMACEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de almacen";
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
    }
}
