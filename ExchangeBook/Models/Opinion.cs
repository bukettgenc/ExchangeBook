using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class Opinion
    {
        [Key]
        public int OpinionId { get; set; }
        public string YourOpinion { get; set; }
        public bool Published { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
