﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Book
    {
        public Book()
        {
            BookLendings = new HashSet<BookLending>();
        }

        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public string UserId { get; set; }
        public virtual ICollection<BookLending> BookLendings { get; set; }
    }
}
