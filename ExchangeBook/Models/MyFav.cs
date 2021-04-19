using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class MyFav
    {
        [Key]
        public int FavId { get; set; }

        public int BookId { get; set; }
        public virtual MyBook MyBook { get; set; }

        public int UserId { get; set; }

    }
}
