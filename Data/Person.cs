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

    /// <summary>
    /// Returns a string representation of the Person object.
    /// </summary>
    /// <returns>A string containing the person's name, email address, and optional accommodations.</returns>
    public override string ToString()
    {
        return "PERSON-> Name: " + this.Name + "; Email Address: " + this.EmailAddress + "; Special Accommodations (Optional): " + this.OptionalSpecialAccommodations + "\n";
    }
}
