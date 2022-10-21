using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        ///<summary>Determine the ways Diana can roll the value of 10</summary>
        ///<param name="m">The input {m} represents the number of sides on the first die</param>
        ///<param name="n">The input {n} represents the number of sides on the second die</param>
        ///<returns>The number of ways Diana can roll the value of 10</returns>
        ///<example>GET api/J2/DiceGame/6/8 -->"There are 5 total ways to get the sum 10"</example>
        ///<example>GET api/J2/DiceGame/12/4 -->"There are 4 total ways to get the sum 10"</example>
        ///<example>GET api/J2/DiceGame/3/3 -->"There are 0 total ways to get the sum 10"</example>
        ///<example>GET api/J2/DiceGame/5/5 -->"There are 1 total ways to get the sum 10"</example>

        //GET api/J2/DiceGame
        [Route("api/J2/DiceGame/{m}/{n}")]

        public IEnumerable<string> GetDiceGame(int m, int n)
        {
            int count = 0;

            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i+j == 10)
                        count++;
                }
            }
            
            return new string[] { "There are " + count + " total ways to get the sum 10." };
        }
    
    }
}
