using ApartmentAgencyApp.Models;
using ApartmentAgencyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAgencyApp.Fakes
{
    public class FakeReservationService : IReservationService
    {
        public List<Reservation> reservations { get; } = new List<Reservation>();
        public void MakeReservationInComplex(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }
}
