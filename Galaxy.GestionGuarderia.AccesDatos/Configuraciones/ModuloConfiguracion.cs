using Galaxy.GestionGuarderia.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.AccesDatos.Configuraciones
{
    public class ModuloConfiguracion : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Modulo> builder)
        {
            builder.Property(p => p.PortadaURL)
                .IsUnicode(false);

            builder.Property(p => p.TemarioURL)
                .IsUnicode(false);

            builder.Property(p => p.FechaInicio)
                .HasColumnType("DATE");

            builder.Property(p => p.HoraInicio)
                .HasColumnType("DATETIME");

            builder.Property(p => p.Descripcion)
                .HasMaxLength(700);

            builder.HasQueryFilter(p => p.Estado);
        }
    }
}
