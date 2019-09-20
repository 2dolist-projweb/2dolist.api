using System;

namespace api.Models
{
    public class Lista
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
    }
}