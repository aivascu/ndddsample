namespace NDDDSample.Tests.Domain.Model.Voyages
{
    using NDDDSample.Domain.Model.Voyages;
    using NUnit.Framework;

    [TestFixture, Category(UnitTestCategories.DomainModel)]
    public class VoyageNumberTest
    {
        [Test]
        public void Equals_ForSameReference_ReturnsTrue()
        {
            var sut = new VoyageNumber("9aA9iDDU2");

            var actual = sut.Equals(sut);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_ForSameValue_ReturnsTrue()
        {
            var sut1 = new VoyageNumber("9aA9iDDU2");
            var sut2 = new VoyageNumber("9aA9iDDU2");

            var actual = sut1.Equals(sut2);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_ForDifferentValue_ReturnsFalse()
        {
            var sut1 = new VoyageNumber("9aA9iDDU2");
            var sut2 = new VoyageNumber("U982aJnNd");

            var actual = sut1.Equals(sut2);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestHashCode()
        {
            const string number = "aaa";
            var expected = number.GetHashCode();
            var sut = new VoyageNumber(number);

            var actual = sut.GetHashCode();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SameValueAs_ForSameValue_ReturnsTrue()
        {
            var sut1 = new VoyageNumber("9aA9iDDU2");
            var sut2 = new VoyageNumber("9aA9iDDU2");

            var actual = sut1.SameValueAs(sut2);

            Assert.IsTrue(actual);
        }

        [Test]
        public void SameValueAs_ForDifferentValue_ReturnsTrue()
        {
            var sut1 = new VoyageNumber("9aA9iDDU2");
            var sut2 = new VoyageNumber("U982aJnNd");

            var actual = sut1.SameValueAs(sut2);

            Assert.IsFalse(actual);
        }

        [Test]
        public void ToString_ContainsTheValue()
        {
            const string number = "9aA9iDDU2";
            var sut = new VoyageNumber(number);

            var actual = sut.ToString();

            Assert.IsTrue(actual.Contains(number));
        }

        [Test]
        public void TestIdString()
        {
            const string number = "9aA9iDDU2";

            var sut = new VoyageNumber(number);

            var actual = sut.IdString;

            Assert.AreEqual(number, actual);
        }
    }
}
