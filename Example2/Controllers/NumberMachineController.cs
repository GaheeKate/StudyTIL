using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example2.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method applies the four mathematical operations to the integer input
        /// and returns the calculation result.
        /// </summary>
        /// <returns>(((id + id) * id) - id) / id</returns>
        /// <param name="id">The integer input to calculate</param>
        /// <example>
        /// GET: api/NumberMachine/10 ->
        /// 19
        /// </example>
        /// <example>
        /// GET: api/NumberMachine/-5 ->
        /// -11
        /// </example>
        /// <example>
        /// GET: api/NumberMachine/30 ->
        /// 59
        /// </example>

        public int Get(int id)
        {
            return (((id + id) * id) - id) / id;
        }


    }
}
