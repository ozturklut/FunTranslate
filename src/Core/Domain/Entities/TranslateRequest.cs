using System;
using Domain.Common;

namespace Domain.Entities
{
	public class TranslateRequest : BaseEntity
	{	
		public string Text { get; set; }

		public Guid RequestUrlId { get; set; }

		public RequestUrl RequestUrl;

		public TranslateResponse TranslateResponse { get; set; }

		public TranslateRequest()
		{
			Text = "";

			//RequestUrl = new RequestUrl();

			//TranslateResponse = new TranslateResponse();
		}
	}
}

