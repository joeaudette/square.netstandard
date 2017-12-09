using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SquareDemo.Web.Models;

using Square.Connect.Api;
using Square.Connect.Model;
using Square.Connect.Client;

//https://github.com/square/connect-api-examples/tree/master/connect-examples/v2/csharp_payment

namespace SquareDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<SquareSettings> squareSettingsAccessor)
        {
            _squareSettings = squareSettingsAccessor.Value;
        }

        private readonly SquareSettings _squareSettings;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SquareDemo()
        {
            var model = new SquareDemoViewModel();
            if(_squareSettings.UseProductionApi)
            {
                model.ApplicationId = _squareSettings.ProductionApplicationId;
                model.LocationId = _squareSettings.ProductionLocationId;
            }
            else
            {
                model.ApplicationId = _squareSettings.SandboxApplicationId;
                model.LocationId = _squareSettings.SandboxApplicationId;
            }

            return View(model);
        }

        private static string NewIdempotencyKey()
        {
            return Guid.NewGuid().ToString();
        }

        private string AccessToken()
        {
            if (_squareSettings.UseProductionApi)
            {
                return _squareSettings.ProductionAccessToken;
            }

            return  _squareSettings.SandboxAccessToken;
            
        }

        private string LocationId()
        {
            if (_squareSettings.UseProductionApi)
            {
                return _squareSettings.ProductionLocationId;
            }

            return _squareSettings.SandboxLocationId;

        }

        [HttpPost]
        public IActionResult SquareDemo(string nonce)
        {
            TransactionsApi transactionsApi = new TransactionsApi();
            transactionsApi.Configuration.AccessToken = AccessToken();
            // Every payment you process with the SDK must have a unique idempotency key.
            // If you're unsure whether a particular payment succeeded, you can reattempt
            // it with the same idempotency key without worrying about double charging
            // the buyer.
            string uuid = NewIdempotencyKey();

            // Monetary amounts are specified in the smallest unit of the applicable currency.
            // This amount is in cents. It's also hard-coded for $1.00,
            // which isn't very useful.
            Money amount = new Money(100, Money.CurrencyEnum.USD);

            // To learn more about splitting transactions with additional recipients,
            // see the Transactions API documentation on our [developer site]
            // (https://docs.connect.squareup.com/payments/transactions/overview#mpt-overview).
            ChargeRequest body = new ChargeRequest(AmountMoney: amount, IdempotencyKey: uuid, CardNonce: nonce);
            
            var model = new SquareChargeResultViewModel();
            
            try
            {
                model.Response = transactionsApi.Charge(LocationId(), body);
                
                //result =  "Transaction complete\n" + response.ToJson();
            }
            catch (ApiException e)
            {
                model.ErrorMessage =  e.Message;
            }

            return View("SquareResult", model);
        }
    }
}
