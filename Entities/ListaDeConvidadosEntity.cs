using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeConvidados.Entities
{
    public class ListaDeConvidadosEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Rg { get; set; }
        public bool Ativo { get; set; }
    }
}