using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01489893.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This is a function that calculates total calories based on user's choices. 
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>A message that shows total calories</returns>
        /// <example>
        /// GET ../api/J1/Menu/4/4/4/4  ->  "Your total calorie count is 0"
        /// </example>
        /// <example>
        /// GET ../api/J1/Menu/1/2/3/4  ->  "Your total calorie count is 691"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public String Menu(int burger, int drink, int side, int dessert)
        {
            int totalCalorie = 0;
            string message = "Your total calorie count is ";
            
            // Handle burger input
            if (burger == 1)
            {
                totalCalorie += 461;
            }
            else if (burger == 2)
            {
                totalCalorie += 431;
            }
            else if (burger == 3)
            {
                totalCalorie += 420;
            }

            // Handle drink input
            if (drink == 1)
            {
                totalCalorie += 130;
            }
            else if (drink == 2)
            {
                totalCalorie += 160;
            }
            else if (drink == 3)
            {
                totalCalorie += 118;
            }

            // Handle side input
            if (side == 1)
            {
                totalCalorie += 100;
            }
            else if (side == 2)
            {
                totalCalorie += 57;
            }
            else if (side == 3)
            {
                totalCalorie += 70;
            }

            // Handle dessert input
            if (dessert == 1)
            {
                totalCalorie += 167;
            }
            else if (dessert == 2)
            {
                totalCalorie += 266;
            }
            else if (dessert == 3)
            {
                totalCalorie += 75;
            }

            message = message + totalCalorie;

            return message;
        }
    }
}
