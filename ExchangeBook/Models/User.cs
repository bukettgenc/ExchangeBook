using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeBook.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
    
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        public string Password2 { get; set; }
        public bool IsDeleted { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public ICollection<MyBook> MyBooks { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Opinion> Opinions { get; set; }

    }
}