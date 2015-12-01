using System;

namespace DesafioFortes.Domain.Entities
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
