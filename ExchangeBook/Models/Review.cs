using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Reviews { get; set; }
        public int Reviewer { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
