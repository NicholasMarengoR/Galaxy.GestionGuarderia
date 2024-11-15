using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.Entidades
{
    public class Cuidador : EntidadBase
    {
        public string Nombres { get; set; } = default!;

        public string NroDocumento { get; set; } = default!;

        public Categoria Categoria { get; set; } = default!;
        public int CategoriaId { get; set; }
    }
}
