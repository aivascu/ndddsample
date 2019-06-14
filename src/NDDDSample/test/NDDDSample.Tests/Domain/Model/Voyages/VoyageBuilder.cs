namespace NDDDSample.Tests.Domain.Model.Voyages
{
    using System;
    using Moq;
    using NDDDSample.Domain.Model.Voyages;

    public class VoyageBuilder
    {
        private Mock<VoyageNumber> _voyageNumberMock;
        private Mock<Schedule> _scheduleMock;

        public VoyageBuilder()
        {
            _voyageNumberMock = new Mock<VoyageNumber>();
            _scheduleMock = new Mock<Schedule>();
        }

        public VoyageBuilder Using(Mock<VoyageNumber> mock)
        {
            _voyageNumberMock = mock;
            return this;
        }

        public VoyageBuilder With(Action<Mock<VoyageNumber>> action)
        {
            action?.Invoke(_voyageNumberMock);
            return this;
        }

        public VoyageBuilder Using(Mock<Schedule> mock)
        {
            _scheduleMock = mock;
            return this;
        }

        public VoyageBuilder With(Action<Mock<Schedule>> action)
        {
            action?.Invoke(_scheduleMock);
            return this;
        }

        public Voyage Build()
        {
            return new Voyage(_voyageNumberMock.Object, _scheduleMock.Object);
        }
    }
}
