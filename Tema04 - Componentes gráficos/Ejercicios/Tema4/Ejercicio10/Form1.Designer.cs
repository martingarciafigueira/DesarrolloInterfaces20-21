namespace Ejercicio10
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
            this.txtVolumenPiscina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExtremoProfundo = new System.Windows.Forms.TrackBar();
            this.tbExtremoMenosProfundo = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbExtremoProfundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbExtremoMenosProfundo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVolumenPiscina
            // 
            this.txtVolumenPiscina.Location = new System.Drawing.Point(390, 296);
            this.txtVolumenPiscina.Name = "txtVolumenPiscina";
            this.txtVolumenPiscina.Size = new System.Drawing.Size(100, 20);
            this.txtVolumenPiscina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volumen piscina:";
            // 
            // tbExtremoProfundo
            // 
            this.tbExtremoProfundo.Location = new System.Drawing.Point(415, 66);
            this.tbExtremoProfundo.Maximum = 100;
            this.tbExtremoProfundo.Minimum = 1;
            this.tbExtremoProfundo.Name = "tbExtremoProfundo";
            this.tbExtremoProfundo.Size = new System.Drawing.Size(104, 45);
            this.tbExtremoProfundo.TabIndex = 2;
            this.tbExtremoProfundo.Value = 1;
            this.tbExtremoProfundo.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // tbExtremoMenosProfundo
            // 
            this.tbExtremoMenosProfundo.Location = new System.Drawing.Point(415, 155);
            this.tbExtremoMenosProfundo.Maximum = 100;
            this.tbExtremoMenosProfundo.Minimum = 1;
            this.tbExtremoMenosProfundo.Name = "tbExtremoMenosProfundo";
            this.tbExtremoMenosProfundo.Size = new System.Drawing.Size(104, 45);
            this.tbExtremoMenosProfundo.TabIndex = 3;
            this.tbExtremoMenosProfundo.Value = 1;
            this.tbExtremoMenosProfundo.ValueChanged += new System.EventHandler(this.tbExtremoMenosProfundo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extremo más profundo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extremo menos profundo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbExtremoMenosProfundo);
            this.Controls.Add(this.tbExtremoProfundo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolumenPiscina);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbExtremoProfundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbExtremoMenosProfundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVolumenPiscina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbExtremoProfundo;
        private System.Windows.Forms.TrackBar tbExtremoMenosProfundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

