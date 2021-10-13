using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01489893.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This is a function that determines how many ways one can roll the value of 10 with a dice that has m sides and a dice that has n sides.
        /// </summary>
        /// <param name="m">One dice has m sides labelled 1, 2, 3 ..., m</param>
        /// <param name="n">The other dice has n sides labelled 1, 2, 3, …, n</param>
        /// <returns>A message that shows how many ways to get the sum 10</returns>
        /// <example>
        /// GET ../api/J2/DiceGame/6/8  ->  "There are 5 total ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET ../api/J2/DiceGame/3/3  ->  "There are 0 ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET ../api/J2/Dicegame/5/5  ->  "There is 1 way to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public String DiceGame(int m, int n)
        {
            int wayCount = 0;
            string message = "";

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ( i + j == 10)
                    {
                        wayCount++;
                    }
                }
            }

            if (wayCount == 1)
            {
                message = "There is 1 way to get the sum 10.";
            }
            else
            {
                message = "There are " + wayCount + " ways to get the sum 10.";
            }

            return message;
        }
    }
}
