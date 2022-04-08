namespace RentACar.Web.ViewModels.Reservation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using RentACar.Data.Models;

    public class ReservationInputModel
    {
        private readonly ApplicationUser user;

        public ReservationInputModel(ApplicationUser user)
        {
            this.user = user;
        }

        public string CarId { get; set; }

        [Required]
        [MinLength(3)]
        public string UserName => this.user.UserName;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<SelectListItem> Cars { get; set; }
    }
}
