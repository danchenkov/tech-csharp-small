using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var subscriptions = db.Subscriptions.Where(x => x.RemovedAt == null).ToList();
                var subscriptionVms = new List<SubscriptionVm>();
                foreach (var subscription in subscriptions)
                {
                    var subscriptionVm = new SubscriptionVm();
                    subscriptionVm.Id = subscription.Id;
                    subscriptionVm.FirstName = subscription.FirstName;
                    subscriptionVm.LastName = subscription.LastName;
                    subscriptionVm.EmailAddress = subscription.EmailAddress;
                    subscriptionVms.Add(subscriptionVm);
                }

                return View(subscriptionVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var subscription = db.Subscriptions.Find(Id);
                subscription.RemovedAt = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}