using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using DemoApplication.Models;
using Microsoft.Extensions.Configuration;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        public HomeController(IConfiguration configuration1)
        {
            configuration = configuration1;
        }


        [ViewData]
        public string Title { get; set; }

        public ViewResult Index()
        {
            //var res = configuration["AppName"];
            Title = "Home";
            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Us";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact Us";
            return View();
        }
    }
}
