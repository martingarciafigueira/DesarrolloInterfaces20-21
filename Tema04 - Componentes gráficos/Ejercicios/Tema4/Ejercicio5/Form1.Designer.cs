namespace Ejercicio5
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
            this.btnMoverElementoIZQDER = new System.Windows.Forms.Button();
            this.lstTitulares = new System.Windows.Forms.ListBox();
            this.lstSuplentes = new System.Windows.Forms.ListBox();
            this.btnMoverElementoDERIZQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoverElementoIZQDER
            // 
            this.btnMoverElementoIZQDER.Location = new System.Drawing.Point(264, 137);
            this.btnMoverElementoIZQDER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoverElementoIZQDER.Name = "btnMoverElementoIZQDER";
            this.btnMoverElementoIZQDER.Size = new System.Drawing.Size(35, 19);
            this.btnMoverElementoIZQDER.TabIndex = 7;
            this.btnMoverElementoIZQDER.Text = ">";
            this.btnMoverElementoIZQDER.UseVisualStyleBackColor = true;
            this.btnMoverElementoIZQDER.Click += new System.EventHandler(this.btnMoverElementoIZQDER_Click);
            // 
            // lstTitulares
            // 
            this.lstTitulares.FormattingEnabled = true;
            this.lstTitulares.Items.AddRange(new object[] {
            "Leo Messi",
            "Cristiano Ronaldo",
            "Kylian Mbappé",
            "Neymar Junior"});
            this.lstTitulares.Location = new System.Drawing.Point(151, 93);
            this.lstTitulares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTitulares.Name = "lstTitulares";
            this.lstTitulares.Size = new System.Drawing.Size(98, 121);
            this.lstTitulares.TabIndex = 12;
            // 
            // lstSuplentes
            // 
            this.lstSuplentes.FormattingEnabled = true;
            this.lstSuplentes.Items.AddRange(new object[] {
            "Zinedine Zidane",
            "Johan Cruyff",
            "Alfredo Di Stefano",
            "Diego Armando Maradona"});
            this.lstSuplentes.Location = new System.Drawing.Point(314, 93);
            this.lstSuplentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSuplentes.Name = "lstSuplentes";
            this.lstSuplentes.Size = new System.Drawing.Size(136, 121);
            this.lstSuplentes.TabIndex = 13;
            // 
            // btnMoverElementoDERIZQ
            // 
            this.btnMoverElementoDERIZQ.Location = new System.Drawing.Point(264, 160);
            this.btnMoverElementoDERIZQ.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoverElementoDERIZQ.Name = "btnMoverElementoDERIZQ";
            this.btnMoverElementoDERIZQ.Size = new System.Drawing.Size(35, 19);
            this.btnMoverElementoDERIZQ.TabIndex = 14;
            this.btnMoverElementoDERIZQ.Text = "<";
            this.btnMoverElementoDERIZQ.UseVisualStyleBackColor = true;
            this.btnMoverElementoDERIZQ.Click += new System.EventHandler(this.btnMoverElementoDERIZQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Suplentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Titulares";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMoverElementoDERIZQ);
            this.Controls.Add(this.lstSuplentes);
            this.Controls.Add(this.lstTitulares);
            this.Controls.Add(this.btnMoverElementoIZQDER);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMoverElementoIZQDER;
        private System.Windows.Forms.ListBox lstTitulares;
        private System.Windows.Forms.ListBox lstSuplentes;
        private System.Windows.Forms.Button btnMoverElementoDERIZQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

