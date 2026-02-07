using System.ComponentModel.DataAnnotations;

namespace LandParcelFinder.Models
{
    public class Parcel
    {
        public int ParcelId { get; set;}

        [Required]
        [Display(Name = "Parcel Number")]
        public string ParcelNumber { get; set;}

        [Required]
        public string Address { get; set;}

        [Required]
        public string county { get; set;}

        [Required]
        [Display(Name = "Size (Acres)")]
        public decimal SizeInAcres {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set;}

        [Display(Name = "Has Wetlands")]
        public bool HasWetLands { get; set; }

        [Required]
        public string Status { get; set;}

        public string? notes {get; set;}

        [Display(Name = "Creation Date")]
        public DateTime CreatedDate {get; set;} = DateTime.Now;
    }
}