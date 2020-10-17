namespace Ejercicio6
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoverElementoDERIZQ = new System.Windows.Forms.Button();
            this.lstSuplentes = new System.Windows.Forms.ListBox();
            this.lstTitulares = new System.Windows.Forms.ListBox();
            this.btnMoverElementoIZQDER = new System.Windows.Forms.Button();
            this.btnEliminarElementoSuplentes = new System.Windows.Forms.Button();
            this.btnVaciarListaSuplentes = new System.Windows.Forms.Button();
            this.btnVaciarListaTitulares = new System.Windows.Forms.Button();
            this.btnEliminarElementoTitulares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titulares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Suplentes";
            // 
            // btnMoverElementoDERIZQ
            // 
            this.btnMoverElementoDERIZQ.Location = new System.Drawing.Point(367, 216);
            this.btnMoverElementoDERIZQ.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoverElementoDERIZQ.Name = "btnMoverElementoDERIZQ";
            this.btnMoverElementoDERIZQ.Size = new System.Drawing.Size(35, 19);
            this.btnMoverElementoDERIZQ.TabIndex = 21;
            this.btnMoverElementoDERIZQ.Text = "<";
            this.btnMoverElementoDERIZQ.UseVisualStyleBackColor = true;
            this.btnMoverElementoDERIZQ.Click += new System.EventHandler(this.btnMoverElementoDERIZQ_Click_1);
            // 
            // lstSuplentes
            // 
            this.lstSuplentes.FormattingEnabled = true;
            this.lstSuplentes.Items.AddRange(new object[] {
            "Zinedine Zidane",
            "Johan Cruyff",
            "Alfredo Di Stefano",
            "Diego Armando Maradona"});
            this.lstSuplentes.Location = new System.Drawing.Point(417, 149);
            this.lstSuplentes.Margin = new System.Windows.Forms.Padding(2);
            this.lstSuplentes.Name = "lstSuplentes";
            this.lstSuplentes.Size = new System.Drawing.Size(136, 121);
            this.lstSuplentes.TabIndex = 20;
            // 
            // lstTitulares
            // 
            this.lstTitulares.FormattingEnabled = true;
            this.lstTitulares.Items.AddRange(new object[] {
            "Leo Messi",
            "Cristiano Ronaldo",
            "Kylian Mbappé",
            "Neymar Junior"});
            this.lstTitulares.Location = new System.Drawing.Point(254, 149);
            this.lstTitulares.Margin = new System.Windows.Forms.Padding(2);
            this.lstTitulares.Name = "lstTitulares";
            this.lstTitulares.Size = new System.Drawing.Size(98, 121);
            this.lstTitulares.TabIndex = 19;
            // 
            // btnMoverElementoIZQDER
            // 
            this.btnMoverElementoIZQDER.Location = new System.Drawing.Point(367, 193);
            this.btnMoverElementoIZQDER.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoverElementoIZQDER.Name = "btnMoverElementoIZQDER";
            this.btnMoverElementoIZQDER.Size = new System.Drawing.Size(35, 19);
            this.btnMoverElementoIZQDER.TabIndex = 18;
            this.btnMoverElementoIZQDER.Text = ">";
            this.btnMoverElementoIZQDER.UseVisualStyleBackColor = true;
            this.btnMoverElementoIZQDER.Click += new System.EventHandler(this.btnMoverElementoIZQDER_Click);
            // 
            // btnEliminarElementoSuplentes
            // 
            this.btnEliminarElementoSuplentes.Location = new System.Drawing.Point(430, 275);
            this.btnEliminarElementoSuplentes.Name = "btnEliminarElementoSuplentes";
            this.btnEliminarElementoSuplentes.Size = new System.Drawing.Size(108, 23);
            this.btnEliminarElementoSuplentes.TabIndex = 26;
            this.btnEliminarElementoSuplentes.Text = "Eliminar elemento";
            this.btnEliminarElementoSuplentes.UseVisualStyleBackColor = true;
            this.btnEliminarElementoSuplentes.Click += new System.EventHandler(this.btnEliminarElementoSuplentes_Click);
            // 
            // btnVaciarListaSuplentes
            // 
            this.btnVaciarListaSuplentes.Location = new System.Drawing.Point(445, 304);
            this.btnVaciarListaSuplentes.Name = "btnVaciarListaSuplentes";
            this.btnVaciarListaSuplentes.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarListaSuplentes.TabIndex = 27;
            this.btnVaciarListaSuplentes.Text = "Vaciar lista";
            this.btnVaciarListaSuplentes.UseVisualStyleBackColor = true;
            this.btnVaciarListaSuplentes.Click += new System.EventHandler(this.btnVaciarListaSuplentes_Click);
            // 
            // btnVaciarListaTitulares
            // 
            this.btnVaciarListaTitulares.Location = new System.Drawing.Point(269, 304);
            this.btnVaciarListaTitulares.Name = "btnVaciarListaTitulares";
            this.btnVaciarListaTitulares.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarListaTitulares.TabIndex = 29;
            this.btnVaciarListaTitulares.Text = "Vaciar lista";
            this.btnVaciarListaTitulares.UseVisualStyleBackColor = true;
            this.btnVaciarListaTitulares.Click += new System.EventHandler(this.btnVaciarListaTitulares_Click);
            // 
            // btnEliminarElementoTitulares
            // 
            this.btnEliminarElementoTitulares.Location = new System.Drawing.Point(254, 275);
            this.btnEliminarElementoTitulares.Name = "btnEliminarElementoTitulares";
            this.btnEliminarElementoTitulares.Size = new System.Drawing.Size(108, 23);
            this.btnEliminarElementoTitulares.TabIndex = 28;
            this.btnEliminarElementoTitulares.Text = "Eliminar elemento";
            this.btnEliminarElementoTitulares.UseVisualStyleBackColor = true;
            this.btnEliminarElementoTitulares.Click += new System.EventHandler(this.btnEliminarElementoTitulares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVaciarListaTitulares);
            this.Controls.Add(this.btnEliminarElementoTitulares);
            this.Controls.Add(this.btnVaciarListaSuplentes);
            this.Controls.Add(this.btnEliminarElementoSuplentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoverElementoDERIZQ);
            this.Controls.Add(this.lstSuplentes);
            this.Controls.Add(this.lstTitulares);
            this.Controls.Add(this.btnMoverElementoIZQDER);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoverElementoDERIZQ;
        private System.Windows.Forms.ListBox lstSuplentes;
        private System.Windows.Forms.ListBox lstTitulares;
        private System.Windows.Forms.Button btnMoverElementoIZQDER;
        private System.Windows.Forms.Button btnEliminarElementoSuplentes;
        private System.Windows.Forms.Button btnVaciarListaSuplentes;
        private System.Windows.Forms.Button btnVaciarListaTitulares;
        private System.Windows.Forms.Button btnEliminarElementoTitulares;
    }
}

