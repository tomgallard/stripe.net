﻿using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCoupon : StripeBase
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("duration")]
		public string Duration { get; set; }

		[JsonProperty("duration_in_months")]
		public int? DurationInMonths { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("max_redemptions")]
		public int? MaxRedemptions { get; set; }

		[JsonProperty("amount_off")]
		public int? AmountOff { get; set; }

		[JsonProperty("percent_off")]
		public int? PercentOff { get; set; }

		[JsonProperty("redeem_by")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? RedeemBy { get; set; }

		[JsonProperty("times_redeemed")]
		public int TimesRedeemed { get; private set; }
	}
}
