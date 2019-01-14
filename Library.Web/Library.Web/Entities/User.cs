using System.Collections.Generic;

namespace Library.Web.Entities
{
    public class User
    {
        public User()
        {
            Books = new HashSet<Book>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
