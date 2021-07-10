using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolmBlog.Domain.Entities
{
    public class Article : EntityBase
    {
        [Required(ErrorMessage = "Fill article name!")]
        [Display(Name = "Article title")]
        public override string Title { get; set; }
    }
}
