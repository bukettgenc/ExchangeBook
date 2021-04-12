using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eksiSozluk.Models
{
    public class HomePage
    {
        [Key]
        public int Id { get; set; } 
        public string Post { get; set; }
        public int HomePageId { get; set; }

    }
}
