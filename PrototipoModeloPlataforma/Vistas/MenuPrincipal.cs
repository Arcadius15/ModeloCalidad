using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoModeloPlataforma.Vistas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void asistencias_Click(object sender, EventArgs e)
        {
            Asistencias a = new Asistencias();
            a.ShowDialog();
        }

        private void grupo_Click(object sender, EventArgs e)
        {
            Grupos g = new Grupos();
            g.ShowDialog();
        }
    }
}
