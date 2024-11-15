using Galaxy.GestionGuarderia.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.AccesDatos.Configuraciones
{
    public class CategoriaConfiguracion : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(new List<Categoria>
            {
                new() {Id=1, Nombre= "Sala menos de 1 año"},
                new() {Id=2, Nombre= "Sala 1 a 2 años"},
                new() {Id=3, Nombre= "Sala 2 a 3 años"},
                new() {Id=4, Nombre= "Sala jardin"},
                new() {Id=5, Nombre= "Sala multiuso"},
                new() {Id=6, Nombre= "Comedor"},
                new() {Id=7, Nombre= "Sala descanso"},
                new() {Id=8, Nombre= "Sala de espera"},
                new() {Id=9, Nombre= "Administracion"}
            });

            builder.HasQueryFilter(p => p.Estado);
        }
    }
}
