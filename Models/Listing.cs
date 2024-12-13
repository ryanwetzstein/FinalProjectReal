using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Listing
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Breed is required.")]
        [StringLength(50, ErrorMessage = "Breed cannot be longer than 50 characters.")]
        public string? Breed { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Size is required.")]
        [StringLength(50, ErrorMessage = "Size cannot be longer than 50 characters.")]
        public string? Size { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(50, ErrorMessage = "Location cannot be longer than 50 characters.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Image URL is required.")]
        [Url(ErrorMessage = "Invalid Image URL format.")]
        public string? ImageUrl { get; set; }

        [StringLength(50, ErrorMessage = "Temperance cannot be longer than 50 characters.")]
        public string? Temperance { get; set; }

        [StringLength(50, ErrorMessage = "Health status cannot be longer than 50 characters.")]
        public string? Health { get; set; }
    }
}
