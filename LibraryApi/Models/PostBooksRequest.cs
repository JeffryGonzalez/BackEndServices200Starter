using LibraryApi.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class PostBooksRequest : IValidatableObject
    {

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        
        [Range(1, int.MaxValue)]
        [BindRequired]
        //[JsonConverter(typeof(StringToIntConverter))]
        public int NumberOfPages { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == "Great Expectations" && Author == "Dickens")
            {
                yield return new ValidationResult("Alec hates that book!", new string[] { "Title", "Author" });
            }
        }
    }

}
