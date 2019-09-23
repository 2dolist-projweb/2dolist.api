using System;

namespace api.Dtos
{
    public class TarefaListaInsercaoDTO
    {
        public string Descricao { get; set; }
        public int IdLista { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }

        public TarefaListaInsercaoDTO()
        {
            DataCriacao = DateTime.Now;
            DataFinalizacao = DateTime.MinValue;
            DataUltimaAtualizacao = DateTime.Now;            
        }                
    }
}