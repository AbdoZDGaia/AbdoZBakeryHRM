using AbdoZBakeryHRM.Shared.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbdoZBakeryHRM.Shared
{
    public class Employee : IValidatableObject
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; }

        [BirthdayValidator(MinimumAge = 18)]
        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public bool Smoker { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        [StringLength(1000, ErrorMessage = "Comment length can't exceed 1000 characters.")]
        public string Comment { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }

        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [NotMapped]
        public byte[] ImageContent { get; set; }

        public string ImageName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            if (Latitude != 0 && Longitude == 0)
            {
                errors.Add(new ValidationResult("Longitude is required if latitude has a value", new[] { nameof(Longitude) }));
            }
            else if (Longitude != 0 && Latitude == 0)
            {
                errors.Add(new ValidationResult("Latitude is required if longitude has a value", new[] { nameof(Latitude) }));

            }
            return errors;
        }
    }
}
