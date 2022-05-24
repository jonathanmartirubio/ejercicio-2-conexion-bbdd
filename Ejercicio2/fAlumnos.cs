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
    public partial class fAlumnos : Form
    {
        public fAlumnos(string cadConexion, DataSet dsAlumnos)
        {
            InitializeComponent();
            this.cadConexion = cadConexion;
            this.dsAlumnos = dsAlumnos;
        }

        private DataSet dsAlumnos;
        private string cadConexion;
    }
}
