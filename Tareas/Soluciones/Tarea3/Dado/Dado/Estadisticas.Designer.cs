namespace Dado
{
    partial class Estadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTiradaFrecuente = new System.Windows.Forms.Label();
            this.lblSumaTiradas = new System.Windows.Forms.Label();
            this.lblTiradaActual = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tirada actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suma de tiradas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tirada más frecuente:";
            // 
            // lblTiradaFrecuente
            // 
            this.lblTiradaFrecuente.AutoSize = true;
            this.lblTiradaFrecuente.BackColor = System.Drawing.Color.Transparent;
            this.lblTiradaFrecuente.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiradaFrecuente.ForeColor = System.Drawing.Color.White;
            this.lblTiradaFrecuente.Location = new System.Drawing.Point(298, 149);
            this.lblTiradaFrecuente.Name = "lblTiradaFrecuente";
            this.lblTiradaFrecuente.Size = new System.Drawing.Size(0, 23);
            this.lblTiradaFrecuente.TabIndex = 6;
            // 
            // lblSumaTiradas
            // 
            this.lblSumaTiradas.AutoSize = true;
            this.lblSumaTiradas.BackColor = System.Drawing.Color.Transparent;
            this.lblSumaTiradas.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaTiradas.ForeColor = System.Drawing.Color.White;
            this.lblSumaTiradas.Location = new System.Drawing.Point(298, 189);
            this.lblSumaTiradas.Name = "lblSumaTiradas";
            this.lblSumaTiradas.Size = new System.Drawing.Size(0, 23);
            this.lblSumaTiradas.TabIndex = 5;
            // 
            // lblTiradaActual
            // 
            this.lblTiradaActual.AutoSize = true;
            this.lblTiradaActual.BackColor = System.Drawing.Color.Transparent;
            this.lblTiradaActual.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiradaActual.ForeColor = System.Drawing.Color.White;
            this.lblTiradaActual.Location = new System.Drawing.Point(298, 109);
            this.lblTiradaActual.Name = "lblTiradaActual";
            this.lblTiradaActual.Size = new System.Drawing.Size(0, 23);
            this.lblTiradaActual.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(184, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estadísticas";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dado.Properties.Resources.gradient_simple_background_xs_1024x768;
            this.ClientSize = new System.Drawing.Size(517, 293);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTiradaFrecuente);
            this.Controls.Add(this.lblSumaTiradas);
            this.Controls.Add(this.lblTiradaActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTiradaFrecuente;
        private System.Windows.Forms.Label lblSumaTiradas;
        private System.Windows.Forms.Label lblTiradaActual;
        private System.Windows.Forms.Label label7;
    }
}