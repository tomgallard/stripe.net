﻿namespace Stripe
{
	public class StripeDisputeService : StripeService
	{
		public StripeDisputeService(string apiKey = null) : base(apiKey) { }

		public bool ExpandCharge { get; set; }
		public bool ExpandBalanceTransaction { get; set; }

		public virtual StripeDispute Update(string chargeId, string evidence = null)
		{
			var url = string.Format("{0}/dispute", chargeId);
			url = this.ApplyAllParameters(null, url, false);

			if (!string.IsNullOrEmpty(evidence))
				url = ParameterBuilder.ApplyParameterToUrl(url, "evidence", evidence);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeDispute>.MapFromJson(response);
		}
	}
}