using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Activities.DTO;

public class CreateActivityDto
{
    public string Title { get; set; } = "";

    public DateTime Date { get; set; }

    public string Description { get; set; } = "";

    public string Category { get; set; } = "";

    public bool IsCancelled { get; set; }

    // location props
    public string City { get; set; } = "";

    public string Venue { get; set; } = "";

    public double Latitude { get; set; }

    public double Longitude { get; set; }    
}
