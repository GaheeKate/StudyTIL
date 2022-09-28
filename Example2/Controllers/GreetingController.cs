using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example2.Controllers
{
    public class GreetingController : ApiController
    {


        /// <summary>
        /// This method returns the string “Hello World!” 
        /// when receiving a post request
        /// </summary>
        /// <returns>“Hello World!”</returns>
        /// <example>
        /// POST: api/Greeting ->
        /// "Hello World!"
        /// </example>

        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns the string “Greetings to {id} people!” 
        /// where id is an integer value.
        /// </summary>
        /// <returns>"Greetings to {id} people!"</returns>
        /// <param name="id">The integer input</param>
        /// <example>
        /// GET: api/Greeting/3 ->
        /// "Greetings to 3 people!"
        /// </example>

        public string Get(int id)
        {
            return "Greetings to " + id +" people!";
        }


    }


}
