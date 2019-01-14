namespace Library.Web.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
