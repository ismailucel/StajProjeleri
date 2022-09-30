using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ETicaretBasic.Data;
using ETicaretBasic.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using Stripe;
namespace ETicaretBasic.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _context;
        public async Task<IActionResult> Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Processing(string stripeToken, string stripeEmail)
        {
            var optionsCust = new CustomerCreateOptions
            {
                Email = stripeEmail,

            };
            var serviceCust = new CustomerService();
            Stripe.Customer customer = serviceCust.Create(optionsCust);
            var optionsCharge = new ChargeCreateOptions
            {
                /*Amount = HttpContext.Session.GetLong("Amount")*/
                Amount = 500,
                Currency = "USD",
                Description = "Buying Songs",
                Source = stripeToken,
                ReceiptEmail = stripeEmail,

            };
            var service = new ChargeService();
            Charge charge = service.Create(optionsCharge);
            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                ViewBag.AmountPaid = Convert.ToDecimal(charge.Amount) % 100 / 100 + (charge.Amount) / 100;
                ViewBag.BalanceTxId = BalanceTransactionId;
                ViewBag.Customer = customer.Name;

            }

            return View();
        }

    }
}
