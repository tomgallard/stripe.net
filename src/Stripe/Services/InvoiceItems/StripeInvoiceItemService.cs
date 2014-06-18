﻿using System.Collections.Generic;

namespace Stripe
{
	public class StripeInvoiceItemService : StripeService
	{
		public StripeInvoiceItemService(string apiKey = null) : base(apiKey) { }

		public bool ExpandCustomer { get; set; }
		public bool ExpandInvoice { get; set; }

		public virtual StripeInvoiceItem Create(StripeInvoiceItemCreateOptions createOptions)
		{
			var url = this.ApplyAllParameters(createOptions, Urls.InvoiceItems, false);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Get(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			url = this.ApplyAllParameters(null, url, false);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual StripeInvoiceItem Update(string invoiceItemId, StripeInvoiceItemUpdateOptions updateOptions)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);
			url = this.ApplyAllParameters(updateOptions, url, false);

			var response = Requestor.PostString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapFromJson(response);
		}

		public virtual void Delete(string invoiceItemId)
		{
			var url = string.Format("{0}/{1}", Urls.InvoiceItems, invoiceItemId);

			Requestor.Delete(url, ApiKey);
		}

		public virtual IEnumerable<StripeInvoiceItem> List(StripeInvoiceItemListOptions listOptions = null)
		{
			var url = Urls.InvoiceItems;
			url = this.ApplyAllParameters(listOptions, url, true);

			var response = Requestor.GetString(url, ApiKey);

			return Mapper<StripeInvoiceItem>.MapCollectionFromJson(response);
		}
	}
}