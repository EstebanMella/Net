namespace Contabilidad
{
    partial class Contabilidad
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
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarIngresoegresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorFechaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.verToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarCuentaToolStripMenuItem,
            this.eliminarCuentaToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // insertarCuentaToolStripMenuItem
            // 
            this.insertarCuentaToolStripMenuItem.Name = "insertarCuentaToolStripMenuItem";
            this.insertarCuentaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.insertarCuentaToolStripMenuItem.Text = "Insertar cuenta";
            this.insertarCuentaToolStripMenuItem.Click += new System.EventHandler(this.insertarCuentaToolStripMenuItem_Click);
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            this.eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            this.eliminarCuentaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarCuentaToolStripMenuItem.Text = "Eliminar cuenta";
            this.eliminarCuentaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCuentaToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarIngresoegresoToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // registrarIngresoegresoToolStripMenuItem
            // 
            this.registrarIngresoegresoToolStripMenuItem.Name = "registrarIngresoegresoToolStripMenuItem";
            this.registrarIngresoegresoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registrarIngresoegresoToolStripMenuItem.Text = "Registrar ingreso/egreso";
            this.registrarIngresoegresoToolStripMenuItem.Click += new System.EventHandler(this.registrarIngresoegresoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroDiarioToolStripMenuItem,
            this.libroMayorToolStripMenuItem,
            this.balanceToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // libroDiarioToolStripMenuItem
            // 
            this.libroDiarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoToolStripMenuItem,
            this.buscarPorFechaToolStripMenuItem});
            this.libroDiarioToolStripMenuItem.Name = "libroDiarioToolStripMenuItem";
            this.libroDiarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.libroDiarioToolStripMenuItem.Text = "Libro diario";
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verTodoToolStripMenuItem.Text = "Ver todo";
            this.verTodoToolStripMenuItem.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // buscarPorFechaToolStripMenuItem
            // 
            this.buscarPorFechaToolStripMenuItem.Name = "buscarPorFechaToolStripMenuItem";
            this.buscarPorFechaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.buscarPorFechaToolStripMenuItem.Text = "Buscar por fecha";
            this.buscarPorFechaToolStripMenuItem.Click += new System.EventHandler(this.buscarPorFechaToolStripMenuItem_Click);
            // 
            // libroMayorToolStripMenuItem
            // 
            this.libroMayorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoToolStripMenuItem1,
            this.buscarPorFechaToolStripMenuItem1});
            this.libroMayorToolStripMenuItem.Name = "libroMayorToolStripMenuItem";
            this.libroMayorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.libroMayorToolStripMenuItem.Text = "Libro mayor";
            // 
            // verTodoToolStripMenuItem1
            // 
            this.verTodoToolStripMenuItem1.Name = "verTodoToolStripMenuItem1";
            this.verTodoToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.verTodoToolStripMenuItem1.Text = "Ver todo";
            this.verTodoToolStripMenuItem1.Click += new System.EventHandler(this.verTodoToolStripMenuItem1_Click);
            // 
            // buscarPorFechaToolStripMenuItem1
            // 
            this.buscarPorFechaToolStripMenuItem1.Name = "buscarPorFechaToolStripMenuItem1";
            this.buscarPorFechaToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.buscarPorFechaToolStripMenuItem1.Text = "Buscar por fecha";
            this.buscarPorFechaToolStripMenuItem1.Click += new System.EventHandler(this.buscarPorFechaToolStripMenuItem1_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoToolStripMenuItem2,
            this.buscarPorFechaToolStripMenuItem2});
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // verTodoToolStripMenuItem2
            // 
            this.verTodoToolStripMenuItem2.Name = "verTodoToolStripMenuItem2";
            this.verTodoToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.verTodoToolStripMenuItem2.Text = "Ver todo";
            // 
            // buscarPorFechaToolStripMenuItem2
            // 
            this.buscarPorFechaToolStripMenuItem2.Name = "buscarPorFechaToolStripMenuItem2";
            this.buscarPorFechaToolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.buscarPorFechaToolStripMenuItem2.Text = "Buscar por fecha";
            this.buscarPorFechaToolStripMenuItem2.Click += new System.EventHandler(this.buscarPorFechaToolStripMenuItem2_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 521);
            this.panel1.TabIndex = 1;
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Contabilidad";
            this.Text = "Contabilidad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuentaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem registrarIngresoegresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarPorFechaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

