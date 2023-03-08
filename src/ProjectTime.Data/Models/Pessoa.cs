using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTime.Data.Models
{
    public class Pessoa : Entity
    {
        public string nome {get;set;}
        public DateTime dataCriacao {get;set;}
        public DateTime dataModificacao {get;set;}
    }
}