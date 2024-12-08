namespace Session6.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}
