using RESTExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RESTExercise.Controllers
{
    public class BaseController : ApiController
    {
        public MyDbContext db = new MyDbContext();

        public BaseController() { }
    }
}