
namespace Ejercicio2
{
    partial class fAlumnos
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
            this.bMostrarTodos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbContador = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bAnyadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelf = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMostrarTodos
            // 
            this.bMostrarTodos.Location = new System.Drawing.Point(537, 175);
            this.bMostrarTodos.Name = "bMostrarTodos";
            this.bMostrarTodos.Size = new System.Drawing.Size(226, 56);
            this.bMostrarTodos.TabIndex = 34;
            this.bMostrarTodos.Text = "Mostrar todos los Alumnos";
            this.bMostrarTodos.UseVisualStyleBackColor = true;
            this.bMostrarTodos.Click += new System.EventHandler(this.bMostrarTodos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bBuscar);
            this.groupBox4.Controls.Add(this.tbBuscar);
            this.groupBox4.Controls.Add(this.rbApellidos);
            this.groupBox4.Controls.Add(this.rbNombre);
            this.groupBox4.Controls.Add(this.rbDNI);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(37, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(726, 134);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(523, 45);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(157, 53);
            this.bBuscar.TabIndex = 5;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(289, 60);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(184, 22);
            this.tbBuscar.TabIndex = 4;
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Location = new System.Drawing.Point(124, 88);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(86, 21);
            this.rbApellidos.TabIndex = 3;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(124, 61);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(124, 32);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(52, 21);
            this.rbDNI.TabIndex = 1;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buscar por:";
            // 
            // lbContador
            // 
            this.lbContador.AutoSize = true;
            this.lbContador.Location = new System.Drawing.Point(269, 214);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(0, 17);
            this.lbContador.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bEliminar);
            this.groupBox3.Controls.Add(this.bActualizar);
            this.groupBox3.Location = new System.Drawing.Point(400, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 115);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar y Eliminar";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(190, 38);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(154, 54);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(30, 36);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(154, 55);
            this.bActualizar.TabIndex = 0;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bGuardar);
            this.groupBox2.Controls.Add(this.bAnyadir);
            this.groupBox2.Location = new System.Drawing.Point(37, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 115);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir Curso";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(182, 37);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(154, 54);
            this.bGuardar.TabIndex = 1;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bAnyadir
            // 
            this.bAnyadir.Location = new System.Drawing.Point(22, 37);
            this.bAnyadir.Name = "bAnyadir";
            this.bAnyadir.Size = new System.Drawing.Size(154, 55);
            this.bAnyadir.TabIndex = 0;
            this.bAnyadir.Text = "Añadir";
            this.bAnyadir.UseVisualStyleBackColor = true;
            this.bAnyadir.Click += new System.EventHandler(this.bAnyadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bUltimo);
            this.groupBox1.Controls.Add(this.bSiguiente);
            this.groupBox1.Controls.Add(this.bAnterior);
            this.groupBox1.Controls.Add(this.bPrimero);
            this.groupBox1.Location = new System.Drawing.Point(37, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 119);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegación";
            // 
            // bUltimo
            // 
            this.bUltimo.Location = new System.Drawing.Point(523, 36);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(154, 55);
            this.bUltimo.TabIndex = 7;
            this.bUltimo.Text = "Último";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Location = new System.Drawing.Point(363, 36);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(154, 55);
            this.bSiguiente.TabIndex = 8;
            this.bSiguiente.Text = "Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Location = new System.Drawing.Point(203, 36);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(154, 55);
            this.bAnterior.TabIndex = 9;
            this.bAnterior.Text = "Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Location = new System.Drawing.Point(43, 36);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(154, 55);
            this.bPrimero.TabIndex = 5;
            this.bPrimero.Text = "Primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(168, 87);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(189, 22);
            this.tbNombre.TabIndex = 28;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbTextoCambiado);
            // 
            // tbTelf
            // 
            this.tbTelf.Location = new System.Drawing.Point(168, 139);
            this.tbTelf.Name = "tbTelf";
            this.tbTelf.Size = new System.Drawing.Size(189, 22);
            this.tbTelf.TabIndex = 27;
            this.tbTelf.TextChanged += new System.EventHandler(this.tbTextoCambiado);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(537, 58);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(189, 22);
            this.tbApellidos.TabIndex = 26;
            this.tbApellidos.TextChanged += new System.EventHandler(this.tbTextoCambiado);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(537, 112);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(189, 22);
            this.tbEmail.TabIndex = 25;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbTextoCambiado);
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(168, 39);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(189, 22);
            this.tbDNI.TabIndex = 24;
            this.tbDNI.TextChanged += new System.EventHandler(this.tbTextoCambiado);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tlf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "DNI:";
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.bMostrarTodos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbContador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbTelf);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAlumnos";
            this.Text = "Gestión de Alumnos";
            this.Load += new System.EventHandler(this.fAlumnos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bMostrarTodos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.RadioButton rbApellidos;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbContador;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bAnyadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelf;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}