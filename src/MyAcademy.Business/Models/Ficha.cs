using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models
{
    public class Ficha : Entity
    {
        public string Nome { get; set; }
        public string Observacoes { get; set; }


        /* EF Relations */
        public IEnumerable<Treino> Treinos { get; set; }
    }
}
