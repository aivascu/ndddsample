namespace NDDDSample.Domain.Model.Voyages
{
    using System;
    using Infrastructure.Validations;
    using Shared;

    /// <summary>
    /// Identifies a voyage.
    /// </summary>
    public class VoyageNumber : IValueObject<VoyageNumber>, IEquatable<VoyageNumber>
    {
        private readonly string number;

        public VoyageNumber(string number)
        {
            Validate.NotNull(number);

            this.number = number;
        }

        protected VoyageNumber()
        {
            // Needed by Hibernate
        }

        public string IdString
        {
            get { return number; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (!(obj is VoyageNumber))
            {
                return false;
            }

            var other = (VoyageNumber)obj;

            return SameValueAs(other);
        }

        public virtual bool Equals(VoyageNumber other)
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
            return number.GetHashCode();
        }

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool SameValueAs(VoyageNumber other)
        {
            return other != null && number.Equals(other.number);
        }

        public override string ToString()
        {
            return number;
        }
    }
}
