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

public DbSet<DemoEstudiante.Models.Carrera> Carrera { get; set; } = default!;

public DbSet<DemoEstudiante.Models.Facultad> Facultad { get; set; } = default!;
    }
