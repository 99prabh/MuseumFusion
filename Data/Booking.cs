using System;
namespace MuseumFusion.Data;

/// <summary>
/// Represents a booking for an event at the museum.
/// </summary>
public class Booking
{
    /// <summary>
    /// The name of the booked event.
    /// </summary>
    public string BookedEvent { get; set; }

    /// <summary>
    /// The list of people attending the event.
    /// </summary>
    public List<Person> People { get; set; }

    /// <summary>
    /// Initializes a new instance of the Booking class.
    /// </summary>
    public Booking()
    {
        People = new List<Person>();  // Initialize the list to avoid null reference exceptions.
    }

    /// <summary>
    /// Returns a string representation of the Booking object.
    /// </summary>
    /// <returns>A string containing the booked event name and the list of attending people.</returns>
    public override string ToString()
    {
        return $"Booked Event: {BookedEvent}\nAttending People: {string.Join(", ", People)}";
    }
}
