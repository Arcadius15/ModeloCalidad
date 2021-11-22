using PrototipoModeloPlataforma.Controlador;
using PrototipoModeloPlataforma.Modelos;
using PrototipoModeloPlataforma.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoModeloPlataforma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly Contexto _context = new Contexto();

        private async void Form1_Load(object sender, EventArgs e)
        {
            var cn = new Conexion();
            await cn.Create();
        }

        private void acceder_Click(object sender, EventArgs e)
        {
            Usuario user = _context.Usuarios.Where(x=>x.usuario == usuario.Text && x.contraseña == contraseña.Text).FirstOrDefault();
            if (user != null)
            {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            _context.Usuarios.Add(new Usuario()
            {
                usuario = "jarias",
                contraseña = "jarias",
                nombre = "johnny",
                apellido = "arias",
                dni = "12345678",
                edad = 22,
                nacimiento = new DateTime(1999,12,15),
                tipo = 2
            });
            _context.Usuarios.Add(new Usuario()
            {
                usuario = "dvicente",
                contraseña = "dvicente",
                nombre = "diego",
                apellido = "vicente",
                dni = "12345678",
                edad = 22,
                nacimiento = new DateTime(1999, 12, 15),
                tipo = 2
            });
            _context.Usuarios.Add(new Usuario()
            {
                usuario = "asotil",
                contraseña = "asotil",
                nombre = "andra",
                apellido = "sotil",
                dni = "12345678",
                edad = 22,
                nacimiento = new DateTime(1999, 12, 15),
                tipo = 2
            });
            _context.Usuarios.Add(new Usuario()
            {
                usuario = "dtamara",
                contraseña = "dtamara",
                nombre = "dany",
                apellido = "tamara",
                dni = "12345678",
                edad = 22,
                nacimiento = new DateTime(1999, 12, 15),
                tipo = 2
            });

            _context.Cursos.Add(new Curso()
            {
                nombre = "Aplicaciones Moviles",
                carrera = "DSI",
                creditos = 5,
                horario = new DateTime(2021, 11, 21, 12, 12, 12)
            }) ;
            _context.Aulas.Add(new Aula()
            {
                aforo = 30
            });

            _context.Cursos.Add(new Curso()
            { nombre = "Desarrollo de Servicios Web", carrera = "DSI", creditos = 7, horario = new DateTime(2021, 11, 22, 15, 20, 0) }
            );
            _context.Cursos.Add(new Curso()
            { nombre = "Modelos de calidad de Software", carrera = "DSI", creditos = 8, horario = new DateTime(2021, 11, 23, 15, 20, 0) }
            );
            _context.Cursos.Add(new Curso()
            { nombre = "Ing. de Procesos", carrera = "DSI", creditos = 5, horario = new DateTime(2021, 12, 24,12, 20, 0) }
            );
            _context.SaveChanges();
        }
    }
}
