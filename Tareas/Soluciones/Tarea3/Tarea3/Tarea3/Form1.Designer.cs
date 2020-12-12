namespace Tarea3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarContactos = new System.Windows.Forms.Button();
            this.btnEditarContactos = new System.Windows.Forms.Button();
            this.btnBorrarContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda de contactos";
            // 
            // btnAgregarContactos
            // 
            this.btnAgregarContactos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarContactos.Location = new System.Drawing.Point(49, 95);
            this.btnAgregarContactos.Name = "btnAgregarContactos";
            this.btnAgregarContactos.Size = new System.Drawing.Size(325, 49);
            this.btnAgregarContactos.TabIndex = 1;
            this.btnAgregarContactos.Text = "Agregar contacto nuevo";
            this.btnAgregarContactos.UseVisualStyleBackColor = true;
            this.btnAgregarContactos.Click += new System.EventHandler(this.btnAgregarContactos_Click);
            // 
            // btnEditarContactos
            // 
            this.btnEditarContactos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContactos.Location = new System.Drawing.Point(49, 150);
            this.btnEditarContactos.Name = "btnEditarContactos";
            this.btnEditarContactos.Size = new System.Drawing.Size(325, 49);
            this.btnEditarContactos.TabIndex = 2;
            this.btnEditarContactos.Text = "Editar contactos";
            this.btnEditarContactos.UseVisualStyleBackColor = true;
            this.btnEditarContactos.Click += new System.EventHandler(this.btnEditarContactos_Click);
            // 
            // btnBorrarContacto
            // 
            this.btnBorrarContacto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarContacto.Location = new System.Drawing.Point(49, 205);
            this.btnBorrarContacto.Name = "btnBorrarContacto";
            this.btnBorrarContacto.Size = new System.Drawing.Size(325, 49);
            this.btnBorrarContacto.TabIndex = 3;
            this.btnBorrarContacto.Text = "Borrar contacto";
            this.btnBorrarContacto.UseVisualStyleBackColor = true;
            this.btnBorrarContacto.Click += new System.EventHandler(this.btnBorrarContacto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Tarea3.Properties.Resources.gradient_simple_background_xs_1024x768;
            this.ClientSize = new System.Drawing.Size(425, 284);
            this.Controls.Add(this.btnBorrarContacto);
            this.Controls.Add(this.btnEditarContactos);
            this.Controls.Add(this.btnAgregarContactos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarContactos;
        private System.Windows.Forms.Button btnEditarContactos;
        private System.Windows.Forms.Button btnBorrarContacto;
    }
}

