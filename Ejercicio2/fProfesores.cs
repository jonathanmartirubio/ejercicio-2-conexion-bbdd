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
    public partial class fProfesores : Form
    {
        public fProfesores(string cadConexion)
        {
            InitializeComponent();
            this.cadConexion = cadConexion;
        }

        DataSet dsProfesores;
        SqlDataAdapter dataAdapter;
        private string cadConexion;
        private int pos, maxRegistros;

        // ######################### FUNCIONES #################################
        private void MostrarRegistro(int pos)
        {
            DataRow drRegistro;

            drRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

            tbDNI.Text = drRegistro["DNI"].ToString();
            tbNombre.Text = drRegistro["Nombre"].ToString();
            tbTelf.Text = drRegistro["Tlf"].ToString();
            tbApellidos.Text = drRegistro["Apellido"].ToString();
            tbEmail.Text = drRegistro["email"].ToString();
            lbContador.Text = "Registro " + (pos + 1) + " de " + maxRegistros;
        }
        private void ControlarBotones(int pos)
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
            if (maxRegistros == 1 || maxRegistros == 0)
            {
                bBuscar.Enabled = false;
            }
            else
            {
                bBuscar.Enabled = true;
            }
            if (maxRegistros > 0)
            {
                bEliminar.Enabled = true;
                bMostrarTodos.Enabled = true;
            }
            else
            {
                bEliminar.Enabled = false;
                bMostrarTodos.Enabled = false;
            }
        }
        private string SinRegistros()
        {
            string texto;
            tbApellidos.Clear();
            tbNombre.Clear();
            tbDNI.Clear();
            tbEmail.Clear();
            tbTelf.Clear();
            lbContador.Text = "La tabla de profesores está vacía";
            bBuscar.Enabled = false;
            bEliminar.Enabled = false;
            bSiguiente.Enabled = false;
            bAnterior.Enabled = false;
            bPrimero.Enabled = false;
            bUltimo.Enabled = false;
            bMostrarTodos.Enabled = false; 
            bActualizar.Enabled = false;
            bGuardar.Enabled = false;

            texto = lbContador.Text;


            return texto;
        }
        private bool RegistroCambiado()
        {
            bool res;
            DataRow drRegistro = dsProfesores.Tables["Profesores"].Rows[pos];
            res = false;
            if (tbDNI.Text != (string)drRegistro["DNI"] || tbApellidos.Text != (string)drRegistro["Apellido"]
                || tbEmail.Text != (string)drRegistro["EMail"] || tbNombre.Text != (string)drRegistro["Nombre"] ||
                tbTelf.Text != (string)drRegistro["Tlf"])
            {
                res = true;
            }

            return res;
        }
        // ############################ NAVEGACIÓN #################################
        private void bPrimero_Click(object sender, EventArgs e)
        {
            bool regCambiado;
            DialogResult pregunta;

            regCambiado = RegistroCambiado();
            if (!regCambiado)
            {
                pos = 0;
                ControlarBotones(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarBotones(pos);
                }
                else
                {
                    pos = 0;
                    ControlarBotones(pos);
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
                ControlarBotones(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarBotones(pos);
                }
                else
                {
                    pos--;
                    ControlarBotones(pos);
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
                ControlarBotones(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarBotones(pos);
                }
                else
                {
                    pos++;
                    ControlarBotones(pos);
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
                ControlarBotones(pos);
                MostrarRegistro(pos);
            }
            else
            {
                pregunta = MessageBox.Show("¿El registro ha cambiado desea actualizarlo?", "Registro Cambiado", MessageBoxButtons.YesNo);
                if (pregunta == DialogResult.Yes)
                {
                    ControlarBotones(pos);
                }
                else
                {
                    pos = maxRegistros - 1;
                    ControlarBotones(pos);
                    MostrarRegistro(pos);
                }
            }
        }

        // ############################# AÑADIR Y GUARDAR ################################
        private void bAnyadir_Click(object sender, EventArgs e)
        {
            tbDNI.Clear();
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEmail.Clear();
            tbTelf.Clear();
            bActualizar.Enabled = false;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drRegistro = dsProfesores.Tables["Profesores"].NewRow();

                drRegistro["DNI"] = tbDNI.Text;
                drRegistro["Nombre"] = tbNombre.Text;
                drRegistro["Apellido"] = tbApellidos.Text;
                drRegistro["Tlf"] = tbTelf.Text;
                drRegistro["EMail"] = tbEmail.Text;

                dsProfesores.Tables["Profesores"].Rows.Add(drRegistro);
                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Update(dsProfesores, "Profesores");
                maxRegistros++;
                if (maxRegistros == 1)
                {
                    pos = 0;
                    ControlarBotones(pos);
                    MostrarRegistro(pos);
                }
                else
                {
                    pos = maxRegistros - 1;
                    ControlarBotones(pos);
                    MostrarRegistro(pos);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("El DNI introducido ya existe en la base de datos.");
            }
        }

        // ################################ ACTUALIZAR Y ELIMINAR ###############################
        private void bActualizar_Click(object sender, EventArgs e)
        {
            DataRow drRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

            drRegistro["DNI"] = tbDNI.Text;
            drRegistro["Nombre"] = tbNombre.Text;
            drRegistro["Apellido"] = tbApellidos.Text;
            drRegistro["Tlf"] = tbTelf.Text;
            drRegistro["EMail"] = tbEmail.Text;

            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dsProfesores, "Profesores");
            MessageBox.Show("Registro actualizado correctamente.");
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Eliminar;
            Eliminar = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);

            if (Eliminar == DialogResult.Yes)
            {
                dsProfesores.Tables["Profesores"].Rows[pos].Delete();

                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dsProfesores, "Profesores");
                maxRegistros--;
                if (maxRegistros == 0)
                {
                    SinRegistros();
                }
                else
                {
                    pos = 0;
                    MostrarRegistro(pos);
                    ControlarBotones(pos);
                    MessageBox.Show("Registro eliminado.");
                }
            }
        }

        // ############################### EVENTOS TEXTBOX ##################################
        private void tbTextoCambiado(object sender, EventArgs e)
        {
            if (maxRegistros != 0)
            {
                if (tbDNI.Text == "" || tbNombre.Text == "" || tbApellidos.Text == "" || tbEmail.Text == "" || tbTelf.Text == "")
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
                    if (tbDNI.Text != "" && tbNombre.Text != "" && tbApellidos.Text != "" && tbEmail.Text != "" && tbTelf.Text != "")
                    {
                        bActualizar.Enabled = true;
                    }
                }
            }
            else
            {
                if (tbDNI.Text != "" && tbNombre.Text != "" && tbApellidos.Text != "" && tbEmail.Text != "" && tbTelf.Text != "")
                {
                    bGuardar.Enabled = true;
                }
            }
        }

        // ##################################### MOSTRAR TODOS LOS PROFESORES #####################################
        private void bMostrarTodos_Click(object sender, EventArgs e)
        {
            string texto = "Lista de profesores: \n";
            string sentenciaSQL = "select nombre, apellido from profesores";
            SqlConnection connect = new SqlConnection(cadConexion);
            connect.Open();
            SqlCommand mostrar = new SqlCommand(sentenciaSQL, connect);
            SqlDataReader reader = mostrar.ExecuteReader();

            while (reader.Read())
            {
                texto += reader[0].ToString() + " " + reader[1].ToString() + "\n";
            }

            MessageBox.Show(texto, "Mostrar todos los profesores");

            connect.Close();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string datosBusqueda, busquedaSQL;

            datosBusqueda = tbBuscar.Text;
            busquedaSQL = "";

            if (!rbNombre.Checked && !rbApellidos.Checked && !rbDNI.Checked)
                MessageBox.Show("Seleccione el parámetro por el que quiere realizar la búsqueda.");
            else
            {
                if (datosBusqueda == "")
                    MessageBox.Show("Introduzca los criterios de búsqueda.");
                else
                {
                    if (rbDNI.Checked)
                        busquedaSQL = "SELECT * FROM Profesores WHERE DNI = " + datosBusqueda;
                    if (rbApellidos.Checked)
                        busquedaSQL = "SELECT * FROM Profesores WHERE Apellido LIKE '%" + datosBusqueda + "%'";
                    if (rbNombre.Checked)
                        busquedaSQL = "SELECT * FROM Profesores WHERE Nombre LIKE '%" + datosBusqueda + "%'";
                    fBusqueda fBus = new fBusqueda(busquedaSQL, cadConexion);
                    fBus.ShowDialog();
                }

            }
        }

        // ############################# CARGAR FORMULARIO ###############################
        private void fProfesores_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(cadConexion);

            connect.Open();
            string cadenaSQL = "SELECT * FROM Profesores";
            dataAdapter = new SqlDataAdapter(cadenaSQL, connect);
            dsProfesores = new DataSet();
            dataAdapter.Fill(dsProfesores, "Profesores");
            pos = 0;
            maxRegistros = dsProfesores.Tables["Profesores"].Rows.Count;
            if (maxRegistros == 0)
            {
                SinRegistros();
            }
            else
            {
                MostrarRegistro(pos);
                ControlarBotones(pos);
            }
            connect.Close();
        }
    }
}
