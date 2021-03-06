﻿using CSULB.GetUsGrub.Models;
using System.Data.Entity;

namespace CSULB.GetUsGrub.DataAccess
{
    /// <summary>
    /// Context containing all tables for user management.
    /// 
    /// @Created by: Brian Fann
    /// @Last Updated: 4/07/18
    /// </summary>
    public class RestaurantContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<RestaurantProfile> RestaurantProfiles { get; set; }
        public DbSet<RestaurantMenu> RestaurantMenus { get; set; }
        public DbSet<BusinessHour> BusinessHours { get; set; }
        public DbSet<RestaurantMenuItem> RestaurantMenuItems { get; set; }
        public DbSet<FoodPreference> FoodPreferences { get; set; }
        public RestaurantContext() : base("GetUsGrub") { }
    }

}