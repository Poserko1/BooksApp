using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure1.Data.Models
{
  
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string BookName { get; set; }

        [Required]
        [StringLength(30)]
        public string Author { get; set; }

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        public string Picture { get; set; }

        public DateTime YearOfPublication { get; set; }


        [Required]
        [Range(5, 200)]
        public double Price { get; set; }
    }
}
