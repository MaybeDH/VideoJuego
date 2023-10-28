using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Universidad> Universidad { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Materia> Materia { get; set; }

    }
}

