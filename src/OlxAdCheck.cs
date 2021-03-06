using System;
using System.Linq;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Radz1u.Logic;

namespace Radz1u {
    public static class OlxAdCheck {

        [FunctionName ("OlxAdCheck")]
        public static void Run ([TimerTrigger ("0 0 4 * * *")] TimerInfo myTimer, ILogger log) {
            var olxAdsService = new OlxAdsService ();
            olxAdsService.CheckAds ().GetAwaiter ().GetResult ();
        }
    }
}