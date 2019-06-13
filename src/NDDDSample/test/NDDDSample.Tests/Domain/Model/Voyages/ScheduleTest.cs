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
        public void TestCarrierMovements()
        {
            var movementMock = new Mock<CarrierMovement>();
            var sut = new Schedule(new List<CarrierMovement> { movementMock.Object });

            CollectionAssert.Contains(sut.CarrierMovements, movementMock.Object);
        }

        [Test]
        public void TestSameValueAs()
        {
            var movementMock = new Mock<CarrierMovement> { CallBase = true };
            var movements = new List<CarrierMovement> { movementMock.Object };
            var sut = new Schedule(movements);
            var other = new Schedule(movements);

            var actual = sut.SameValueAs(other);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestEquals()
        {
            var movementMock = new Mock<CarrierMovement>();

            var sut = new Schedule(new List<CarrierMovement> { movementMock.Object });

            var actual = sut.Equals(sut);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public void TestHashCode()
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
