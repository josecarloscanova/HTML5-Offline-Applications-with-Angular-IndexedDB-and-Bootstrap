using System;
using System.Web.Http;

namespace ApplicationCache.Controllers
{
    public class TimeController : ApiController
    {
        public string Get()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}