using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class InsuranceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("New");
        }
        [HttpPost]
        public ActionResult Create(string firstName, string lastName, string emailAddress, string birthDate, string carYear, string carMake, string carModel, string dui, int tickets, string fullCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var driver = new Person();
                    driver.FirstName = firstName;
                    driver.LastName = lastName;
                    driver.Email = emailAddress;
                    driver.Birthdate = DateTime.Parse(birthDate);
                    db.People.Add(driver);

                    var car = new CarMake();
                    car.Make = carMake;
                    car.Model = carModel;
                    car.Year = DateTime.ParseExact(carYear, "yyyy", CultureInfo.InvariantCulture);
                    db.CarMakes.Add(car);

                    var policy = new Policy();
                    policy.Person = driver;
                    policy.CarMake = car;
                    policy.FullCoverage = (fullCoverage == "Full");
                    policy.DUI = (dui == "True");
                    policy.Tickets = tickets;
                    db.Policies.Add(policy);

                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Admin");
            }
        }
    }
}