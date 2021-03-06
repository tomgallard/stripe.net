﻿using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    public class StripeBalanceTransaction :StripeBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("amount")]
        public int AmountInCents { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("net")]
        public int NetAmountCents { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("available_on")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime AvailableOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fee")]
        public int FeeInCents { get; set; }

        [JsonProperty("fee_details")]
        public List<StripeFee> FeeDetails { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }
    }
}
