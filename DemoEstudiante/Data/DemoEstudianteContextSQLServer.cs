using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoEstudiante.Models;

    public class DemoEstudianteContextSQLServer : DbContext
    {
        public DemoEstudianteContextSQLServer (DbContextOptions<DemoEstudianteContextSQLServer> options)
            : base(options)
        {
        }

        public DbSet<DemoEstudiante.Models.Estudiante> Estudiante { get; set; } = default!;
    }
