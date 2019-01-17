using System;

namespace Library.Entities
{
    public class BookLending
    {
        public int BookLendingId { get; set; }

        public int BookId { get; set; }
        public string OwnerId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public Book Book { get; set; }
        public User Owner { get; set; }
    }
}
