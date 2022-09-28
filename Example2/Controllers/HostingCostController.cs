using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example2.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// This method returns the hosting cost. Hosting cost is $5.50 / FN (fortnight = 14 days), 
        /// plus an additional 13% HST
        /// </summary>
        /// <returns> The web hosting cost by fortnight, 13% HST, Total cost
        /// </returns>
        /// <param name="id">The number of days which has elapsed sicne the beginning of the hosting.</param>
        /// <example>
        /// GET: api/HostingCost/14 ->
        /// "2 fortnights at $5.50/FN = $11.00 CAD"
        /// "HST 13% = $1.43 CAD"
        /// "Total = $12.43 CAD"
        /// </example>

        public IEnumerable<string> Get(int id)
        {
            var Fortnights = (((id + 1) / 14) + 1);
            var Cost = Fortnights * 5.50;
            var Tax = Cost * 0.13;
            var Total = Cost + Tax;
            return new string[] {Fortnights + " fortnights at $5.50/FN = $"+ string.Format("{0:0.00}",Cost)+ " CAD",
                   "HST 13% = $" + string.Format("{0:0.00}",Tax) + " CAD",
                   "Total = $" + string.Format("{0:0.00}",Total) + " CAD"};
        }

    }
}
