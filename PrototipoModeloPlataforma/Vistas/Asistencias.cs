using PrototipoModeloPlataforma.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoModeloPlataforma.Vistas
{
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private readonly Contexto _context = new Contexto();

        private void Asistencias_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("Es-Es");
            string diaactual = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            List<Curso> cursos = _context.Cursos.ToList();
            switch (diaactual)
            {
                case "lunes":
                    lunes.BackColor = Color.Red;
                    break;
                case "martes":
                    martes.BackColor = Color.Red;
                    break;
                case "miercoles":
                    miercoles.BackColor = Color.Red;
                    break;
                case "jueves":
                    jueves.BackColor = Color.Red;
                    break;
                case "viernes":
                    viernes.BackColor = Color.Red;
                    break;
                case "sabado":
                    sabado.BackColor = Color.Red;
                    break;
                case "domingo":
                    domingo.BackColor = Color.Red;
                    break;
            }

            
            foreach (var item in cursos)
            {
                string dia = ci.DateTimeFormat.GetDayName(item.horario.DayOfWeek);
                if (dia == ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek))
                {
                    cmbcurso.Items.Add(item.nombre);
                }
                switch (dia)
                {
                    case "lunes":
                        lunes.Items.Add(item.nombre);
                        break;
                    case "martes":
                        martes.Items.Add(item.nombre);
                        break;
                    case "miercoles":
                        miercoles.Items.Add(item.nombre);
                        break;
                    case "jueves":
                        jueves.Items.Add(item.nombre);
                        break;
                    case "viernes":
                        viernes.Items.Add(item.nombre);
                        break;
                    case "sabado":
                        sabado.Items.Add(item.nombre);
                        break;
                    case "domingo":
                        domingo.Items.Add(item.nombre);
                        break;
                }

            }
            if (cmbcurso.Items.Count>0)
            {
                cmbcurso.SelectedIndex = 0;
            }
            


        }

        private void marcar_Click(object sender, EventArgs e)
        {
            if (cmbcurso.Items.Count > 0)
            {
                MessageBox.Show("Asistencia marcada para curso: "+ cmbcurso.Text,"IDAT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
