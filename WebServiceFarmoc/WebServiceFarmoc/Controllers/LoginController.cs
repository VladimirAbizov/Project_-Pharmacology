﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServiceFarmoc.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public string Login(String login, String key)
        {
            string[] str = new string[] {"vladimir321275", "natalia1996", "junior1000"};
           
            string ret = "NO";
            string LogAndPass = login + key;
            foreach(string s in str)
            {
                if (s.Equals(LogAndPass))
                { 
                    ret = "OK";
                    break;
                }
            }
            return ret;
            //return new HttpResponseMessage(HttpStatusCode.OK);
        }
        

        /*
        // GET api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/login
        public void Post([FromBody]string value)
        {
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
         */
    }
}