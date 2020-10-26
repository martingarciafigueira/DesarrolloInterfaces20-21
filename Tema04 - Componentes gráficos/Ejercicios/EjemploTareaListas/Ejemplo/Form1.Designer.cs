namespace Ejemplo
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
            this.lstTitulares = new System.Windows.Forms.ListBox();
            this.lstSuplentes = new System.Windows.Forms.ListBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRigth = new System.Windows.Forms.Button();
            this.btnVaciarListaTitulares = new System.Windows.Forms.Button();
            this.btnEliminarElementoTitulares = new System.Windows.Forms.Button();
            this.btnVaciarListaSuplentes = new System.Windows.Forms.Button();
            this.btnEliminarElementoSuplentes = new System.Windows.Forms.Button();
            this.btnPasarListaRigthLeft = new System.Windows.Forms.Button();
            this.btnPasarListaLeftRigth = new System.Windows.Forms.Button();
            this.txtElementoBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultadoBusqueda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarJugador = new System.Windows.Forms.Button();
            this.dtpDiaPartido = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarAlineacion = new System.Windows.Forms.Button();
            this.lstHistoricoAlineaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(929, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suplentes";
            // 
            // lstTitulares
            // 
            this.lstTitulares.FormattingEnabled = true;
            this.lstTitulares.Location = new System.Drawing.Point(591, 156);
            this.lstTitulares.Name = "lstTitulares";
            this.lstTitulares.Size = new System.Drawing.Size(120, 95);
            this.lstTitulares.TabIndex = 2;
            // 
            // lstSuplentes
            // 
            this.lstSuplentes.FormattingEnabled = true;
            this.lstSuplentes.Location = new System.Drawing.Point(935, 156);
            this.lstSuplentes.Name = "lstSuplentes";
            this.lstSuplentes.Size = new System.Drawing.Size(120, 95);
            this.lstSuplentes.TabIndex = 3;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(781, 194);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRigth
            // 
            this.btnRigth.Location = new System.Drawing.Point(781, 237);
            this.btnRigth.Name = "btnRigth";
            this.btnRigth.Size = new System.Drawing.Size(75, 23);
            this.btnRigth.TabIndex = 5;
            this.btnRigth.Text = ">";
            this.btnRigth.UseVisualStyleBackColor = true;
            this.btnRigth.Click += new System.EventHandler(this.btnRigth_Click);
            // 
            // btnVaciarListaTitulares
            // 
            this.btnVaciarListaTitulares.Location = new System.Drawing.Point(591, 257);
            this.btnVaciarListaTitulares.Name = "btnVaciarListaTitulares";
            this.btnVaciarListaTitulares.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarListaTitulares.TabIndex = 6;
            this.btnVaciarListaTitulares.Text = "Vaciar lista";
            this.btnVaciarListaTitulares.UseVisualStyleBackColor = true;
            this.btnVaciarListaTitulares.Click += new System.EventHandler(this.btnVaciarListaTitulares_Click);
            // 
            // btnEliminarElementoTitulares
            // 
            this.btnEliminarElementoTitulares.Location = new System.Drawing.Point(591, 293);
            this.btnEliminarElementoTitulares.Name = "btnEliminarElementoTitulares";
            this.btnEliminarElementoTitulares.Size = new System.Drawing.Size(99, 23);
            this.btnEliminarElementoTitulares.TabIndex = 7;
            this.btnEliminarElementoTitulares.Text = "Eliminar elemento";
            this.btnEliminarElementoTitulares.UseVisualStyleBackColor = true;
            this.btnEliminarElementoTitulares.Click += new System.EventHandler(this.btnEliminarElementoTitulares_Click);
            // 
            // btnVaciarListaSuplentes
            // 
            this.btnVaciarListaSuplentes.Location = new System.Drawing.Point(980, 257);
            this.btnVaciarListaSuplentes.Name = "btnVaciarListaSuplentes";
            this.btnVaciarListaSuplentes.Size = new System.Drawing.Size(75, 23);
            this.btnVaciarListaSuplentes.TabIndex = 8;
            this.btnVaciarListaSuplentes.Text = "Vaciar lista";
            this.btnVaciarListaSuplentes.UseVisualStyleBackColor = true;
            this.btnVaciarListaSuplentes.Click += new System.EventHandler(this.btnVaciarListaSuplentes_Click);
            // 
            // btnEliminarElementoSuplentes
            // 
            this.btnEliminarElementoSuplentes.Location = new System.Drawing.Point(952, 293);
            this.btnEliminarElementoSuplentes.Name = "btnEliminarElementoSuplentes";
            this.btnEliminarElementoSuplentes.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarElementoSuplentes.TabIndex = 9;
            this.btnEliminarElementoSuplentes.Text = "Eliminar elemento";
            this.btnEliminarElementoSuplentes.UseVisualStyleBackColor = true;
            this.btnEliminarElementoSuplentes.Click += new System.EventHandler(this.btnEliminarElementoSuplentes_Click);
            // 
            // btnPasarListaRigthLeft
            // 
            this.btnPasarListaRigthLeft.Location = new System.Drawing.Point(781, 156);
            this.btnPasarListaRigthLeft.Name = "btnPasarListaRigthLeft";
            this.btnPasarListaRigthLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPasarListaRigthLeft.TabIndex = 10;
            this.btnPasarListaRigthLeft.Text = "<<";
            this.btnPasarListaRigthLeft.UseVisualStyleBackColor = true;
            this.btnPasarListaRigthLeft.Click += new System.EventHandler(this.btnPasarListaRigthLeft_Click);
            // 
            // btnPasarListaLeftRigth
            // 
            this.btnPasarListaLeftRigth.Location = new System.Drawing.Point(781, 275);
            this.btnPasarListaLeftRigth.Name = "btnPasarListaLeftRigth";
            this.btnPasarListaLeftRigth.Size = new System.Drawing.Size(75, 23);
            this.btnPasarListaLeftRigth.TabIndex = 11;
            this.btnPasarListaLeftRigth.Text = ">>";
            this.btnPasarListaLeftRigth.UseVisualStyleBackColor = true;
            this.btnPasarListaLeftRigth.Click += new System.EventHandler(this.btnPasarListaLeftRigth_Click);
            // 
            // txtElementoBusqueda
            // 
            this.txtElementoBusqueda.Location = new System.Drawing.Point(728, 52);
            this.txtElementoBusqueda.Name = "txtElementoBusqueda";
            this.txtElementoBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtElementoBusqueda.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(872, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResultadoBusqueda
            // 
            this.lblResultadoBusqueda.AutoSize = true;
            this.lblResultadoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoBusqueda.Location = new System.Drawing.Point(929, 386);
            this.lblResultadoBusqueda.Name = "lblResultadoBusqueda";
            this.lblResultadoBusqueda.Size = new System.Drawing.Size(0, 31);
            this.lblResultadoBusqueda.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Buscador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(176, 199);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 17;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(176, 240);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "DNI";
            // 
            // btnInsertarJugador
            // 
            this.btnInsertarJugador.Location = new System.Drawing.Point(107, 304);
            this.btnInsertarJugador.Name = "btnInsertarJugador";
            this.btnInsertarJugador.Size = new System.Drawing.Size(169, 42);
            this.btnInsertarJugador.TabIndex = 22;
            this.btnInsertarJugador.Text = "INSERTAR JUGADOR";
            this.btnInsertarJugador.UseVisualStyleBackColor = true;
            this.btnInsertarJugador.Click += new System.EventHandler(this.btnInsertarJugador_Click);
            // 
            // dtpDiaPartido
            // 
            this.dtpDiaPartido.Location = new System.Drawing.Point(738, 410);
            this.dtpDiaPartido.Name = "dtpDiaPartido";
            this.dtpDiaPartido.Size = new System.Drawing.Size(200, 20);
            this.dtpDiaPartido.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Día";
            // 
            // btnRegistrarAlineacion
            // 
            this.btnRegistrarAlineacion.Location = new System.Drawing.Point(980, 386);
            this.btnRegistrarAlineacion.Name = "btnRegistrarAlineacion";
            this.btnRegistrarAlineacion.Size = new System.Drawing.Size(127, 57);
            this.btnRegistrarAlineacion.TabIndex = 25;
            this.btnRegistrarAlineacion.Text = "REGISTRAR ALINEACION";
            this.btnRegistrarAlineacion.UseVisualStyleBackColor = true;
            this.btnRegistrarAlineacion.Click += new System.EventHandler(this.btnRegistrarAlineacion_Click);
            // 
            // lstHistoricoAlineaciones
            // 
            this.lstHistoricoAlineaciones.FormattingEnabled = true;
            this.lstHistoricoAlineaciones.Location = new System.Drawing.Point(107, 469);
            this.lstHistoricoAlineaciones.Name = "lstHistoricoAlineaciones";
            this.lstHistoricoAlineaciones.Size = new System.Drawing.Size(840, 147);
            this.lstHistoricoAlineaciones.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 649);
            this.Controls.Add(this.lstHistoricoAlineaciones);
            this.Controls.Add(this.btnRegistrarAlineacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDiaPartido);
            this.Controls.Add(this.btnInsertarJugador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultadoBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtElementoBusqueda);
            this.Controls.Add(this.btnPasarListaLeftRigth);
            this.Controls.Add(this.btnPasarListaRigthLeft);
            this.Controls.Add(this.btnEliminarElementoSuplentes);
            this.Controls.Add(this.btnVaciarListaSuplentes);
            this.Controls.Add(this.btnEliminarElementoTitulares);
            this.Controls.Add(this.btnVaciarListaTitulares);
            this.Controls.Add(this.btnRigth);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lstSuplentes);
            this.Controls.Add(this.lstTitulares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTitulares;
        private System.Windows.Forms.ListBox lstSuplentes;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRigth;
        private System.Windows.Forms.Button btnVaciarListaTitulares;
        private System.Windows.Forms.Button btnEliminarElementoTitulares;
        private System.Windows.Forms.Button btnVaciarListaSuplentes;
        private System.Windows.Forms.Button btnEliminarElementoSuplentes;
        private System.Windows.Forms.Button btnPasarListaRigthLeft;
        private System.Windows.Forms.Button btnPasarListaLeftRigth;
        private System.Windows.Forms.TextBox txtElementoBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultadoBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertarJugador;
        private System.Windows.Forms.DateTimePicker dtpDiaPartido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarAlineacion;
        private System.Windows.Forms.ListBox lstHistoricoAlineaciones;
    }
}

