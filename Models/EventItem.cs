using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class EventItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(10, ErrorMessage = "Name cannot be longer than 10 characters.")]
        public string? Date { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(6, ErrorMessage = "Name cannot be longer than 6 characters.")]
        public string? TimeStart { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(6, ErrorMessage = "Name cannot be longer than 6 characters.")]
        public string? TimeEnd { get; set; }

        //[Required(ErrorMessage = "Date of Birth is required.")]
        //[DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        //[Range(typeof(DateTime), "1/1/1900", "12/31/2100", ErrorMessage = "Please enter a valid date within the range.")]
        //public DateTime? DateOfEvent { get; set; }

        //[Required(ErrorMessage = "Time is required.")]
        //[DataType(DataType.Time, ErrorMessage = "Invalid time format.")]
        //public TimeSpan? StartTime { get; set; }

        //[Required(ErrorMessage = "Time is required.")]
        //[DataType(DataType.Time, ErrorMessage = "Invalid time format.")]
        //public TimeSpan? EndTime { get; set; }
    }
}
