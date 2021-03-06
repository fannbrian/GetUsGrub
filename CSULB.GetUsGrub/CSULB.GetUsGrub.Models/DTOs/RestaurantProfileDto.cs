﻿using System.Collections.Generic;

namespace CSULB.GetUsGrub.Models
{
    /// <summary>
    /// Restaurant profile DTO
    /// 
    /// @author: Andrew Kao
    /// @updated: 4/25/18
    /// </summary>
    public class RestaurantProfileDto : IRestaurantProfile
    {
        
        // Automatic properties
        public string DisplayName { get; set; }
        public string DisplayPicture { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public RestaurantDetail Details { get; set; }
        public GeoCoordinates GeoCoordinates { get; set; }
        public IList<RestaurantBusinessHourDto> BusinessHours { get; set; }
        public IList<RestaurantMenuWithItems> RestaurantMenusList { get; set; }

        // Constructors
        public RestaurantProfileDto() { }

        public RestaurantProfileDto(UserProfile userProfile, RestaurantProfile restaurantProfile, IList<RestaurantBusinessHourDto> restaurantBusinessHourDtos, IList<RestaurantMenuWithItems> restaurantMenusList)
        {
            DisplayName = userProfile.DisplayName;
            DisplayPicture = userProfile.DisplayPicture;
            PhoneNumber = restaurantProfile.PhoneNumber;
            Address = restaurantProfile.Address;
            Details = restaurantProfile.Details;
            BusinessHours = restaurantBusinessHourDtos;
            RestaurantMenusList = restaurantMenusList;
        }
    }
}