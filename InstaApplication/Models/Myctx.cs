
using System.Collections.Generic;
using InstaApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InstaApplication.Models
{
    public class Myctx : DbContext
    {
        public Myctx(DbContextOptions<Myctx> options) : base(options)
        {

        }

        //Dbset

        public DbSet<Client> Clients { get; set; }

        public DbSet<Produits> Product { get; set; }
        public DbSet<InstaApplication.Models.Connexion> Connexion { get; set; } = default!;
        public DbSet<InstaApplication.Models.Inscription> Inscription { get; set; } = default!;




    }
}