using System;
using api.Enums;

namespace api.Models
{
    public class Lista
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public PrioridadesLista Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public string Observacao { get; set; }
        public bool Finalizada { get; set; }
    }
}