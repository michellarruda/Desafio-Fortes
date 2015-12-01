using System.Collections.Generic;

namespace DesafioFortes.Domain.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Receita> Receitas { get; set; }
        public virtual IEnumerable<Despesa> Despesas { get; set; }
    }
}
