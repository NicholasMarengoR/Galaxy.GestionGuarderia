using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.Entidades
{
    public class Inscripcion : EntidadBase
    {
        public Cliente Cliente { get; set; } = default!;
        public int ClienteID { get; set; }

        public Modulo Modulo { get; set; } = default!;

        public int ModuloId { get; set; }

        public SituacionInscripcion Situacion { get; set; }

        
    }
}
