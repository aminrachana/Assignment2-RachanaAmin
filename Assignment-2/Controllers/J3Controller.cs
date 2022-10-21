using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Web.Http;
namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        ///<summary>Calculate the minimal time needed to type a message</summary>
        ///<param name="word">The input id represents the input word</param>
        ///<returns>The minimal number of seconds to type in the word</returns>
        ///<example>GET api/J3/Message/a --> 1</example>
        ///<example>GET api/J3/Message/dada --> 4</example>
        ///<example>GET api/J3/Message/bob --> 7</example>
        ///<example>GET api/J3/Message/abba --> 12</example>
        ///<example>GET api/J3/Message/cell --> 13</example>
        ///<example>GET api/J3/Message/www --> 7</example>
        ///<example>GET api/J3/Message/halt --> </example>

        //GET api/J3/Message
        [Route("api/J3/Message/{word}")]

        public int GetMessage(string word)
        {

            int count = 0;

            foreach (char i in word)
            {

                if (word == "halt")
                {
                    break;
                }
                count++;
            }
            return count;
        }
    }


}
