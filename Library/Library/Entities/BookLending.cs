using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class BookLending
    {
        [Key]
        public int BookLendingId { get; set; }

        public int BookId { get; set; }
        public string UserId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public Book Book { get; set; }
    }
}
