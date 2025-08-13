using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Activities.DTO;

public class CreateActivityDto
{
    [Required]
    public string Title { get; set; } = "";

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Description { get; set; } = "";

    [Required]
    public string Category { get; set; } = "";

    public bool IsCancelled { get; set; }

    // location props
    [Required]
    public string City { get; set; } = "";

    [Required]
    public string Venue { get; set; } = "";

    public double Latitude { get; set; }

    public double Longitude { get; set; }    
}
