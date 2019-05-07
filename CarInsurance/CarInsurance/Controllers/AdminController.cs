using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (PolicyEntities db = new PolicyEntities())
            {
                var insurancePolicies = new List<PolicyVM>();
                foreach (var policy in db.Policies)
                {
                    var policyVm = new PolicyVM();
                    policyVm.Id = policy.Id;
                    policyVm.FirstName = policy.Person.FirstName;
                    policyVm.LastName = policy.Person.LastName;
                    policyVm.EmailAddress = policy.Person.Email;

                    decimal totalCost = 50.0;
                    if ((DateTime.Now - policy.Person.Birthdate).TotalDays / 365 < 18)
                    {
                        totalCost += 100;
                    } else if ((DateTime.Now - policy.Person.Birthdate).TotalDays / 365 < 25)
                        {
                            totalCost += 25;
                        } else if ((DateTime.Now - policy.Person.Birthdate).TotalDays / 365 > 100)
                    {
                        totalCost += 25;
                    }
                    policyVm.TotalCost = totalCost;

                    if (policy.CarMake.Year < 2000)
                    {
                        totalCost += 25;
                    } else if (policy.CarMake.Year > 2015)
                    {
                        totalCost += 25;
                    }

                    insurancePolicies.Add(policyVm);
                }

                return View(insurancePolicies);
            }
        }
    }
}