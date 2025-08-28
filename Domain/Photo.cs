using System;
using System.Text.Json.Serialization;

namespace Domain;

public class Photo
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Url { get; set; }
    public required string PublicId { get; set; }

    // nav properties
    public required string UserId { get; set; }

    // Prevents the property from being serialized or deserialized.
    // This solves a recursive problem
    [JsonIgnore]
    public User User { get; set; } = null!;
}
