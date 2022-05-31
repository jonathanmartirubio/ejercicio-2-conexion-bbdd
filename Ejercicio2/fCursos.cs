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

        private string SinRegistros()
        {
            string texto;
            tbCodigo.Clear();
            tbNombre.Clear();
            lbContador.Text = "";
            bEliminar.Enabled = false;
            bSiguiente.Enabled = false;
            bAnterior.Enabled = false;
            bPrimero.Enabled = false;
            bUltimo.Enabled = false;
            bActualizar.Enabled = false;
            lbContador.Text = "No hay cursos.";

            texto = lbContador.Text;

            return texto;
        }
        private bool RegistroCambiado()
        {
            bool res;
            DataRow drRegistro = dsCursos.Tables["Cursos"].Rows[pos];
            res = false;
            if (tbCodigo.Text != (string)drRegistro[0] || tbNombre.Text != (string)drRegistro[1])
            {
                res = true;
            }
            return res;
        }
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
            bool regCambiado;
            DialogResult pregunta;

            regCambiado = RegistroCambiado();
            if (!regCambiado)
            {
                pos = 0;
                ControlarNavegacion(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarNavegacion(pos);
                }
                else
                {
                    pos = 0;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                }
            }
        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            bool regCambiado;
            DialogResult pregunta;

            regCambiado = RegistroCambiado();
            if (!regCambiado)
            {
                pos--;
                ControlarNavegacion(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarNavegacion(pos);
                }
                else
                {
                    pos--;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                }
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            bool regCambiado;
            DialogResult pregunta;

            regCambiado = RegistroCambiado();
            if (!regCambiado)
            {
                pos++;
                ControlarNavegacion(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarNavegacion(pos);
                }
                else
                {
                    pos++;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                }
            }

        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            bool regCambiado;
            DialogResult pregunta;

            regCambiado = RegistroCambiado();
            if (!regCambiado)
            {
                pos = maxRegistros - 1;
                ControlarNavegacion(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarNavegacion(pos);
                }
                else
                {
                    pos = maxRegistros - 1;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                }
            }
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

                if (maxRegistros == 1)
                {
                    maxRegistros++;
                    pos = 0;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                    RellenarComboBox();
                    bEliminar.Enabled = true;
                }
                else
                {
                    maxRegistros++;
                    pos = maxRegistros - 1;
                    ControlarNavegacion(pos);
                    MostrarRegistro(pos);
                    RellenarComboBox();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("El Código de curso introducido ya existe en la base de datos.");
            }
        }
        // ############################## ACTUALIZAR Y ELIMINAR ####################################
        private void bActualizar_Click(object sender, EventArgs e)
        {
            DataRow drRegistro = dsCursos.Tables["Cursos"].Rows[pos];

            drRegistro[0] = tbCodigo.Text;
            drRegistro[1] = tbNombre.Text;

            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dsCursos, "Cursos");
            MessageBox.Show("Registro actualizado correctamente.");
            RellenarComboBox();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Eliminar;
            Eliminar = MessageBox.Show("¿Desea eliminar el curso?", "Eliminar", MessageBoxButtons.YesNo);

            if (Eliminar == DialogResult.Yes)
            {
                dsCursos.Tables["Cursos"].Rows[pos].Delete();

                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dsCursos, "Cursos");
                maxRegistros--;
                if (maxRegistros == 0)
                {
                    SinRegistros();
                    RellenarComboBox();
                }
                else
                {
                    pos = 0;
                    MostrarRegistro(pos);
                    RellenarComboBox();
                    if (maxRegistros == 1)
                    {
                        ControlarNavegacion(pos);
                    }
                    MessageBox.Show("Curso eliminado.");
                }
            }
        }
        private void RellenarComboBox()
        {
            if (maxRegistros > 0)
            {
                cbMostrarTodos.Items.Clear();
            }
            string sentenciaSQL;
            sentenciaSQL = "select nombre from cursos";
            SqlConnection connect = new SqlConnection(cadConexion);
            connect.Open();

            SqlCommand _comando = new SqlCommand(sentenciaSQL, connect);
            SqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                cbMostrarTodos.Items.Add(_reader.GetString(0));
                cbMostrarTodos.SelectedIndex = 0;
            }

            if (maxRegistros == 0)
            {
                cbMostrarTodos.Text = "No hay Cursos";
            }
            connect.Close();
        }
        //#################### EVENTOS TEXTBUTTON Y COMBOBOX ###############################
        private void tbTextoCambiado(object sender, EventArgs e)
        {
            if (dsCursos.Tables["Cursos"].Rows.Count != 0)
            {
                if (tbCodigo.Text == "" || tbNombre.Text == "")
                {
                    bGuardar.Enabled = false;
                    bActualizar.Enabled = false;
                }
                else
                {
                    bGuardar.Enabled = true;
                }
                if (!RegistroCambiado())
                {
                    bActualizar.Enabled = false;
                    bGuardar.Enabled = false;
                }
                else
                {
                    if (tbCodigo.Text != "" && tbNombre.Text != "")
                    {
                        bActualizar.Enabled = true;
                    }  
                }
            }
            else
            {
                if (tbCodigo.Text != "" && tbNombre.Text != "")
                {
                    bGuardar.Enabled = true;
                }
            }
        }
        private void cbOpcionEscogida(object sender, EventArgs e)
        {
            string consulta, texto;
            DataRow drRegistros;

            texto = "Alumnos pertenecientes a este curso: \n";
            drRegistros = dsCursos.Tables["cursos"].Rows[cbMostrarTodos.SelectedIndex];

            consulta = "select nombre, apellido from alumnos where CodCurso='" + (string)drRegistros[0]+"'";
            SqlConnection connect = new SqlConnection(cadConexion);
            connect.Open();
            SqlCommand _comando = new SqlCommand(consulta, connect);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                texto += _reader.GetString(0) + " " + _reader.GetString(1) + "\n";
            }
            MessageBox.Show(texto, "Listado");
            connect.Close();
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
            if (dsCursos.Tables["Cursos"].Rows.Count == 0)
            {
                SinRegistros();
                RellenarComboBox();
            }
            else
            {
                MostrarRegistro(pos);
                ControlarNavegacion(pos);
                RellenarComboBox();
            }
            connect.Close();
        }
    }
}
