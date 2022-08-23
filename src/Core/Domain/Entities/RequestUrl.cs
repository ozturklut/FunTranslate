using System;
using Domain.Common;

namespace Domain.Entities
{
	public class RequestUrl:BaseEntity
	{
		public string Url { get; set; }

		public TranslateRequest TranslateRequest { get; set; }
		public RequestUrl()
		{
			Url = "";
			//TranslateRequest = new TranslateRequest();
		}
	}
}

