﻿namespace CSULB.GetUsGrub.Models
{
    // TODO: @Brian Please comment this [-Jenn]
    public class GeoCoordinates : IGeoCoordinates
    {
        // Automatic Properties
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Constructors
        public GeoCoordinates() { }

        public GeoCoordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
