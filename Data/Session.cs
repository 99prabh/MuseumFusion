using System;

namespace MuseumFusion.Data
{
    /// <summary>
    /// The Session class represents the current user session in the museum management system. 
    /// It contains information about the current event, museum, user, and booking within the session.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Gets or sets the current event associated with the user session.
        /// </summary>
        public Event currentEvent;

        /// <summary>
        /// Gets or sets the current museum associated with the user session.
        /// </summary>
        public Museum currentMuseum;

        /// <summary>
        /// Gets or sets the current user logged into the session.
        /// </summary>
        public User currentUser;

        /// <summary>
        /// Gets or sets the current booking made by the user within the session.
        /// </summary>
        public Booking currentBooking;
    }
}
