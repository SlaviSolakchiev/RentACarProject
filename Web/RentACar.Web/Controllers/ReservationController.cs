namespace RentACar.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Services.Data;
    using RentACar.Web.ViewModels.Reservation;

    public class ReservationController : BaseController
    {
        private readonly IGetCarsService carsServise;
        private readonly IDeletableEntityRepository<Reservation> reservationRepository;

        public ReservationController(IGetCarsService carsServise, IDeletableEntityRepository<Reservation> reservationRepository)
        {
            this.carsServise = carsServise;
            this.reservationRepository = reservationRepository;
        }

        public IActionResult CarFleet()
        {
            var viewModel = new ReservationInputModel();
            viewModel.Cars = this.carsServise.GetCars();

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult CarFleet(ReservationInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            this.reservationRepository.AddAsync(new Reservation
            {
                StartDate = input.StartDate,
                EndDate = input.EndDate,
                CarId = input.CarId,
            });
            return this.Redirect("/");
        }
    }
}
