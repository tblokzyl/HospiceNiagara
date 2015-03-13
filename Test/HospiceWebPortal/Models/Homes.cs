﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospiceWebPortal.Models
{
    public class Home
    {
        public int ID { get; set; }

        [Display(Name = "Title")]
        [StringLength(100, ErrorMessage = "Position name cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        [Display(Name = "Author")]
        [StringLength(100, ErrorMessage = "Position name cannot be longer than 100 characters.")]
        public string Author { get; set; }
    }
}