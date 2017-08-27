namespace Contabilidad
{
    partial class LibroDiarioVerTodo
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
            this.dvgVertodo = new System.Windows.Forms.DataGridView();
            this.btnMostar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVertodo)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgVertodo
            // 
            this.dvgVertodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVertodo.Location = new System.Drawing.Point(59, 32);
            this.dvgVertodo.Name = "dvgVertodo";
            this.dvgVertodo.Size = new System.Drawing.Size(273, 369);
            this.dvgVertodo.TabIndex = 0;
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(59, 434);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(113, 37);
            this.btnMostar.TabIndex = 1;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(217, 434);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LibroDiarioVerTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 509);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.dvgVertodo);
            this.Name = "LibroDiarioVerTodo";
            this.Text = "LibroDiarioVerTodo";
            ((System.ComponentModel.ISupportInitialize)(this.dvgVertodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgVertodo;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Button btnSalir;
    }
}