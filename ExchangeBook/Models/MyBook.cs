using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class MyBook
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public string BookAuthor { get; set; }
        public string BookExplanation { get; set; }

        public string BookImage { get; set; }
        public bool IsDeleted { get; set; }

        public string TypeName { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<MyFav> MyFavs { get; set; }



    }
}
