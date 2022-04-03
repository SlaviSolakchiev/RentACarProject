namespace RentACar.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.Reservation;

    public class GetCarsService : IGetCarsService
    {
        private readonly IDeletableEntityRepository<Reservation> reservationReposirory;
        private readonly IDeletableEntityRepository<Car> carsReposirory;

        public GetCarsService(IDeletableEntityRepository<Reservation> reservationReposirory, IDeletableEntityRepository<Car> carsReposirory)
        {
            this.reservationReposirory = reservationReposirory;
            this.carsReposirory = carsReposirory;
        }

        public IEnumerable<SelectListItem> GetCars()
        {
            var data = this.carsReposirory.All().ToList().Select(x => new SelectListItem() { Text = $" {x.Brand} - {x.Model}", Value = x.Id.ToString() });

            return data;
        }
    }
}
