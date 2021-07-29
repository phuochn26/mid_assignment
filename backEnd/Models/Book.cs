using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set;}
        public string BookName { get; set; }
        public DateTime PublicDay { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public BookBorrowingRequestDetail Detail { get; set; }
    }
}