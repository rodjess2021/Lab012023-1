namespace WinFormsApp1
{
    partial class PrincipalMDI
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
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            manUsuarios = new ToolStripMenuItem();
            manProductos = new ToolStripMenuItem();
            manCategorias = new ToolStripMenuItem();
            manProveedores = new ToolStripMenuItem();
            manClientes = new ToolStripMenuItem();
            regisVenta = new ToolStripMenuItem();
            regisCompra = new ToolStripMenuItem();
            reporteDeVentasToolStripMenuItem = new ToolStripMenuItem();
            reporteDeComprasToolStripMenuItem = new ToolStripMenuItem();
            inventarioDeProductosToolStripMenuItem = new ToolStripMenuItem();
            inventarioDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            reporteDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reporteDeClientesToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, procesosToolStripMenuItem, reportesToolStripMenuItem, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manUsuarios, manProductos, manCategorias, manProveedores, manClientes });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regisVenta, regisCompra });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeVentasToolStripMenuItem, reporteDeComprasToolStripMenuItem, inventarioDeProductosToolStripMenuItem, inventarioDeProveedoresToolStripMenuItem, reporteDeUsuariosToolStripMenuItem, reporteDeClientesToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // manUsuarios
            // 
            manUsuarios.Name = "manUsuarios";
            manUsuarios.Size = new Size(180, 22);
            manUsuarios.Text = "Usuarios";
            manUsuarios.Click += usuariosToolStripMenuItem_Click;
            // 
            // manProductos
            // 
            manProductos.Name = "manProductos";
            manProductos.Size = new Size(180, 22);
            manProductos.Text = "Productos";
            // 
            // manCategorias
            // 
            manCategorias.Name = "manCategorias";
            manCategorias.Size = new Size(180, 22);
            manCategorias.Text = "Categorías";
            // 
            // manProveedores
            // 
            manProveedores.Name = "manProveedores";
            manProveedores.Size = new Size(180, 22);
            manProveedores.Text = "Proveedores";
            // 
            // manClientes
            // 
            manClientes.Name = "manClientes";
            manClientes.Size = new Size(180, 22);
            manClientes.Text = "Clientes";
            // 
            // regisVenta
            // 
            regisVenta.Name = "regisVenta";
            regisVenta.Size = new Size(180, 22);
            regisVenta.Text = "Registrar Venta";
            // 
            // regisCompra
            // 
            regisCompra.Name = "regisCompra";
            regisCompra.Size = new Size(180, 22);
            regisCompra.Text = "Registrar Compra";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            reporteDeVentasToolStripMenuItem.Size = new Size(211, 22);
            reporteDeVentasToolStripMenuItem.Text = "Reporte de Ventas";
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            reporteDeComprasToolStripMenuItem.Size = new Size(211, 22);
            reporteDeComprasToolStripMenuItem.Text = "Reporte de Compras";
            // 
            // inventarioDeProductosToolStripMenuItem
            // 
            inventarioDeProductosToolStripMenuItem.Name = "inventarioDeProductosToolStripMenuItem";
            inventarioDeProductosToolStripMenuItem.Size = new Size(211, 22);
            inventarioDeProductosToolStripMenuItem.Text = "Inventario de Productos";
            // 
            // inventarioDeProveedoresToolStripMenuItem
            // 
            inventarioDeProveedoresToolStripMenuItem.Name = "inventarioDeProveedoresToolStripMenuItem";
            inventarioDeProveedoresToolStripMenuItem.Size = new Size(211, 22);
            inventarioDeProveedoresToolStripMenuItem.Text = "Inventario de Proveedores";
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            reporteDeUsuariosToolStripMenuItem.Size = new Size(211, 22);
            reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            reporteDeClientesToolStripMenuItem.Size = new Size(211, 22);
            reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(180, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // PrincipalMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "PrincipalMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem manUsuarios;
        private ToolStripMenuItem manProductos;
        private ToolStripMenuItem manCategorias;
        private ToolStripMenuItem manProveedores;
        private ToolStripMenuItem manClientes;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem regisVenta;
        private ToolStripMenuItem regisCompra;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private ToolStripMenuItem inventarioDeProductosToolStripMenuItem;
        private ToolStripMenuItem inventarioDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}