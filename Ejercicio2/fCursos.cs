using System;
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
    public partial class fCursos : Form
    {
        public fCursos(string cadConexion)
        {
            InitializeComponent();
            this.cadConexion = cadConexion;
        }

        DataSet dsCursos;
        SqlDataAdapter dataAdapter;
        private string cadConexion;
        private int pos, maxRegistros;

        private void MostrarRegistro(int pos)
        {
            DataRow drRegistro;

            drRegistro = dsCursos.Tables["Cursos"].Rows[pos];

            tbCodigo.Text = drRegistro[0].ToString();
            tbNombre.Text = drRegistro[1].ToString();
            lbContador.Text = "Curso " + (pos + 1) + " de " + maxRegistros;
        }

        private void ControlarNavegacion(int pos)
        {
            if (pos == 0 || pos < 0)
            {
                bAnterior.Enabled = false;
                bPrimero.Enabled = false;
            }
            else
            {
                bAnterior.Enabled = true;
                bPrimero.Enabled = true;
            }
            if ((pos + 1) == maxRegistros)
            {
                bSiguiente.Enabled = false;
                bUltimo.Enabled = false;
            }
            else
            {
                bSiguiente.Enabled = true;
                bUltimo.Enabled = true;
            }
        }
        // ######################  BOTONES NAVEGACION ################################
        private void bPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            ControlarNavegacion(pos);
            MostrarRegistro(pos);
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            pos--;
            ControlarNavegacion(pos);
            MostrarRegistro(pos);
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            pos++;
            ControlarNavegacion(pos);
            MostrarRegistro(pos);
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            pos = maxRegistros - 1;
            ControlarNavegacion(pos);
            MostrarRegistro(pos);
        }
        // ######################### BOTONES AÑADIR #########################################
        private void bAnyadir_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbNombre.Clear();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drRegistro = dsCursos.Tables["Cursos"].NewRow();

                drRegistro[0] = tbCodigo.Text;
                drRegistro[1] = tbNombre.Text;


                dsCursos.Tables["Cursos"].Rows.Add(drRegistro);
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Update(dsCursos, "Cursos");
                maxRegistros++;
                pos = maxRegistros - 1;
                ControlarNavegacion(pos);
                MostrarRegistro(pos);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("El Código de curso introducido ya existe en la base de datos.");
            }
        }
        // ######################### CARGAR FORMULARIO ######################################
        private void fCursos_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(cadConexion);

            connect.Open();
            string cadenaSQL = "SELECT * FROM Cursos";
            dataAdapter = new SqlDataAdapter(cadenaSQL, connect);
            dsCursos = new DataSet();
            dataAdapter.Fill(dsCursos, "Cursos");
            pos = 0;
            maxRegistros = dsCursos.Tables["Cursos"].Rows.Count;
            MostrarRegistro(pos);
            ControlarNavegacion(pos);
            connect.Close();
        }
    }
}
