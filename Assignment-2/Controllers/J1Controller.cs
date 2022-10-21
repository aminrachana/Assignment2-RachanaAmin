using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        ///<summary>Calculate the total Calorie Count</summary>
        ///<param name="burger">The input {burger} represents the calorie of Burger</param>
        ///<param name="drink">The input {drink} represents the calorie of drink</param>
        ///<param name="side">The input {side} represents the calorie of side</param>
        ///<param name="dessert">The input {dessert} represents the calorie of dessert</param>
        ///<returns>The total colrie count of input burger,drink,side and dessert</returns>
        ///<example>
        ///GET api/J1/Menu/4/4/4/4 -->"Your total calorie count is 0"
        ///</example>
        ///<example>
        ///GET api/J1/Menu/1/2/3/4 -->"Yuor total calorie count is 691"
        ///</example>

        //GET api/J1/Menu
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public IEnumerable<string> GetMenu(int burger, int drink, int side, int dessert)
        {
            int calorie = 0;
            if (burger == 1)
                calorie += 461;
            else if (burger == 2)
                calorie += 431;
            else if (burger == 3)
                calorie += 420;
            else if (burger == 4)
                calorie += 0;

            if (drink == 1)
                calorie += 130;
            else if (drink == 2)
                calorie += 160;
            else if (drink == 3)
                calorie += 118;
            else if (drink == 4)
                calorie += 0;

            if (side == 1)
                calorie += 100;
            else if (side == 2)
                calorie += 57;
            else if (side == 3)
                calorie += 70;
            else if (side == 4)
                calorie += 0;

            if (dessert == 1)
                calorie += 167;
            else if (dessert == 2)
                calorie += 266;
            else if (dessert == 3)
                calorie += 75;
            else if (dessert == 4)
                calorie += 0;

            return new string[] {"Your total calorie count is " + calorie };
        }
    }
}
