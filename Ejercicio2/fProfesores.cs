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

        private string cadConexion;
    }
}
