

using ApartmentAgencyApp.Models;
using ApartmentAgencyApp.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using NSubstitute;
using ApartmentAgencyApp.Fakes;



namespace ApartmentAgencyApp.Test
{
    //example of Guid: 00000000-0000-0000-0000-000000000001
    [TestFixture]
    public class ApartmentAgencyServiceTest
    {
        private FakeApartmentService _fakeApartmentservice;
        private FakeDateCalculationService _fakeDataCalculationService;
        private FakeReservationService _fakeReservationService;
        private ApartmentAgencyService _apartmentAgencyApp;


        [SetUp]
        public void SetUp()
        {
            _fakeApartmentservice = new FakeApartmentService(List<Apartment>()
            {
                new Apartment
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001")
                }
            });
            _fakeDataCalculationService = new FakeDateCalculationService(new RequestDaysInfo
            {
                NumberOfDays = 2,
                NumberOfSeasonDays = 5

            });
            _fakeReservationService = new FakeReservationService();
            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);


        }

        public void MakeApartmantReservation_BedOnly_ReturnsComplexB()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.BedOnly
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 5,
                NumberOfSeasonDays = 4

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexB));

           
        }

        public void MakeApartmantReservation_BedOnly_ReturnsComplex()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.BedOnly
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 5,
                NumberOfSeasonDays = 4

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexB));


        }

        public void MakeApartmantReservation_BedOnly_ReturnsComplexA()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 3,
                ApartmentType = ApartmentType.BedOnly
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 5,
                NumberOfSeasonDays = 4

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 3

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexA));


        }

        public void MakeApartmantReservation_StudioNumberOfDaysmorethen12_ReturnsComplexB()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.Studio
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 13,
                NumberOfSeasonDays = 4

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexB));


        }
        public void MakeApartmantReservation_StudioNumberOfSeasonDays_ReturnsComplexB()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.Studio
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 10,
                NumberOfSeasonDays = 11

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexB));


        }

        public void MakeApartmantReservation_StudioNumberOfSeasonDaysANDNumberOfDaysmoreThen12_ReturnsComplexB()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.Studio
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 13,
                NumberOfSeasonDays = 11

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexB));


        }
        public void MakeApartmantReservation_StudioNumberOfSeasonDaysANDNumberOfDaysmoreThen_ReturnsComplexC()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.BedOnly
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 12,
                NumberOfSeasonDays = 9

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexC));


        }
        public void MakeApartmantReservation_StudioWithTerrace_ComplexD()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.StudioWithTerrace
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 13,
                NumberOfSeasonDays = 11

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            _fakeApartmentservice = new FakeApartmentService(availableApartment);
            _fakeReservationService = new FakeReservationService();
            _fakeDataCalculationService = new FakeDateCalculationService(requestDaysInfo);

            _apartmentAgencyApp = new ApartmentAgencyService(_fakeDataCalculationService, _fakeApartmentservice, _fakeReservationService);

            _apartmentAgencyApp.MakeApartmentReservation(request);

            Assert.That(_fakeReservationService.reservations.Count, Is.EqualTo(1));
            Assert.That(_fakeReservationService.reservations[0].ApartmentComplex, Is.EqualTo(ApartmentComplex.ComplexD));


        }
        public  void ThrowException()
        {
            var request = new ReservationRequest
            {
                DistanceFromTheBeach = 700,
                NumberOfBeds = 1,
                ApartmentType = ApartmentType.StudioWithTerrace
            };
            var requestDaysInfo = new RequestDaysInfo
            {
                NumberOfDays = 13,
                NumberOfSeasonDays = 11

            };
            var apartment = new Apartment
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                NumberOfBeds = 1

            };
            var availableApartment = new List<Apartment>
         {apartment};

            var calculationDateService = Subsitute<IDateCalculationService>();
            var reservationservice = Substitute<IReservationService>();
            var apartmentservice = Substitute<IReservationService>();

            calculationDateService.GetDaysInfo(request.DateOfArrival, request.DateOfDeparture).Returns(request);
            
        }
    }

}
