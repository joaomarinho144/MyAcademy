using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models
{
    public class Treino : Entity
    {
        public Guid FichaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int TempoMedioDuracao { get; set; }
        public string Observacoes { get; set; }


        /* EF Relations */
        public Ficha Ficha { get; set; }

        public IEnumerable<Exercicio> Exercicios { get; set; }
    }
}
