using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DemoApplication.Enums;
using DemoApplication.Helpers;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApplication.Models
{
    public class BookModel
    {
        public int ID { get; set; }


        [Required(ErrorMessage ="Please Enter Title Name")]
        [StringLength(50, MinimumLength =3)]
        //[MyCustomValidation("mvc")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please Enter Author Name")]
        public string Author { get; set; }


        [StringLength(100, MinimumLength = 5)]
        public string Description { get; set; }


        public string Category { get; set; }


        [Required(ErrorMessage = "Please Choose any language")]
        public int LanguageID { get; set; }


        public string Language { get; set; }

        [Display(Name ="Total Pages")]
        [Required(ErrorMessage = "Please Enter Total Pages")]
        public int? TotalPages { get; set; }


        [Display(Name = "Cover photo")]
        [Required]
        public IFormFile CoverPhoto { get; set; }


        public string CoverImageUrl { get; set; }


        [Display(Name = "Gallery image")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }


        public List<GalleryModel> Gallery { get; set; }


        [Display(Name = "Upload book")]
        [Required]
        public IFormFile BookPdf { get; set; }


        public string BookPdfUrl { get; set; }
    }
}
