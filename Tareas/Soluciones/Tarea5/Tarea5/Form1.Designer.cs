namespace DI_Tarea_5_NicolasEstevezPazos
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
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.btnEditarPelicula = new System.Windows.Forms.Button();
            this.btnMostrarPelicula = new System.Windows.Forms.Button();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCodigoVideoClub = new System.Windows.Forms.ToolStripTextBox();
            this.listViewPeliculasVideoClub = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha_Devolucion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Location = new System.Drawing.Point(685, 27);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(80, 48);
            this.btnNuevaPelicula.TabIndex = 0;
            this.btnNuevaPelicula.Text = "Nueva película";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevaPelicula_Click);
            // 
            // btnEditarPelicula
            // 
            this.btnEditarPelicula.Location = new System.Drawing.Point(685, 81);
            this.btnEditarPelicula.Name = "btnEditarPelicula";
            this.btnEditarPelicula.Size = new System.Drawing.Size(80, 48);
            this.btnEditarPelicula.TabIndex = 0;
            this.btnEditarPelicula.Text = "Editar película";
            this.btnEditarPelicula.UseVisualStyleBackColor = true;
            this.btnEditarPelicula.Click += new System.EventHandler(this.btnEditarPelicula_Click);
            // 
            // btnMostrarPelicula
            // 
            this.btnMostrarPelicula.Location = new System.Drawing.Point(685, 135);
            this.btnMostrarPelicula.Name = "btnMostrarPelicula";
            this.btnMostrarPelicula.Size = new System.Drawing.Size(80, 48);
            this.btnMostrarPelicula.TabIndex = 0;
            this.btnMostrarPelicula.Text = "Mostrar película";
            this.btnMostrarPelicula.UseVisualStyleBackColor = true;
            this.btnMostrarPelicula.Click += new System.EventHandler(this.btnMostrarPelicula_Click);
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(685, 189);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(80, 48);
            this.btnMostrarTodas.TabIndex = 0;
            this.btnMostrarTodas.Text = "Mostrar todas las peliculas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoClubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoClubToolStripMenuItem
            // 
            this.videoClubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCodigoVideoClub});
            this.videoClubToolStripMenuItem.Name = "videoClubToolStripMenuItem";
            this.videoClubToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.videoClubToolStripMenuItem.Text = "VideoClub";
            // 
            // selectCodigoVideoClub
            // 
            this.selectCodigoVideoClub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectCodigoVideoClub.Name = "selectCodigoVideoClub";
            this.selectCodigoVideoClub.Size = new System.Drawing.Size(192, 23);
            this.selectCodigoVideoClub.Paint += new System.Windows.Forms.PaintEventHandler(this.selectCodigoVideoClub_Paint);
            // 
            // listViewPeliculasVideoClub
            // 
            this.listViewPeliculasVideoClub.AllowColumnReorder = true;
            this.listViewPeliculasVideoClub.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Codigo,
            this.Director,
            this.Actor,
            this.Estado,
            this.Fecha_Devolucion});
            this.listViewPeliculasVideoClub.FullRowSelect = true;
            this.listViewPeliculasVideoClub.GridLines = true;
            this.listViewPeliculasVideoClub.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPeliculasVideoClub.HideSelection = false;
            this.listViewPeliculasVideoClub.LabelEdit = true;
            this.listViewPeliculasVideoClub.Location = new System.Drawing.Point(12, 27);
            this.listViewPeliculasVideoClub.Name = "listViewPeliculasVideoClub";
            this.listViewPeliculasVideoClub.Size = new System.Drawing.Size(667, 406);
            this.listViewPeliculasVideoClub.TabIndex = 3;
            this.listViewPeliculasVideoClub.UseCompatibleStateImageBehavior = false;
            this.listViewPeliculasVideoClub.View = System.Windows.Forms.View.Details;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.Width = 140;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 68;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 105;
            // 
            // Actor
            // 
            this.Actor.Text = "Actor";
            this.Actor.Width = 160;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 70;
            // 
            // Fecha_Devolucion
            // 
            this.Fecha_Devolucion.Text = "Fecha_Devolucion";
            this.Fecha_Devolucion.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 445);
            this.Controls.Add(this.listViewPeliculasVideoClub);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.btnMostrarPelicula);
            this.Controls.Add(this.btnEditarPelicula);
            this.Controls.Add(this.btnNuevaPelicula);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VIDEOCLUB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaPelicula;
        private System.Windows.Forms.Button btnEditarPelicula;
        private System.Windows.Forms.Button btnMostrarPelicula;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem videoClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox selectCodigoVideoClub;
        private System.Windows.Forms.ListView listViewPeliculasVideoClub;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Actor;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Fecha_Devolucion;
    }
}

