using PrototipoModeloPlataforma.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoModeloPlataforma.Controlador
{
    public class Conexion
    {
        public async Task Create()
        {
            using (var db = new Contexto())
            {
                await db.Database.EnsureDeletedAsync();
                await db.Database.EnsureCreatedAsync();
            }
        }

    }
}
