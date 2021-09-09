using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "* Informe um nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }


        [Required(ErrorMessage = "* Informe um sobrenome")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "* Informe um email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Informe uma data")]
        [Display(Name = "DataDeNascimento")]
        public DateTime BirthDate { get; set; }

        public Book books { get; set; }

        public void BindBook(Book book)
        {
            this.books = book;
        }


    }
}
