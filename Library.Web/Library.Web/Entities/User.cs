using System.Collections.Generic;

namespace Library.Web.Entities
{
    public class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            BookLendings = new HashSet<BookLending>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<BookLending> BookLendings { get; set; }
    }
}
