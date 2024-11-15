using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.Entidades
{
    public class Modulo : EntidadBase
    {
        public string Nombre { get; set; } = default!;

        public Categoria Categoria { get; set; } = default!;
        public int CategoriaId { get; set; }

        public Cuidador Cuidador { get; set; } = default!;
        public int CuidadorId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime HoraInicio { get; set; }

        public string? PortadaURL { get; set; }

        public string? TemarioURL { get; set; }

        public string Descripcion { get; set; } = default!;

        public SituacionModulo Situacion { get; set; }

        // Propiedad de navegacion
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
    }
}
