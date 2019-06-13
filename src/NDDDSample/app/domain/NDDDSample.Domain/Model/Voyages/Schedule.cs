namespace NDDDSample.Domain.Model.Voyages
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Infrastructure.Builders;
    using Infrastructure.Validations;
    using Shared;

    /// <summary>
    /// A voyage schedule.
    /// </summary>
    public class Schedule : IValueObject<Schedule>, IEquatable<Schedule>
    {
        public static readonly Schedule EMPTY = new Schedule();
        private readonly IList<CarrierMovement> carrierMovements = new List<CarrierMovement>();

        internal Schedule(IList<CarrierMovement> carrierMovements)
        {
            Validate.NotNull(carrierMovements);
            Validate.NoNullElements(carrierMovements);
            Validate.NotEmpty(carrierMovements);

            this.carrierMovements = carrierMovements;
        }

        protected Schedule()
        {
            // Needed by Hibernate
        }

        /// <summary>
        /// Carrier movements.
        /// </summary>
        public IList<CarrierMovement> CarrierMovements
        {
            get { return new ReadOnlyCollection<CarrierMovement>(carrierMovements); }
        }

        public override bool Equals(object other)
        {
            if (this == other)
            {
                return true;
            }

            if (other == null || GetType() != other.GetType())
            {
                return false;
            }

            var that = (Schedule)other;

            return SameValueAs(that);
        }

        public bool Equals(Schedule other)
        {
            if (other == null)
            {
                return false;
            }

            if (other == this)
            {
                return true;
            }

            return SameValueAs(other);
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder().Append(carrierMovements).ToHashCode();
        }

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool SameValueAs(Schedule other)
        {
            if (other == null)
            {
                return false;
            }

            return carrierMovements.SequenceEqual(other.carrierMovements);
        }
    }
}
