using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Helpers
{
    public class MyCustomValidation : ValidationAttribute
    {
        public MyCustomValidation(string txt)
        {
            Text = txt;
        }

        public string Text { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string bookName = value.ToString();
                if(bookName.Contains(Text))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Field doesn't contains desired value");
        }
    }
}
