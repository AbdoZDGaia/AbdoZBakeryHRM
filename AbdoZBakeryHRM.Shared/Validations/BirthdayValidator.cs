using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdoZBakeryHRM.Shared.Validations
{
    public class BirthdayValidator : ValidationAttribute
    {
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthdate;
            if (DateTime.TryParse(value.ToString(), out birthdate))
            {
                if (birthdate < DateTime.Now.AddYears(MinimumAge * -1))
                {
                    return null;
                }
                else
                {
                    return new ValidationResult($"Employee must be at least {MinimumAge}.", new[] { validationContext.MemberName });
                }
            }

            return new ValidationResult("Invalid birth date", new[] { validationContext.MemberName });
        }
    }
}
