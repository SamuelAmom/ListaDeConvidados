using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListaDeConvidados.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListaDeConvidados.Context
{
    public class ListaDeConvidadosContext : DbContext
    {
        public ListaDeConvidadosContext(DbContextOptions<ListaDeConvidadosContext>options): base(options){

        }
        public DbSet<ListaDeConvidadosEntity>ListaDeConvidados{ get; set; }
    }
}