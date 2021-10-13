using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01489893.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Original Source: https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf
        /// This is a function that calculates time needed to type certain words on a cell phone assuming one second per key press and addtional two seconds on a pause.
        /// </summary>
        /// <param name="word">A string consisting only lowercase letters</param>
        /// <returns>An integer represetning minimal number of seconds needed to type in the word</returns>
        /// <example>
        /// GET ../api/J3/Messaging/dada    ->  4
        /// </example>
        /// <example>
        /// GET ../api/J3/Messaging/abba    ->  12
        /// </example>
        /// <example>
        /// GET ../api/J3/Messaging/www    ->  7
        /// </example>
        [HttpGet]
        [Route("api/J3/Messaging/{word}")]
        public int Messaging(string word)
        {
            int secondCount = 0;
            int pressCount = 0;
            int key = 0;
            int previousKey = 0;

            // Loop each character
            for (int i = 0; i < word.Length; i++)
            {
                // Locate the key
                switch (word[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        key = 2;
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        key = 3;
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        key = 4;
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        key = 5;
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        key = 6;
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        key = 7;
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        key = 8;
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        key = 9;
                        break;
                }

                // Count how many times a key needs to be pressed
                switch (word[i])
                {
                    case 'a':
                    case 'd':
                    case 'g':
                    case 'j':
                    case 'm':
                    case 'p':
                    case 't':
                    case 'w':
                        pressCount = 1;
                        break;
                    case 'b':
                    case 'e':
                    case 'h':
                    case 'k':
                    case 'n':
                    case 'q':
                    case 'u':
                    case 'x':
                        pressCount = 2;
                        break;
                    case 'c':
                    case 'f':
                    case 'i':
                    case 'l':
                    case 'o':
                    case 'r':
                    case 'v':
                    case 'y':
                        pressCount = 3;
                        break;
                    case 's':
                    case 'z':
                        pressCount = 4;
                        break;
                }

                // Add 2 seconds if the current and previous letters are on the same key
                if (key == previousKey)
                {
                    secondCount = secondCount + pressCount + 2;
                }
                else
                {
                    secondCount += pressCount;
                }

                previousKey = key;
            }

            return secondCount;
        }
    }
}
