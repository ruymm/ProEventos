using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proeventos1.API.Models;

namespace Proeventos1.API.Data
{
  
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){}
        
       public DbSet<Evento> Eventos { get; set; }
    }
}