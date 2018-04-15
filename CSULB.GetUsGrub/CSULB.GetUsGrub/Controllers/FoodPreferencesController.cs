﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CSULB.GetUsGrub.BusinessLogic;

namespace CSULB.GetUsGrub.Controllers
{
    /// <summary>
    /// Controller to pages pertaining to Food Preferences
    /// 
    /// @author: Rachel Dang
    /// @updated: 04/14/18
    /// </summary>
    [RoutePrefix("FoodPreferences")]
    public class FoodPreferencesController : ApiController
    {

        [HttpGet]
        [AllowAnonymous]
        [EnableCors(origins: "http://localhost:8081", headers: "*", methods: "*")]
        public IHttpActionResult GetPreferences([FromBody] string username)
        {
            // Check if model is valid for the database
            if (!ModelState.IsValid)
            {
                // If model is not valid, return bad request
                return BadRequest(ModelState);
            }

            try
            {
                // If model is valid, call manager to get preferences
                var manager = new FoodPreferencesManager();
                var preferences = manager.GetFoodPreferences(username);

                // If there is an error in the response, return a bad request
                if (preferences.Error != null)
                {
                    return BadRequest(preferences.Error);
                }

                // Otherwise, return the preferences
                return Ok(preferences);
            }
            catch (Exception exception)
            {
                // If any other error occurs, return a bad request
                return BadRequest(exception.Message);
            }
        }
    }
}
