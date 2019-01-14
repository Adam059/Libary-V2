using System.Collections.Generic;

namespace Library.Web.Entities
{
    public class Book
    {
        public Book()
        {
            BookLendings = new HashSet<BookLending>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
        public virtual ICollection<BookLending> BookLendings { get; set; }
    }
}
