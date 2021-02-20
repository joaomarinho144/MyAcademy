using System;
using System.Collections.Generic;
using System.Text;

namespace MyAcademy.Business.Models
{
    public class Exercicio : Entity
    {
        public Guid TreinoId { get; set; }
        public string Nome { get; set; }
        public string Series { get; set; }
        public string Repeticoes { get; set; }
        public string RPE { get; set; }
        public string Descanso { get; set; }
        public string Tecnica { get; set; }
        public string Observacoes { get; set; }

        /* EF Relations */
        public Treino Treino { get; set; }
    }
}
