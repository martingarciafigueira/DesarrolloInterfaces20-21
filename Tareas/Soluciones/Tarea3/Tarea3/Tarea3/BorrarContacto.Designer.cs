namespace Tarea3
{
    partial class BorrarContacto
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbContacto = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 17F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Contacto";
            // 
            // cmbContacto
            // 
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Location = new System.Drawing.Point(188, 65);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(126, 21);
            this.cmbContacto.TabIndex = 33;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(103, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 34);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Borrar Contacto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BorrarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tarea3.Properties.Resources.gradient_simple_background_xs_1024x768;
            this.ClientSize = new System.Drawing.Size(389, 193);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbContacto);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BorrarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Contacto";
            this.Load += new System.EventHandler(this.BorrarContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbContacto;
        private System.Windows.Forms.Button btnEliminar;
    }
}