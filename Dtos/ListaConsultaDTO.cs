using System.Collections.Generic;

namespace api.Dtos
{
    public class ListaConsultaDTO
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public ICollection<TarefaListaConsultaDTO> Tarefas { get; set; }
    }
}