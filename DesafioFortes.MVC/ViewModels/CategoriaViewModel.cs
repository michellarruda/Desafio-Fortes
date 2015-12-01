using System.Collections.Generic;

namespace DesafioFortes.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<ReceitaViewModel> Receitas { get; set; }
        public virtual IEnumerable<DespesaViewModel> Despesas { get; set; }
    }
}