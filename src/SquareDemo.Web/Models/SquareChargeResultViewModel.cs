using Square.Connect.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareDemo.Web.Models
{
    public class SquareChargeResultViewModel
    {
        public ChargeResponse Response { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;
    }

}
