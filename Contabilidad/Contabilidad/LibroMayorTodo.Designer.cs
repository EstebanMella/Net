namespace Contabilidad
{
    partial class LibroMayorTodo
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
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dvgVerTodo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVerTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(49, 474);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(124, 30);
            this.btnMostar.TabIndex = 0;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(228, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.UseWaitCursor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dvgVerTodo
            // 
            this.dvgVerTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVerTodo.Location = new System.Drawing.Point(49, 34);
            this.dvgVerTodo.Name = "dvgVerTodo";
            this.dvgVerTodo.Size = new System.Drawing.Size(294, 363);
            this.dvgVerTodo.TabIndex = 2;
            // 
            // LibroMayorTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 561);
            this.Controls.Add(this.dvgVerTodo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostar);
            this.Name = "LibroMayorTodo";
            this.Text = "LibroMayorDesdeHasta";
            this.Load += new System.EventHandler(this.LibroMayorTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVerTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dvgVerTodo;
    }
}