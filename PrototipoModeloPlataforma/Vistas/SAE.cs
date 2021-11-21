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
    public partial class SAE : Form
    {
        public SAE()
        {
            InitializeComponent();
        }

        private readonly Contexto _context = new Contexto();

        private void SAE_Load(object sender, EventArgs e)
        {
            List<string> problemas = new List<string>();
            problemas.Add("Con el sistema");
            problemas.Add("Con algun Profesor");
            problemas.Add("Algun Bug");
            problemas.Add("Informacion errada");
            problemas.Add("Nota erronea");
            comboProblemas.DataSource = problemas;

        }

        private void report_Click(object sender, EventArgs e)
        {
            _context.Tickets.Add(new Ticket()
            {
                tipo = comboProblemas.SelectedItem.ToString(),
                descripcion = informacion.Text,
                idregistro = 1
            });
            _context.SaveChanges();
            int exito = _context.Tickets.OrderBy(x => x.id).LastOrDefault().id;
            MessageBox.Show("Problema registrado exitosamente con id: " + exito, "IDAT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
