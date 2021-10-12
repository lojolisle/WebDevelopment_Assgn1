using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_project_assignment1_LisleLojo.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// GET api/AddTen/{id}
        /// variable value can be any integer inclusing negative integer
        /// endpoint will take given input and add 10 and will return result
        /// For Ex: api/AddTen/21 , here input is 21 and function return calculated value of (21+10) = 31
        /// </summary>
        /// <param name="id"></param>
        /// <returns>integer</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
