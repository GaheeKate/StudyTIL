using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example2.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method returns the square of the integer input {id}.
        /// </summary>
        /// <returns>id*id</returns>
        /// <param name="id">The integer input</param>
        /// <example>
        /// GET: api/Square/2 ->
        /// 4
        /// </example>
        public int Get(int id)
        {
            return id*id;
        }

    }
}

