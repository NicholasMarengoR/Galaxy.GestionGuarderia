using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.Entidades
{
    public class Cliente : EntidadBase
    {
        public string Nombre1 { get; set; } = default!;

        public string? Nombre2 { get; set; }

        public string Apellido1 { get; set; } = default!;

        public string Apellido2 { get; set; } = default!;

        public string Correo { get; set; } = default!;

        public string? Celular { get; set; }

        public string Departamento { get; set; } = default!;

        public string? Provincia { get; set; }

        public string? Distrito { get; set; }

        public string Nacionalidad { get; set; } = default!;

        public DateTime FechaNacimiento { get; set; } = default!;

        public DateTime FechaInscripcion { get; set; }

        // Propiedad de navegacion
        public ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
    }
}
