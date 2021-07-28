using System.ComponentModel.DataAnnotations;

namespace SolmBlog.Domain.Entities
{
    public class Article : EntityBase
    {
        [Required(ErrorMessage = "Fill article name!")]
        [Display(Name = "Article title")]
        public override string Title { get; set; }
        [Required]
        public string CodeWord { get; set; }
    }
}
