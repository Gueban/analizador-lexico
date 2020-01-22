namespace Analizador_léxico
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
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.btn_evaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(62, 35);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(252, 22);
            this.txtentrada.TabIndex = 0;
            // 
            // btn_evaluar
            // 
            this.btn_evaluar.Location = new System.Drawing.Point(132, 75);
            this.btn_evaluar.Name = "btn_evaluar";
            this.btn_evaluar.Size = new System.Drawing.Size(92, 23);
            this.btn_evaluar.TabIndex = 1;
            this.btn_evaluar.Text = "EVALUAR";
            this.btn_evaluar.UseVisualStyleBackColor = true;
            this.btn_evaluar.Click += new System.EventHandler(this.Btn_evaluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 133);
            this.Controls.Add(this.btn_evaluar);
            this.Controls.Add(this.txtentrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.Button btn_evaluar;
    }
}

