using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool _isAdmin { get; set; }
        public bool? IsAdmin
        {
            get
            {
                return _isAdmin;
            }
            set
            {
                _isAdmin = value.HasValue ? false : value.Value;
            }
        }
        public int BookBorrowingRequestId { get; set; }
        public List<BookBorrowingRequest> Requests { get; set; }
    }
}