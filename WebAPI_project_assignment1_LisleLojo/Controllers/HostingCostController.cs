using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_project_assignment1_LisleLojo.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// GET api/HostingCost/{id}
        /// Function receives a value representing  the number of days elapsed since the beginning of hosting,
        /// the function then uses this value to compute the charges applied including taxes and return all these three
        /// results as an array
        /// Given fornight = 14 days
        /// Client is charged $5.50 per 14 (fortnight) days
        /// Therefore, Charges = 5.50 * (id / 14);
        /// Tax of 13% computed on charges 
        /// Total charge = charges + Tax
        /// </summary>
        /// <param name="id"></param>
        /// <returns>array of strings </returns>
        public IEnumerable<string> Get(int id)
        {
            double FN = 1;
            if (id > 0)
            {
                FN = id / 14;
                FN = Math.Floor(FN); //rounding down
            };
            double charges = 5.50 * FN;
            double hst = charges * 0.13;
            double total_charges = charges + hst;
            string fortnight_charges = FN + " fortnights at $5.50/FN = $" + charges + " CAD";
            string tax = "HST 13% = $" + hst + " CAD";
            string hosting_cost = "Total = " + total_charges + " CAD";
            return new string[] { fortnight_charges, tax, hosting_cost };

        }

    }
}
