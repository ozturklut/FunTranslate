using System;
using Domain.Common;

namespace Domain.Entities
{
	public class TranslateResponse : BaseEntity
	{
		public string TranslatedText { get; set; }

		public Guid TranslateRequestId { get; set; }

		public TranslateRequest TranslateRequest { get; set; }

		public TranslateResponse()
		{
			TranslatedText = "";

			//TranslateRequest = new TranslateRequest();
		}
	}
}

