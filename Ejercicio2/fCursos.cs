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
        public fCursos(string cadConexion, DataSet dsCursos)
        {
            InitializeComponent();
            this.cadConexion = cadConexion;
            this.dsCursos = dsCursos;
        }

        private DataSet dsCursos;
        private SqlDataAdapter dataAdapter;
        private string cadConexion;

        private void fCursos_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(cadConexion);

            connect.Open();
            string cadenaSQL = "SELECT * FROM Cursos";
            dataAdapter = new SqlDataAdapter(cadenaSQL, connect);
            dataAdapter.Fill(dsCursos, "Cursos");
            connect.Close();
        }
    }
}
