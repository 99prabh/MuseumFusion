using System;

namespace MuseumFusion.Data
{
    /// <summary>
    /// The User class represents a user in the museum management system. It contains user-specific information 
    /// such as ID, name, birthdate, password, followed museums, admin status, and event bookings.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique ID of the user.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the birthdate of the user.
        /// </summary>
        public DateTime birthDate { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the list of museums followed by the user.
        /// </summary>
        public List<string> followedMuseums { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a boolean indicating whether the user is an admin (true) or not (false).
        /// </summary>
        public bool isAdmin { get; set; } = false;

        /// <summary>
        /// Gets or sets the list of bookings made by the user for various events.
        /// </summary>
        public List<Booking> eventBookings { get; set; } = new List<Booking>();
    }
}
