namespace Actividad1_HolaMundo
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
            this.DatPer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatPer
            // 
            this.DatPer.AutoSize = true;
            this.DatPer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatPer.Location = new System.Drawing.Point(219, 154);
            this.DatPer.Name = "DatPer";
            this.DatPer.Size = new System.Drawing.Size(401, 116);
            this.DatPer.TabIndex = 0;
            this.DatPer.Text = "Nombre: José Manuel Ortiz Trujano.\r\nID: 176662\r\n\r\nGraficación y Videojuegos\r\n";
            this.DatPer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatPer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DatPer;
    }
}

