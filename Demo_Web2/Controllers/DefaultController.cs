using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Web2.Controllers
{
    public class DefaultController : Controller
    {
        public string Index()
        {
            return "Nam Hoc Gioi";
        }
    }
}
