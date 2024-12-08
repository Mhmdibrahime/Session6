using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Session6.Models.ViewModels
{
    public class AddBookViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        [ValidateNever]
        public List<Author>? AuthorList { get; set; }
        [ValidateNever]
        public List<Category>? Categories { get; set; }
    }
}
