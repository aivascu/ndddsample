namespace NDDDSample.Tests.Domain.Model.Voyages
{
    using System.Linq;
    using Moq;
    using NDDDSample.Domain.Model.Locations;
    using NDDDSample.Domain.Model.Voyages;
    using NUnit.Framework;

    [TestFixture, Category(UnitTestCategories.DomainModel)]
    public class VoyageTest
    {
        [Test]
        public void VoyageNumber_UsesVoyageNumber()
        {
            VoyageNumber voyageNumber = null;
            var sut = new VoyageBuilder()
                .With((Mock<VoyageNumber> m) =>
                {
                    m.CallBase = true;
                    voyageNumber = m.Object;
                })
                .Build();

            Assert.AreEqual(voyageNumber, sut.VoyageNumber);
        }

        [Test]
        public void Schedule_UsesProvidedSchedule()
        {
            Schedule schedule = null;
            var sut = new VoyageBuilder()
                .With((Mock<Schedule> m) =>
                {
                    m.CallBase = true;
                    schedule = m.Object;
                })
                .Build();

            Assert.AreEqual(schedule, sut.Schedule);
        }

        [Test]
        public void GetHashCode_ReturnsVoyageNumberHashCode()
        {
            var sut = new VoyageBuilder()
                .With((Mock<VoyageNumber> m) =>
                    m.Setup(vn => vn.GetHashCode()).Returns(5))
                .Build();

            var actual = sut.GetHashCode();

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Equals_SameReference_ReturnsTrue()
        {
            var sut = new VoyageBuilder()
                .Build();

            var actual = sut.Equals(sut);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_SameReferenceVoyageNumber_ReturnsTrue()
        {
            var voyageNumber = new Mock<VoyageNumber>("aS2e32B");
            var sut1 = new VoyageBuilder()
                .Using(voyageNumber)
                .Build();
            var sut2 = new VoyageBuilder()
                .Using(voyageNumber)
                .Build();

            var actual = sut1.Equals(sut2);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_SameValueVoyageNumber_ReturnsTrue()
        {
            const string voyageNumber = "aO2s34N";
            var sut1 = new VoyageBuilder()
                .Using(new Mock<VoyageNumber>(voyageNumber))
                .Build();
            var sut2 = new VoyageBuilder()
                .Using(new Mock<VoyageNumber>(voyageNumber))
                .Build();

            var actual = sut1.Equals(sut2);

            Assert.IsTrue(actual);
        }

        [Test]
        public void SameIdentityAs_ChecksVoyageNumber()
        {
            const string voyageNumber = "aO2s34N";
            var sut1 = new VoyageBuilder()
                .Using(new Mock<VoyageNumber>(voyageNumber))
                .Build();
            var sut2 = new VoyageBuilder()
                .Using(new Mock<VoyageNumber>(voyageNumber))
                .Build();

            var actual = sut1.SameIdentityAs(sut2);

            Assert.IsTrue(actual);
        }

        [Test]
        public void ToString_ReturnsValueContainingVoyageNumber()
        {
            var sut = new VoyageBuilder()
                .Using(new Mock<VoyageNumber>("a2sJ5KA312") { CallBase = true })
                .Build();

            var actual = sut.ToString();

            Assert.AreEqual("Voyage a2sJ5KA312", actual);
        }

        [Test]
        public void AddMovement_AddsLocationToSchedule()
        {
            var targetLocation = new Mock<Location>();
            targetLocation.Setup(tl => tl.SameIdentityAs(targetLocation.Object)).Returns(true);
            var sut = new Voyage.Builder(new VoyageNumber("eY72I01w"), Location.UNKNOWN)
                .AddMovement(targetLocation.Object, default, default)
                .Build();

            Assert.IsTrue(sut.Schedule.CarrierMovements.Any(cm => cm.ArrivalLocation.SameIdentityAs(targetLocation.Object)));
        }

        [Test]
        public void Build_BuildsAVaildVoyage()
        {
            var voyageNumber = new Mock<VoyageNumber>(string.Empty) { CallBase = true };
            voyageNumber.Setup(vn => vn.Equals(voyageNumber.Object)).Returns(true);

            var sut = new Voyage.Builder(voyageNumber.Object, Location.UNKNOWN)
                .AddMovement(new Mock<Location>().Object, default, default)
                .Build();

            Assert.AreEqual(voyageNumber.Object, sut.VoyageNumber);
        }
    }
}
