using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParks.Models;
using NationalParks.APIHandlerManager;
using NationalParks.DataAccess;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
namespace NationalParks.Controllers
{
    public class HomeController : Controller
    {
         public ApplicationDbContext dbContext;

         public HomeController(ApplicationDbContext context)
         {
            dbContext = context;         
         }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Parks()
        {
            APIHandler webHandler = new APIHandler();
            Parks parks = webHandler.GetParks();
            foreach (Park park in parks.data)
            {
                //Database will give PK constraint violation error when trying to insert record with existing PK.
                //So add company only if it doesnt exist, check existence using symbol (PK)
                if (dbContext.Parks.Where(p => p.id.Equals(park.id)).Count() == 0)
                {
                    dbContext.Parks.Add(park);
                }
            }

            dbContext.SaveChanges();
            
            return View(parks);
        }

        public IActionResult Campgrounds()
        {
            APIHandler webHandler = new APIHandler();
            RootObject dat = webHandler.GetCampgrounds();
            foreach (Datum data in dat.data)
            {
                //Database will give PK constraint violation error when trying to insert record with existing PK.
                //So add company only if it doesnt exist, check existence using symbol (PK)
                if (dbContext.RootObject.Where(p => p.parkCode.Equals(data.parkCode)).Count() == 0)
                {
                    dbContext.RootObject.Add(data);
                }
            }

            dbContext.SaveChanges();

            return View(dat);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
