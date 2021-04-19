using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class BookType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<MyBook> MyBooks { get; set; }
    }
}
