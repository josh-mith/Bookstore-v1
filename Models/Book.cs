using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorFirst { get; set; }
        public string AuthorMiddle { get; set; }
        public string AuthorLast { get; set; }
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}", ErrorMessage = "Your ISBN is incorrect")]
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
       
    }
}
