using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial2.DAL
{
    public class Contexto : DbContext
    {
        public Dbset<> {get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server = (local); Database = Prestamos; Trusted_Connection = True;");
    }


}

