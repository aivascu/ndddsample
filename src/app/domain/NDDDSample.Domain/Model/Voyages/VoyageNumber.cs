﻿namespace NDDDSample.Domain.Model.Voyages
{
    #region Usings

    using System;
    using Shared;
    using TempHelper;

    #endregion

    /// <summary>
    /// Identifies a voyage.
    /// </summary>
    public class VoyageNumber : IValueObject<VoyageNumber>
    {
        private readonly string number;

        public VoyageNumber(String number)
        {
            Validate.notNull(number);

            this.number = number;
        }

        protected VoyageNumber()
        {
            // Needed by Hibernate
        }

        #region IValueObject<VoyageNumber> Members

        /// <summary>
        /// Value objects compare by the values of their attributes, they don't have an identity.
        /// </summary>
        /// <param name="other">The other value object.</param>
        /// <returns>true if the given value object's and this value object's attributes are the same.</returns>
        public bool SameValueAs(VoyageNumber other)
        {
            return other != null && number.Equals(other.number);
        }

        #endregion

        #region Object's override

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
            if (!(obj.GetType().IsInstanceOfType(typeof (VoyageNumber))))
            {
                return false;
            }

            var other = (VoyageNumber) obj;

            return SameValueAs(other);
        }


        public override int GetHashCode()
        {
            return number.GetHashCode();
        }

        public override string ToString()
        {
            return number;
        }

        #endregion

        public string IdString()
        {
            return number;
        }
    }
}