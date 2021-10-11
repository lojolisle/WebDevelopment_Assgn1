using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_project_assignment1_LisleLojo.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// GET api/Square/{id}
        /// variable id can be any integer including negative integer
        /// endpoint will take given input and square the values
        /// For Ex: api/AddTen/4 , here input is 4 and function return calculated value of (4 * 4) = 16
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Integer </returns>
        public int Get(int id)
        {
            return id * id;
        }
    }
}
