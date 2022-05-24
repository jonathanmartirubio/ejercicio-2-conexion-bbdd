
namespace Ejercicio2
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
            this.bGestionAlumnos = new System.Windows.Forms.Button();
            this.bGestionCursos = new System.Windows.Forms.Button();
            this.bGestionProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Location = new System.Drawing.Point(95, 68);
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(199, 61);
            this.bGestionAlumnos.TabIndex = 0;
            this.bGestionAlumnos.Text = "Gestión Alumnos";
            this.bGestionAlumnos.UseVisualStyleBackColor = true;
            this.bGestionAlumnos.Click += new System.EventHandler(this.bGestionAlumnos_Click);
            // 
            // bGestionCursos
            // 
            this.bGestionCursos.Location = new System.Drawing.Point(95, 189);
            this.bGestionCursos.Name = "bGestionCursos";
            this.bGestionCursos.Size = new System.Drawing.Size(199, 61);
            this.bGestionCursos.TabIndex = 1;
            this.bGestionCursos.Text = "Gestión Cursos";
            this.bGestionCursos.UseVisualStyleBackColor = true;
            this.bGestionCursos.Click += new System.EventHandler(this.bGestionCursos_Click);
            // 
            // bGestionProfesores
            // 
            this.bGestionProfesores.Location = new System.Drawing.Point(95, 311);
            this.bGestionProfesores.Name = "bGestionProfesores";
            this.bGestionProfesores.Size = new System.Drawing.Size(199, 61);
            this.bGestionProfesores.TabIndex = 2;
            this.bGestionProfesores.Text = "Gestión Profesores";
            this.bGestionProfesores.UseVisualStyleBackColor = true;
            this.bGestionProfesores.Click += new System.EventHandler(this.bGestionProfesores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.bGestionProfesores);
            this.Controls.Add(this.bGestionCursos);
            this.Controls.Add(this.bGestionAlumnos);
            this.Name = "Form1";
            this.Text = "Gestión Instituto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGestionAlumnos;
        private System.Windows.Forms.Button bGestionCursos;
        private System.Windows.Forms.Button bGestionProfesores;
    }
}

