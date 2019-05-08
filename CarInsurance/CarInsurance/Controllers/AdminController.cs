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
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurancePolicies = new List<PolicyVM>();
                foreach (var policy in db.Policies)
                {
                    var policyVm = new PolicyVM();
                    policyVm.Id = policy.Id;
                    policyVm.FirstName = policy.Person.FirstName;
                    policyVm.LastName = policy.Person.LastName;
                    policyVm.EmailAddress = policy.Person.Email;

                    decimal totalCost = 50.0M;
                    if (DateTime.Compare(DateTime.Now, policy.Person.Birthdate.AddYears(18)) < 0)
                    {
                        totalCost += 100;
                    }
                    else if (DateTime.Compare(DateTime.Now, policy.Person.Birthdate.AddYears(25)) < 0)
                    {
                        totalCost += 25;
                    }
                    if (DateTime.Compare(DateTime.Now, policy.Person.Birthdate.AddYears(100)) > 0)
                    {
                        totalCost += 25;
                    }

                    if (DateTime.Compare(policy.CarMake.Year, new DateTime(2000, 1, 1, 1, 0, 0)) < 0)
                    {
                        totalCost += 25;
                    } else if (DateTime.Compare(policy.CarMake.Year, new DateTime(2015, 1, 1, 1, 0, 0)) > 0)
                    {
                        totalCost += 25;
                    }

                    if (policy.CarMake.Make == "Porsche")
                    {
                        totalCost += 25;
                        if (policy.CarMake.Model == "911 Carrera")
                        {
                            totalCost += 25;
                        }
                    }

                    totalCost += policy.Tickets.Value * 10;
                    if (policy.DUI)
                    {
                        totalCost = Decimal.Multiply(totalCost, 1.25M);
                    }
                    if (policy.FullCoverage)
                    {
                        totalCost = Decimal.Multiply(totalCost, 1.5M);
                    }
                    policyVm.TotalCost = totalCost;
                    insurancePolicies.Add(policyVm);
                }

                return View(insurancePolicies);
            }
        }
    }
}