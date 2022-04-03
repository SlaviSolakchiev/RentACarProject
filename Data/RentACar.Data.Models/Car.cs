namespace RentACar.Data.Models
{
    using System;

    using RentACar.Data.Common.Models;

    public class Car : BaseDeletableModel<string>
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime Year { get; set; }

        public int PassengersCount { get; set; }

        public string Description { get; set; }

        public double PriceForDay { get; set; }
    }
}
