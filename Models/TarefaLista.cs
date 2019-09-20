using System;

namespace api.Models
{
    public class TarefaLista
    {
        public int ID { get; set; }
        public Lista Lista { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public bool Finalizada { get; set; }
    }
}