using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "* Informe título")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        
        [Required(ErrorMessage = "* Informe um número do ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "* Informe um ano")]
        [Display(Name = "Ano")]
        public DateTime Year { get; set; }



    }
}
