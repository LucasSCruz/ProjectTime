using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTime.Data.Models
{
    public class Tarefa : Entity
    {
        public string nomeTarefa {get;set;}
        public string descricaoTarefa {get;set;}
        public bool ativo {get;set;}
        public DateTime dataCriacao {get;set;}
        public DateTime dataModificacao {get;set;}
        public DateTime dataTermino {get;set;}
    }
}