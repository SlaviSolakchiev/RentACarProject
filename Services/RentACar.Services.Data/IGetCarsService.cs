namespace RentACar.Services.Data
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.Reservation;

    public interface IGetCarsService
    {
        IEnumerable<SelectListItem> GetCars();
    }
}
