using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestroManagement.DbModels.User
{
    public class AppUser : IdentityUser<int>
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LName { get; set; } = string.Empty;

        //[NotMapped]
        //public string FullName => $"{FName} {LName}";
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        [Display(Name = "Email")]
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string Email { get; set; } = string.Empty;
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword

        //[NotMapped]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; } = string.Empty;

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "The phone number must be exactly 10 digits and contain only numbers.")]
        public override string? PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [NotMapped]
        [Required(ErrorMessage = "Please select a role")]
        public string ?UserRole { get; set; } = string.Empty;


    }
}
