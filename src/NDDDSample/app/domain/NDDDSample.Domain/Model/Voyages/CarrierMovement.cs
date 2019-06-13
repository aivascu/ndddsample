namespace NDDDSample.Domain.Model.Voyages
{
    using System;
    using Infrastructure.Builders;
    using Infrastructure.Validations;
    using Locations;
    using Shared;

    /// <summary>
    /// A carrier movement is a vessel voyage from one location to another.
    /// </summary>
    public class CarrierMovement : IValueObject<CarrierMovement>, IEquatable<CarrierMovement>
    {
        // Null object pattern
        public static CarrierMovement NONE = new CarrierMovement(
            Location.UNKNOWN,
            Location.UNKNOWN,
            new DateTime(0),
            new DateTime(0));

        private readonly Location arrivalLocation;
        private readonly DateTime arrivalTime;
        private readonly Location departureLocation;
        private readonly DateTime departureTime;
        private int id;

        /// <summary>
        /// Constructor.
        /// TODO make assembly local
        /// </summary>
        /// <param name="departureLocation">location of departure</param>
        /// <param name="arrivalLocation">location of arrival</param>
        /// <param name="departureTime">time of departure</param>
        /// <param name="arrivalTime">time of arrival</param>
        public CarrierMovement(
            Location departureLocation,
            Location arrivalLocation,
            DateTime departureTime,
            DateTime arrivalTime)
        {
            Validate.NoNullElements(new object[]
            {
                departureLocation,
                arrivalLocation,
                departureTime,
                arrivalTime
            });
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.departureLocation = departureLocation;
            this.arrivalLocation = arrivalLocation;
        }

        protected CarrierMovement()
        {
            // Needed by Hibernate
        }

        /// <summary>
        /// Arrival location.
        /// </summary>
        public virtual Location ArrivalLocation
        {
            get { return arrivalLocation; }
        }

        /// <summary>
        ///  Time of arrival.
        /// </summary>
        public virtual DateTime ArrivalTime
        {
            get { return arrivalTime; }
        }

        /// <summary>
        /// Departure location.
        /// </summary>
        public virtual Location DepartureLocation
        {
            get { return departureLocation; }
        }

        /// <summary>
        /// Time of departure.
        /// </summary>
        public virtual DateTime DepartureTime
        {
            get { return departureTime; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var that = (CarrierMovement)obj;

            return SameValueAs(that);
        }

        public virtual bool Equals(CarrierMovement other)
        {
            if (other == null)
            {
                return false;
            }

            if (this == other)
            {
                return true;
            }

            return SameValueAs(other);
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder().
                Append(departureLocation).
                Append(departureTime).
                Append(arrivalLocation).
                Append(arrivalTime).
                ToHashCode();
        }

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public virtual bool SameValueAs(CarrierMovement other)
        {
            return other != null && new EqualsBuilder().
                                        Append(departureLocation, other.departureLocation).
                                        Append(departureTime, other.departureTime).
                                        Append(arrivalLocation, other.arrivalLocation).
                                        Append(arrivalTime, other.arrivalTime).
                                        IsEquals();
        }
    }
}
