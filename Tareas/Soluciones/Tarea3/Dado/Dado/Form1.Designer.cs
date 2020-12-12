namespace Dado
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
            this.picDado = new System.Windows.Forms.PictureBox();
            this.btnLanzarDado = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).BeginInit();
            this.SuspendLayout();
            // 
            // picDado
            // 
            this.picDado.Location = new System.Drawing.Point(111, 38);
            this.picDado.Name = "picDado";
            this.picDado.Size = new System.Drawing.Size(263, 234);
            this.picDado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDado.TabIndex = 0;
            this.picDado.TabStop = false;
            // 
            // btnLanzarDado
            // 
            this.btnLanzarDado.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanzarDado.Location = new System.Drawing.Point(90, 301);
            this.btnLanzarDado.Name = "btnLanzarDado";
            this.btnLanzarDado.Size = new System.Drawing.Size(132, 34);
            this.btnLanzarDado.TabIndex = 1;
            this.btnLanzarDado.Text = "Lanzar dado";
            this.btnLanzarDado.UseVisualStyleBackColor = true;
            this.btnLanzarDado.Click += new System.EventHandler(this.btnLanzarDado_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(254, 301);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(132, 34);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dado.Properties.Resources.gradient_simple_background_xs_1024x768;
            this.ClientSize = new System.Drawing.Size(475, 363);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnLanzarDado);
            this.Controls.Add(this.picDado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dado";
            ((System.ComponentModel.ISupportInitialize)(this.picDado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDado;
        private System.Windows.Forms.Button btnLanzarDado;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

