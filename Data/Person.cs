using System;

namespace MuseumFusion.Data;

/// <summary>
/// Represents a person associated with the museum.
/// </summary>
public class Person
{
    /// <summary>
    /// The unique identifier for the person.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// The name of the person.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The email address of the person.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Optional special accommodations for the person.
    /// </summary>
    public string OptionalSpecialAccommodations { get; set; }

    /// <summary>
    /// Initializes a new instance of the Person class.
    /// </summary>
    public Person()
    {
    }
}
