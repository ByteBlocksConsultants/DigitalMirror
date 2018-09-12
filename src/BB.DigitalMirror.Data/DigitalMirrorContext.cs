using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
 
using System.Text;

namespace BB.DigitalMirror.Data
{
    public class DigitalMirrorContext : DbContext
    {
        public DigitalMirrorContext(DbContextOptions<DigitalMirrorContext> options) : base(options)
        {              
        }

        public DbSet<Contract> Contracts { get; set; }
    }
}
