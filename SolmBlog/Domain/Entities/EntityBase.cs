﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolmBlog.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }
        [Display(Name = "Name")]
        public virtual string Title { get; set; }
        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Text")]
        public virtual string Text { get; set; }
        [Display(Name = "Image")]
        public virtual string ImagePath { get; set; }

        [Display(Name = "SEO metatag Title")]
        public string MetaTitle { get; set; }
        [Display(Name = "SEO metatag Description")]
        public string MetaDescription { get; set; }
        [Display(Name = "SEO metatag Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime AddedDate { get; set; }
    }
}
