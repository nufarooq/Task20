using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task20_MVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "*")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public string Date { get; set; }

        [Required(ErrorMessage = "*")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "*")]
        public string Country { get; set; }

        [Required(ErrorMessage ="*")]
        [DataType(DataType.MultilineText)]
        public string Skillsets { get; set; }
        
        public List<SelectListItem> Countrylst { get; set; }
    }
}