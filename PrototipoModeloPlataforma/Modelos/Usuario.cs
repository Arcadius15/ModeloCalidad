using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoModeloPlataforma.Modelos
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(15)]
        public string usuario { get; set; }
        [Required]
        [MaxLength(15)]
        public string contraseña { get; set; }
        [MaxLength(12)]
        public string nombre { get; set; }
        [MaxLength(30)]
        public string apellido { get; set; }
        public int edad { get; set; }
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string dni { get; set; }
        public DateTime nacimiento { get; set; }
        [Required]
        public int tipo { get; set; }
    }
}
