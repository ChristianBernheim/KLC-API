using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace KLC_API.Models
{
    public class MatningContext :DbContext
    {
        
            public DbSet<MatningNews2> MatningarNews2 { get; set; }
            public DbSet<Patient> Patienter { get; set; }
            
            //SQL server
            public MatningContext(DbContextOptions options) : base(options)
            {}

        }
    }
