using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sutea_Paul_Vasile_Lab6.Models;

namespace Sutea_Paul_Vasile_Lab6.Data
{
    public class Sutea_Paul_Vasile_Lab6Context : DbContext
    {
        public Sutea_Paul_Vasile_Lab6Context (DbContextOptions<Sutea_Paul_Vasile_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Sutea_Paul_Vasile_Lab6.Models.Book> Book { get; set; }
    }
}
