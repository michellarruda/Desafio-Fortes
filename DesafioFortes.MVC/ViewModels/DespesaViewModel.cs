using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DesafioFortes.MVC.ViewModels
{
    public class DespesaViewModel
    {
        [Key]
        public int DespesaId { get; set; }

        [Required(ErrorMessage = "Preencha um valor.")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal Valor { get; set; }

        
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Preencha uma observação.")]
        [DisplayName("Observação")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres.")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria.")]
        public int CategoriaId { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}