namespace Ejercicio31
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
            this.grpBarrasSeguimiento = new System.Windows.Forms.GroupBox();
            this.grpCajasTexto = new System.Windows.Forms.GroupBox();
            this.rbBarrasSeguimiento = new System.Windows.Forms.RadioButton();
            this.rbCajasTexto = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.grpBarrasSeguimiento.SuspendLayout();
            this.grpCajasTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtener valores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBarrasSeguimiento
            // 
            this.grpBarrasSeguimiento.Controls.Add(this.trackBar1);
            this.grpBarrasSeguimiento.Controls.Add(this.trackBar2);
            this.grpBarrasSeguimiento.Controls.Add(this.trackBar3);
            this.grpBarrasSeguimiento.Location = new System.Drawing.Point(22, 21);
            this.grpBarrasSeguimiento.Name = "grpBarrasSeguimiento";
            this.grpBarrasSeguimiento.Size = new System.Drawing.Size(738, 100);
            this.grpBarrasSeguimiento.TabIndex = 1;
            this.grpBarrasSeguimiento.TabStop = false;
            this.grpBarrasSeguimiento.Text = "groupBox1";
            // 
            // grpCajasTexto
            // 
            this.grpCajasTexto.Controls.Add(this.textBox2);
            this.grpCajasTexto.Controls.Add(this.textBox3);
            this.grpCajasTexto.Controls.Add(this.textBox1);
            this.grpCajasTexto.Enabled = false;
            this.grpCajasTexto.Location = new System.Drawing.Point(22, 158);
            this.grpCajasTexto.Name = "grpCajasTexto";
            this.grpCajasTexto.Size = new System.Drawing.Size(738, 100);
            this.grpCajasTexto.TabIndex = 2;
            this.grpCajasTexto.TabStop = false;
            this.grpCajasTexto.Text = "groupBox2";
            // 
            // rbBarrasSeguimiento
            // 
            this.rbBarrasSeguimiento.AutoSize = true;
            this.rbBarrasSeguimiento.Checked = true;
            this.rbBarrasSeguimiento.Location = new System.Drawing.Point(300, 297);
            this.rbBarrasSeguimiento.Name = "rbBarrasSeguimiento";
            this.rbBarrasSeguimiento.Size = new System.Drawing.Size(171, 21);
            this.rbBarrasSeguimiento.TabIndex = 3;
            this.rbBarrasSeguimiento.TabStop = true;
            this.rbBarrasSeguimiento.Text = "Barras de seguimiento";
            this.rbBarrasSeguimiento.UseVisualStyleBackColor = true;
            this.rbBarrasSeguimiento.CheckedChanged += new System.EventHandler(this.rbBarrasSeguimiento_CheckedChanged);
            // 
            // rbCajasTexto
            // 
            this.rbCajasTexto.AutoSize = true;
            this.rbCajasTexto.Location = new System.Drawing.Point(300, 324);
            this.rbCajasTexto.Name = "rbCajasTexto";
            this.rbCajasTexto.Size = new System.Drawing.Size(118, 21);
            this.rbCajasTexto.TabIndex = 4;
            this.rbCajasTexto.TabStop = true;
            this.rbCajasTexto.Text = "Cajas de texto";
            this.rbCajasTexto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(564, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(74, 21);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(328, 21);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 56);
            this.trackBar2.TabIndex = 6;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(564, 21);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 56);
            this.trackBar3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbCajasTexto);
            this.Controls.Add(this.rbBarrasSeguimiento);
            this.Controls.Add(this.grpCajasTexto);
            this.Controls.Add(this.grpBarrasSeguimiento);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBarrasSeguimiento.ResumeLayout(false);
            this.grpBarrasSeguimiento.PerformLayout();
            this.grpCajasTexto.ResumeLayout(false);
            this.grpCajasTexto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBarrasSeguimiento;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox grpCajasTexto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbBarrasSeguimiento;
        private System.Windows.Forms.RadioButton rbCajasTexto;
    }
}

