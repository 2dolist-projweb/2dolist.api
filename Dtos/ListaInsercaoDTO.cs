using System;

namespace api.Dtos
{
    public class ListaInsercaoDTO
    {
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public string Observacao { get; set; }

        public ListaInsercaoDTO()
        {
            DataCriacao = DateTime.Now;
            DataFinalizacao = DateTime.MinValue;
            DataUltimaAtualizacao = DateTime.Now;            
        }        
    }
}