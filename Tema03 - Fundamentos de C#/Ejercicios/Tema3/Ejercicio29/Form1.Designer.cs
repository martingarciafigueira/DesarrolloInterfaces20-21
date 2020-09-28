namespace Ejercicio29
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSerie = new System.Windows.Forms.RadioButton();
            this.rbParalelo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular resistencia final";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(115, 274);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(100, 20);
            this.txtR2.TabIndex = 1;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(115, 204);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(100, 20);
            this.txtR1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resistencia1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resistencia2";
            // 
            // rbSerie
            // 
            this.rbSerie.AutoSize = true;
            this.rbSerie.Checked = true;
            this.rbSerie.Location = new System.Drawing.Point(343, 222);
            this.rbSerie.Name = "rbSerie";
            this.rbSerie.Size = new System.Drawing.Size(63, 17);
            this.rbSerie.TabIndex = 5;
            this.rbSerie.TabStop = true;
            this.rbSerie.Text = "En serie";
            this.rbSerie.UseVisualStyleBackColor = true;
            // 
            // rbParalelo
            // 
            this.rbParalelo.AutoSize = true;
            this.rbParalelo.Location = new System.Drawing.Point(343, 260);
            this.rbParalelo.Name = "rbParalelo";
            this.rbParalelo.Size = new System.Drawing.Size(78, 17);
            this.rbParalelo.TabIndex = 6;
            this.rbParalelo.Text = "En paralelo";
            this.rbParalelo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbParalelo);
            this.Controls.Add(this.rbSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSerie;
        private System.Windows.Forms.RadioButton rbParalelo;
    }
}

