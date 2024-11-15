using Galaxy.GestionGuarderia.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.AccesDatos.Configuraciones
{
    public class CuidadorConfiguratcion : IEntityTypeConfiguration<Cuidador>
    {
        public void Configure(EntityTypeBuilder<Cuidador> builder)
        {
            builder.Property(p => p.NroDocumento)
                .HasMaxLength(11);
            builder.HasIndex(p => p.NroDocumento);
            builder.HasQueryFilter(p => p.Estado);
        }
    }
}
