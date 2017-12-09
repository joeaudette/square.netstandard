using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareDemo.Web.Models
{
    public class SquareSettings
    {
        public bool UseProductionApi { get; set; } = false;
        public string ProductionApplicationId { get; set; }

        public string ProductionAccessToken { get; set; }
        public string ProductionLocationId { get; set; }

        public string SandboxApplicationId { get; set; }

        public string SandboxAccessToken { get; set; }
        public string SandboxLocationId { get; set; }
    }
}
