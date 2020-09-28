namespace Ejercicio28
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
            this.btnConvertirAFahrenheit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.btnConvertirACelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertirAFahrenheit
            // 
            this.btnConvertirAFahrenheit.Location = new System.Drawing.Point(516, 125);
            this.btnConvertirAFahrenheit.Name = "btnConvertirAFahrenheit";
            this.btnConvertirAFahrenheit.Size = new System.Drawing.Size(177, 23);
            this.btnConvertirAFahrenheit.TabIndex = 8;
            this.btnConvertirAFahrenheit.Text = "Realizar conversión a Fahrenheit";
            this.btnConvertirAFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirAFahrenheit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grados iniciales";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(377, 166);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 6;
            // 
            // btnConvertirACelsius
            // 
            this.btnConvertirACelsius.Location = new System.Drawing.Point(516, 199);
            this.btnConvertirACelsius.Name = "btnConvertirACelsius";
            this.btnConvertirACelsius.Size = new System.Drawing.Size(177, 23);
            this.btnConvertirACelsius.TabIndex = 9;
            this.btnConvertirACelsius.Text = "Realizar conversión a Celsius";
            this.btnConvertirACelsius.UseVisualStyleBackColor = true;
            this.btnConvertirACelsius.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertirACelsius);
            this.Controls.Add(this.btnConvertirAFahrenheit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertirAFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Button btnConvertirACelsius;
    }
}

