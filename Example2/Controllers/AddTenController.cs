using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example2.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method returns 10 more than the integer input {id}.
        /// </summary>
        /// <returns>id+10</returns>
        /// <param name="id">The integer input</param>
        /// <example>
        /// GET: api/AddTen/21 ->
        /// 31
        /// </example>

        public int Get(int id)
        {
            return id + 10;
        }


    }
}


