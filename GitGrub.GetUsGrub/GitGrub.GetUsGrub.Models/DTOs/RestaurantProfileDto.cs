﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitGrub.GetUsGrub.Models.DTOs
{
    public class RestaurantProfileDto : IProfile, IRestaurantProfile
    {
        public string ProfileName { get; set; }
        public string ProfilePicture { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double PhoneNumber { get; set; }
        public string Category { get; set; }
        public IEnumerable<BusinessHours> BusinessSchedule { get; set; }
        public bool HasReservations { get; set; }
        public bool HasDelivery { get; set; }
        public bool HasTakeOut { get; set; }
        public bool AcceptCreditCards { get; set; }
        public string Attire { get; set; }
        public bool ServesAlcohol { get; set; }
        public bool HasOutdoorSeating { get; set; }
        public bool HasTv { get; set; }
        public bool HasDriveThru { get; set; }
        public bool Caters { get; set; }
        public bool AllowsPets { get; set; }
        public List<RestaurantMenuItem> Menu { get; set; }
    }
}
