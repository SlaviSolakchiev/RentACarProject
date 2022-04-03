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

        public ReservationController(IGetCarsService carsServise)
        {
            this.carsServise = carsServise;
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

            // TODO: Redirect to recipe info page
            return this.Redirect("/");
        }
    }
}
