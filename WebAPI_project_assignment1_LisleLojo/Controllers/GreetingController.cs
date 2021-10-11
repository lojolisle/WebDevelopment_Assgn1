using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_project_assignment1_LisleLojo.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        ///GET api/Greeting/{id}
        /// function gets an integer as an input and return a concatnated string
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Greetings to 5 people!</returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }


        /// <summary>
        /// POST api/Greeting
        /// This method is a POST call
        /// </summary>
        /// <returns> string </returns>
        public string Post()
        {
            return "Hello World!";
        }
    }

}
