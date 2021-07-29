using System.Collections.Generic;

namespace backEnd.Models.DTO
{    public class UserDTO
    {
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