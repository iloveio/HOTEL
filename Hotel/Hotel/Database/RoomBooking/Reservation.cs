

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Database
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A reservation. </summary>
    ///
    /// <remarks>   Student, 19.12.2016. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Reservation
    {
        public Reservation() { }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Student, 19.12.2016. </remarks>
        ///
        /// <param name="roomId">           Gets or sets the identifier of the room. </param>
        /// <param name="userId">           Gets or sets the identifier of the user. </param>
        /// <param name="reservationStart"> Gets or sets the Date/Time of the reservation start. </param>
        /// <param name="reservationEnd">   Gets or sets the Date/Time of the reservation end. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Reservation(uint roomId, uint userId, DateTime reservationStart, DateTime reservationEnd)
        {
            RoomId = roomId;
            UserId = userId;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the room. </summary>
        ///
        /// <value> The identifier of the room. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint RoomId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier of the user. </summary>
        ///
        /// <value> The identifier of the user. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public uint UserId { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the reservation start. </summary>
        ///
        /// <value> The reservation start. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime ReservationStart { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the reservation end. </summary>
        ///
        /// <value> The reservation end. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime ReservationEnd { get; set; }
    }
}
