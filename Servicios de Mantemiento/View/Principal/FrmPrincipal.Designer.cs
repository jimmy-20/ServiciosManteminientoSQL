
namespace Servicios_de_Mantemiento.View.Principal
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mniVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.mniServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.matenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionesServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionesRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.verRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1052, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniClientes,
            this.mniVehiculos,
            this.toolStripSeparator2,
            this.mniServicios,
            this.mniRepuestos});
            this.catalogosToolStripMenuItem.Image = global::Servicios_de_Mantemiento.Properties.Resources.folder;
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoToolStripMenuItem,
            this.toolStripSeparator1,
            this.detalleToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recaudacionesServiciosToolStripMenuItem,
            this.recaudacionesRepuestosToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::Servicios_de_Mantemiento.Properties.Resources.info;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.verRegistroToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = global::Servicios_de_Mantemiento.Properties.Resources.shield;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // mniClientes
            // 
            this.mniClientes.Name = "mniClientes";
            this.mniClientes.Size = new System.Drawing.Size(270, 34);
            this.mniClientes.Text = "Clientes";
            this.mniClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mniVehiculos
            // 
            this.mniVehiculos.Name = "mniVehiculos";
            this.mniVehiculos.Size = new System.Drawing.Size(270, 34);
            this.mniVehiculos.Text = "Vehiculos";
            this.mniVehiculos.Click += new System.EventHandler(this.mniVehiculos_Click);
            // 
            // mniServicios
            // 
            this.mniServicios.Name = "mniServicios";
            this.mniServicios.Size = new System.Drawing.Size(270, 34);
            this.mniServicios.Text = "Servicios";
            this.mniServicios.Click += new System.EventHandler(this.mniServicios_Click);
            // 
            // mniRepuestos
            // 
            this.mniRepuestos.Name = "mniRepuestos";
            this.mniRepuestos.Size = new System.Drawing.Size(270, 34);
            this.mniRepuestos.Text = "Repuestos";
            this.mniRepuestos.Click += new System.EventHandler(this.mniRepuestos_Click);
            // 
            // matenimientoToolStripMenuItem
            // 
            this.matenimientoToolStripMenuItem.Name = "matenimientoToolStripMenuItem";
            this.matenimientoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.matenimientoToolStripMenuItem.Text = "Matenimiento";
            this.matenimientoToolStripMenuItem.Click += new System.EventHandler(this.matenimientoToolStripMenuItem_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.detalleToolStripMenuItem.Text = "Detalle";
            // 
            // recaudacionesServiciosToolStripMenuItem
            // 
            this.recaudacionesServiciosToolStripMenuItem.Name = "recaudacionesServiciosToolStripMenuItem";
            this.recaudacionesServiciosToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.recaudacionesServiciosToolStripMenuItem.Text = "Recaudaciones Servicios";
            // 
            // recaudacionesRepuestosToolStripMenuItem
            // 
            this.recaudacionesRepuestosToolStripMenuItem.Name = "recaudacionesRepuestosToolStripMenuItem";
            this.recaudacionesRepuestosToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.recaudacionesRepuestosToolStripMenuItem.Text = "Recaudaciones Repuestos";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // verRegistroToolStripMenuItem
            // 
            this.verRegistroToolStripMenuItem.Name = "verRegistroToolStripMenuItem";
            this.verRegistroToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verRegistroToolStripMenuItem.Text = "Ver registro";
            this.verRegistroToolStripMenuItem.Click += new System.EventHandler(this.verRegistroToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 723);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniClientes;
        private System.Windows.Forms.ToolStripMenuItem mniVehiculos;
        private System.Windows.Forms.ToolStripMenuItem mniServicios;
        private System.Windows.Forms.ToolStripMenuItem mniRepuestos;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionesServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionesRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem verRegistroToolStripMenuItem;
    }
}