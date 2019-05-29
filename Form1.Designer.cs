namespace EjercicioEntityFramework
{
    partial class Form1
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
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(26, 29);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(75, 23);
            this.btnRecetas.TabIndex = 0;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(165, 29);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(75, 23);
            this.btnMascotas.TabIndex = 1;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 97);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnRecetas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnMascotas;
    }
}

