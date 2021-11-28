using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Species { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string Gender { get; set; }
    [Required]
    [Range(0.1, 100, ErrorMessage = "Age must be between 0.1 and 100 years ")]
    public int Age { get; set; }
    [Required]
    public string Backstory { get; set; }
  }
}