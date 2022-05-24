﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataSet dsProfesores, dsAlumnos, dsCursos;
        private string cadConexion;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cadConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\FA506IV\\source\\repos\\jonathanmartirubio\\ejercicio-2-conexion-bbdd\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            dsProfesores = new DataSet();
            dsAlumnos = new DataSet();
            dsCursos = new DataSet();
        }

        private void bGestionAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlu = new fAlumnos(cadConexion, dsAlumnos);
            fAlu.ShowDialog();
        }

        private void bGestionCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(cadConexion, dsCursos);
            fCur.ShowDialog();
        }

        private void bGestionProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProf = new fProfesores(cadConexion, dsProfesores);
            fProf.ShowDialog();
        }
    }
}
