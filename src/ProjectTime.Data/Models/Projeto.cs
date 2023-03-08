using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTime.Data.Models
{
    public class Projeto : Entity
    {
        public string nomeProjeto {get;set;}
        public string descricao {get;set;}
        public bool ativo {get;set;}
        public DateTime dataCriacao {get;set;}
        public DateTime dataModificacao {get;set;}
    }
}