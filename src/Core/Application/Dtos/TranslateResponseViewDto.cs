using System;
namespace Application.Dtos
{
	public class TranslateResponseViewDto
	{
        public string? TranslatedText { get; set; }

        public Guid TranslateRequestId { get; set; }
    }
}

