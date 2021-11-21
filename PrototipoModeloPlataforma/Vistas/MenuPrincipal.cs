using PrototipoModeloPlataforma.Modelos;
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

        private readonly Contexto _context = new Contexto();

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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cursos.Columns.Add("Cursos","Cursos");
            foreach (var item in _context.Cursos.Select(x => x.nombre).ToList())
            {

                cursos.Rows.Add(item);
            }
            cursos.AutoResizeColumns();

            
            foreach (var item in _context.Usuarios.Select(x => x.nombre + " " + x.apellido).ToList())
            {

                amigos.Items.Add(item);
            }

        }

        private void SAEbtn_Click(object sender, EventArgs e)
        {
            SAE sae = new SAE();
            sae.ShowDialog();
        }
    }
}
