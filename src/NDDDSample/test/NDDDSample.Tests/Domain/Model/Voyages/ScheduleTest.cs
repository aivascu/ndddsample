namespace NDDDSample.Tests.Domain.Model.Voyages
{
    using System.Collections.Generic;
    using Moq;
    using NDDDSample.Domain.Model.Voyages;
    using NUnit.Framework;

    [TestFixture, Category(UnitTestCategories.DomainModel)]
    public class ScheduleTest
    {
        [Test]
        public void CarrierMovements_ContainsMovementFromCtor()
        {
            var movementMock = new Mock<CarrierMovement>();
            var sut = new Schedule(new List<CarrierMovement> { movementMock.Object });

            CollectionAssert.Contains(sut.CarrierMovements, movementMock.Object);
        }

        [Test]
        public void SameValueAs_ForSameValue_ReturnsTrue()
        {
            var movementMock = new Mock<CarrierMovement> { CallBase = true };
            var movements = new List<CarrierMovement> { movementMock.Object };
            var sut = new Schedule(movements);
            var other = new Schedule(movements);

            var actual = sut.SameValueAs(other);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_ForSameReference_ReturnsTrue()
        {
            var movementMock = new Mock<CarrierMovement>();

            var sut = new Schedule(new List<CarrierMovement> { movementMock.Object });

            var actual = sut.Equals(sut);

            Assert.IsTrue(actual);
        }

        [Test]
        public void GetHashCode_ForSameValue_ReturnsSameHashCode()
        {
            var movementMock = new Mock<CarrierMovement>();
            var movements = new List<CarrierMovement> { movementMock.Object };
            var sut = new Schedule(movements);
            var other = new Schedule(movements);

            var expected = sut.GetHashCode();
            var actual = other.GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
