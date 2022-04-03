namespace RentACar.Web.ViewModels.Reservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using RentACar.Data.Models;

    public class ReservationInputModel
    {
        public string CarId { get; set; }

        [Required]
        [MinLength(3)]
        public string UserName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<SelectListItem> Cars { get; set; }
    }
}
